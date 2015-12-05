using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{
    /// <summary>
    /// Clase utilizada para la representación de un Cuestionario
    /// </summary>
    public class Cuestionario
    {
        /// <summary>
        /// Descripción del cuestionario
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Fecha de finalizacion del cuestionario
        /// </summary>
        public DateTime FechaFin { get; set; }

        /// <summary>
        /// Fecha de inicio del cuestionario
        /// </summary>
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Identificador del cuestionario
        /// </summary>
        public int IDCuestionario { get; set; }


        /// <summary>
        /// Identificador de la posición del cuestionario
        /// </summary>
        public int Orden { get; set; }

        /// <summary>
        /// Tiempo de duración del cuestionario
        /// </summary>
        public DateTime Tiempo { get; set; }

        /// <summary>
        /// Titulo del cuestionario
        /// </summary>
        public string Titulo { get; set; }

        public int IDEstadoDeCuestionario { get; set; }
        /// <summary>
        /// Lista de estados del cuestionario
        /// </summary>
        public EstadoDeCuestionario Estado { get; set; }

        public int IDUsuario { get; set; }
        /// <summary>
        /// Lista de usuarios disponibles por cuestionario
        /// </summary>
        public Usuario Creador { get; set; }

        /// <summary>
        /// Lista de preguntas por cuestionario
        /// </summary>
        //public ICollection<Pregunta> Preguntas { get; set; }

        /// <summary>
        /// Constructor de la clase Cuestionario
        /// </summary>
        /// 
        private Cuestionario()
        {

        }
        /// <summary>
        /// Método que se utilizará para actualizar la información de un cuestionario
        /// </summary>
        /// <param name="descrip_cues">Descripcion del cuestionario</param>
        /// <param name="fecfin_cues">Fecha de finalizacion del cuestionario</param>
        /// <param name="fecini_cues">Fecga de inicio del cuestionario</param>
        /// <param name="orden_cues">Identificador de la posición del cuestionario</param>
        /// <param name="tiemp_cues">Tiempo de duracion del cuestionario</param>
        /// <param name="titu_cues">Titulo del cuestionario</param>
        /// <returns></returns>
        public void Actualizar(string descrip_cues, DateTime fecfin_cues, DateTime fecini_cues, int orden_cues, DateTime tiemp_cues, string titu_cues)
        {
            Descripcion = descrip_cues;
            FechaFin = fecfin_cues;
            FechaInicio = fecini_cues;
            Orden = orden_cues;
            Tiempo = tiemp_cues;
            Titulo = titu_cues;
        }

        /// <summary>
        /// Método que se utilizará para agregar un cuestionario
        /// </summary>
        /// <param name="descrip_cues">Descripcion del cuestionario</param>
        /// <param name="fecfin_cues">Fecha de finalizacion del cuestionario</param>
        /// <param name="fecini_cues">Fecga de inicio del cuestionario</param>
        /// <param name="orden_cues">Identificador de la posición del cuestionario</param>
        /// <param name="tiemp_cues">Tiempo de duracion del cuestionario</param>
        /// <param name="titu_cues">Titulo del cuestionario</param>
        /// <returns></returns>
        public static Cuestionario Agregar(string descrip_cues, DateTime fecfin_cues, DateTime fecini_cues, int orden_cues, DateTime tiemp_cues, string titu_cues)
        {
            return (
                new Cuestionario()
                {
                    Descripcion = descrip_cues,
                    FechaFin = fecfin_cues,
                    FechaInicio = fecini_cues,
                    Orden = orden_cues,
                    Tiempo = tiemp_cues,
                    Titulo = titu_cues
                }
                );
        }

        public void Anular()
        {
            throw new System.NotImplementedException();
        }
    }
}
