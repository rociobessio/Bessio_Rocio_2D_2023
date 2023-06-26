using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
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
        private bool reposicionEnProgreso; 

        /// <summary>
        /// SemaphoreSlim me permite settear un maximo
        /// de hilos concurrentes que voy a poder utilizar.
        /// </summary>
        private SemaphoreSlim _semaphoreSlim;
        private List<Task> _reposicionTasks;
        #endregion

        #region PROPIEDAD
        /// <summary>
        /// Propiedad que me permite saber si la reposicion
        /// esta en progreso.
        /// </summary>
        public bool ReposicionEnProgreso { get { return this.reposicionEnProgreso; } }
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
            this.reposicionEnProgreso = true;
        }
        #endregion

        #region METODOS  
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productos"></param>
        public void Reponiendo(List<Producto> productos)
        {
            this.reposicionEnProgreso = false;
            try
            {
                foreach (Producto producto in productos)//-->recorro la lista de productos.
                { 
                    if(producto.Stock == 0)//-->Verifico que Stock sea == 0
                    {
                        this._semaphoreSlim.Wait(); //--->Espero a que el semaphoro tenga espacio
                        Task task = Task.Run(() =>//-->Runneo la Task
                        {
                            for (int i = 1; i <= 10; i++)//-->Reposicion maximo a 10
                            { 
                                Thread.Sleep(2000);//-->Cada 2 segundos
                                producto.Stock = i;//-->Repongo
                                this._productoDAO.UpdateProducto(producto);//-->Actualizo el producto en la base
                            }
                            this._semaphoreSlim.Release();//-->Libero espacio en el "Semaforo" y permito que otro hilo lo utilice
                        });
                        this._reposicionTasks.Add(task);//-->Añado la tarea a la lista de tareas.
                    } 
                } 
                Task.WaitAll(this._reposicionTasks.ToArray());//-->Espero a que todas las tareas finalicen antes de seguir
                this.reposicionEnProgreso = true;//-->Cambio a true
                EventoReposicionFinalizada?.Invoke();//-->Finalice, invoco a mi metodo
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally//-->Por las dudas utilizo un try-catch-finally.
            {
                 Console.WriteLine("Ocurrio un problema.");
            }
      } 
    }
    #endregion

}
