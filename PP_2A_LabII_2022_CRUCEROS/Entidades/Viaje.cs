using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Viaje
    {
        #region ATRIBUTOS
        private double costoPasajeTurista;
        private double costoPasajePremium;

        private int cantCamerotesPremiumDisponibles;//Para calcular
        private int cantCamerotesTuristaDisponibles;//Calcular
        private int cantBodegaDisponible;

        private string ciudadPartida;
        private string destino;
        private DateTime fechaSalida;
        private DateTime fechaVuelta;

        private List<Pasajero> listaPasajeros;
        private Crucero cruceroAsignado;

        private int duracionViaje;
        private Random duracionRandom;

        //CHEQUEAR, son atributos estaticos que unicamente se pueden LEER 
        private static readonly double precioExtraPremium = 1.2;
        private static readonly int precioPorHoraRegional = 57;
        private static readonly int precioPorHoraExtraregional = 120;
        private static readonly int duracionMinimaRegional = 72;
        private static readonly int duracionMaximaRegional = 360 + 1;
        private static readonly int duracionMinimaExtraregional = 480;
        private static readonly int duracionMaximaExtraregional = 720 + 1;

        #endregion

        #region PROPIEDADES
        public string CiudadPartida { get { return this.ciudadPartida; } }
        public string Destino { get { return this.destino; } }
        public DateTime FechaSalida { get { return this.fechaSalida; } }
        public DateTime FechaVuelta { get { return this.fechaVuelta; } }
        public double CostoPasajeTurista { get { return this.costoPasajeTurista; } }
        public double CostoPasajePremium { get { return this.costoPasajePremium; } }
        public int DuracionDelViaje { get { return this.duracionViaje; } }
        public static int DuracionMaximaRegional { get { return Viaje.duracionMaximaRegional; } }
        public static int DuracionMaximaExtraRegional { get { return Viaje.duracionMaximaExtraregional; } }
        public int CantCamarotesTurista { get { return this.cantCamerotesTuristaDisponibles; } set { this.cantCamerotesTuristaDisponibles = value; } }
        public int CantCamarotesPremium { get { return this.cantCamerotesPremiumDisponibles; } set { this.cantCamerotesPremiumDisponibles = value; } }
        public int CantBodega { get { return this.cantBodegaDisponible; } set { this.cantBodegaDisponible = value; } }
        public Crucero Crucero { get { return this.cruceroAsignado; } }
        public List<Pasajero> ListaPasajeros { get { return this.listaPasajeros; } }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor estatico privado de la clase Viaje.
        /// </summary>
        /// <param name="fechaSalida"></param>
        /// <param name="crucero"></param>
        private Viaje(DateTime fechaSalida, Crucero crucero)
        {
            this.listaPasajeros = new List<Pasajero>();
            this.cruceroAsignado = crucero;
            this.ciudadPartida = "Buenos Aires";//Todos los cruceros salen del puerto de Buenos Aires.
            this.fechaSalida = fechaSalida;
            this.fechaVuelta = new DateTime();
            this.duracionRandom = new Random();
            this.cantCamerotesPremiumDisponibles = crucero.CantCamarotesPremium;
            this.cantCamerotesTuristaDisponibles = crucero.CantCamarotesTuristas;
            this.cantBodegaDisponible = crucero.Bodega;
        }

        /// <summary>
        /// Constructor publico de la clase Viaje.
        /// Me permite calcular la duracion (RANDOM) del viaje y realizar los costos
        /// de los pasajes tanto Premium como Turista de un DESTINO REGIONAL.
        /// </summary>
        /// <param name="fechaSalida"></param>
        /// <param name="crucero"></param>
        /// <param name="destino"></param>
        public Viaje(DateTime fechaSalida, Crucero crucero, DestinoRegional destino) : this(fechaSalida, crucero)
        {
            this.duracionViaje = this.duracionRandom.Next(duracionMinimaRegional, duracionMaximaRegional);
            this.destino = destino.ToString().Replace("_", ", ").Replace("1", " ");
            this.costoPasajeTurista = this.duracionViaje * precioPorHoraRegional;
            this.costoPasajePremium = this.costoPasajeTurista * precioExtraPremium;
            this.fechaVuelta = this.fechaSalida.AddDays(duracionViaje / 24);
        }

        /// <summary>
        /// Constructor público de la clase Viaje.
        /// Me permite calcular la duracion (RANDOM) del viaje y realizar los costos
        /// de los pasajes tanto Premium como Turista de un DESTINO EXTRA REGIONAL.
        /// </summary>
        /// <param name="fechaSalida"></param>
        /// <param name="crucero"></param>
        /// <param name="destino"></param>
        public Viaje(DateTime fechaSalida, Crucero crucero, EDestinoExtraRegional destino) : this(fechaSalida, crucero)
        {
            this.duracionViaje = this.duracionRandom.Next(duracionMinimaExtraregional, duracionMaximaExtraregional);
            this.destino = destino.ToString().Replace("_", ", ").Replace("1", " ");
            this.costoPasajeTurista = this.duracionViaje * precioPorHoraExtraregional;
            this.costoPasajePremium = this.costoPasajeTurista * precioExtraPremium;
            this.fechaVuelta = this.fechaSalida.AddDays(duracionViaje / 24);
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Se fija si el pasajero no esta en la lista del viaje,
        /// despues chequea que el peso de la valija no pase la disponibilidad
        /// de la Bodega. Por ultimo chequea de que clase es el pasajero y
        /// si hay lugar en la clase de camarote que le corresponda.
        /// Si pasa los chequeos, lo añade a la lista, resta el camarote
        /// y le quita lugar a la bodega.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Viaje operator +(Viaje v, Pasajero p)
        { 
            if (v is not null && p is not null)
            {
                if (!v.listaPasajeros.Contains(p))
                {
                    if (v.CantBodega >= p.Equipaje.PesoTotalValija)
                    {
                        if (p.Clase == Clase.Turista)
                        {
                            if (v.CantCamarotesTurista > 0)
                            {
                                v.listaPasajeros.Add(p);
                                v.CantCamarotesTurista--;
                                v.CantBodega -= p.Equipaje.PesoTotalValija;
                            }
                        }
                        else
                        {
                            if (v.CantCamarotesPremium > 0)
                            {
                                v.listaPasajeros.Add(p);
                                v.CantCamarotesPremium--;
                                v.CantBodega -= p.Equipaje.PesoTotalValija;
                            }
                        }
                    }
                } 
            }
            return v;
        }

        /// <summary>
        /// Me permite agregar un pasajero a la lista del viaje.
        /// </summary>
        /// <param name="viaje"></param>
        /// <param name="listPasajeros"></param>
        /// <returns></returns>
        public static Viaje operator +(Viaje viaje, List<Pasajero> listPasajeros)
        {
            foreach (Pasajero pasajero in listPasajeros)
            {
                viaje += pasajero;
            }

            return viaje;
        }

        public static bool operator ==(Viaje viaje, string[] matriculaFecha)
        {
            return viaje.cruceroAsignado.Matricula == matriculaFecha[0] && $"{viaje.FechaSalida:d}" == matriculaFecha[1];
        }
        public static bool operator !=(Viaje viaje, string[] matriculaFecha)
        {
            return !(viaje == matriculaFecha);
        }

        /// <summary>
        /// Compara si el crucero asignado al viaje es el mismo crucero 
        /// que recibe como parametro.
        /// </summary>
        /// <param name="viaje"></param>
        /// <param name="crucero"></param>
        /// <returns></returns>
        public static bool operator ==(Viaje viaje, Crucero crucero)
        {
            return viaje.cruceroAsignado == crucero;
        }
        public static bool operator !=(Viaje viaje, Crucero crucero)
        {
            return !(viaje == crucero);
        }
        #endregion 

        #region POLIMORFISMO
        /// <summary>
        /// Utilizo un OVERRIDE del metodo .ToString()
        /// para imprimir la informacion sobre el viaje.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El viaje será de {this.ciudadPartida} hasta {this.destino}. ");
            sb.AppendLine($"Comenzando el día {this.fechaSalida:d} finalizando el día {this.fechaVuelta:d}");
            sb.AppendLine($"Contará con una duración de {this.duracionViaje} hs.");
            sb.AppendLine($"Dicho viaje será en el Crucero: {this.cruceroAsignado.Nombre} con matricula {this.cruceroAsignado.Matricula}");
            sb.AppendLine($"Queda un total de {this.cantCamerotesTuristaDisponibles} camarotes turistas libres");
            sb.AppendLine($"Los cuales cuestan cada uno { this.costoPasajeTurista}");
            sb.AppendLine($"Queda un total de {this.cantCamerotesPremiumDisponibles} camarotes premiums libres");
            sb.AppendLine($"Los cuales cuestan cada uno { this.costoPasajePremium}");
            sb.AppendLine($"La bodega de este viaje cuenta con una disponibilidad de {this.cantBodegaDisponible} kgs.");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is not null)
            {
                if (obj is Viaje)
                {
                    retorno = this == obj as Viaje;
                }
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
