using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    /// <summary>
    /// La clase repositor me permitirá
    /// reponer en tiempo real, utilizando
    /// delegados, eventos, hilos y concurrencia.
    /// </summary>
    public class Repositor
    {
        #region ATRIBUTOS 
        private ProductoDAO _productoDAO; 

        /// <summary>
        /// Declaro mi delegado de repositor,
        /// retorna void y no recibe nada.
        /// </summary>
        public delegate void DelegadoReposicionFinalizada();
        /// <summary>
        /// Declaro mi evento del tipo delegate
        /// DelegadoReposicionFinalizada EventoReposicionFinalizada
        /// me servirá para saber si finalizo la reposicion.
        /// </summary>
        public event DelegadoReposicionFinalizada EventoReposicionFinalizada;
        private bool reposicionTerminada; 

        /// <summary>
        /// SemaphoreSlim me permite settear un maximo
        /// de hilos concurrentes que voy a poder utilizar.
        /// </summary>
        private SemaphoreSlim _semaphoreSlim;
        /// <summary>
        /// La lista de tareas, tendrá.
        /// </summary>
        private List<Task> _reposicionTasks;
        #endregion

        #region PROPIEDAD
        /// <summary>
        /// Propiedad que me permite saber si la reposicion
        /// esta en progreso.
        /// </summary>
        public bool ReposicionTerminada { get { return this.reposicionTerminada; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// El constructor me permitirá inicializar
        /// todos los atributos.
        /// </summary>
        public Repositor()
        {
            this._productoDAO = new ProductoDAO();  
            this._semaphoreSlim = new SemaphoreSlim(8);//-->Maximo de hilos que podre usar
            this._reposicionTasks = new List<Task>(); 
            this.reposicionTerminada = true;
        }
        #endregion

        #region METODOS  
        /// <summary>
        /// Este medoto Reponiendo,
        /// me permite reponer mas de un producto a la vez
        /// utilizando multiples hilos. Uso el objeto 
        /// SemaphoreSlim que me deja settear un maximo de hilos
        /// concurrentes que podre usar, 5 en este caso. 
        /// Irá reponiendo cada 2 segundos hasta llegar a 10 en
        /// su stock, a su vez ira realizando los cambios en la
        /// tabla de la base de datos.
        /// Una vez finalizado, la bandera vuelve a true, 
        /// diciendo que termino e invoco a mi metodo
        /// para avisar que ha terminado de reponer.
        /// </summary>
        /// <param name="productos"></param>
        public void Reponiendo(List<Producto> productos)
        {
            this.reposicionTerminada = false;
            try
            {
                foreach (Producto producto in productos)//-->recorro la lista de productos.
                { 
                    if(producto.Stock == 0)//-->Verifico que Stock sea == 0
                    {
                        //--->Bloqueo el hilo actual hasta q entre el "semaforo", controlando
                        //la cantidad de hilos que se pueden tener con SemaphoreSlim
                        this._semaphoreSlim.Wait();
                        Task task = Task.Run(() =>//-->Creo/Runneo nueva Tarea
                        {
                            for (int i = 1; i < 15; i++)//-->Reposicion maximo a 14
                            { 
                                Thread.Sleep(2000);//-->Cada 2 segundos
                                producto.Stock = i;//-->Repongo
                                if (!this._productoDAO.UpdateDato(producto))//-->Actualizo el producto en la base, si no pudo lanzo exception
                                    throw new SQLUpdateException("Ocurrio un error al intentar actualizar el producto.");
                            }
                            this._semaphoreSlim.Release();//-->Libero espacio en el "Semaforo" y permito que otro hilo lo utilice
                        });
                        this._reposicionTasks.Add(task);//-->Añado la tarea a la lista de tareas.
                    } 
                } 
                Task.WaitAll(this._reposicionTasks.ToArray());//-->Espero a que todas las tareas finalicen antes de seguir
                this.reposicionTerminada = true;//-->Cambio a true
                EventoReposicionFinalizada?.Invoke();//-->Finalice, invoco a mi evento para avisar q termine de reponer
            } 
            catch (Exception)
            {
                this.reposicionTerminada = false;
                throw new Exception("Sucedio algo inesperado al intentar reponer.");
            } 
        } 
    }
    #endregion

}
