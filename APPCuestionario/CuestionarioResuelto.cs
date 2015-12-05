using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{
    /// <summary>
    /// Clase utilizada para la representación de un CuestionarioRealizado
    /// </summary>
    public class CuestionarioRealizado
    {
        #region Propiedades

        /// <summary>
        /// Duracion de Cuestionario relizado
        /// </summary>
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Fecha de culminacion de CuestionarioRealizado
        /// </summary>
        public DateTime FechaTermino { get; set; }

        /// <summary>
        /// Identificador de cuestionario realizado
        /// </summary>
        public int IDCuestionarioRealizado { get; set; }

        /// <summary>
        /// Identificador de Cuestionario
        /// </summary>
        public int IDCuestionario { get; set; }

        /// <summary>
        /// Identificador de usuario
        /// </summary>
        public int IDUsuario { get; set; }

        /// <summary>
        /// Nombre de Usuario
        /// </summary>
        public Usuario Usuario { get; set; }

        /// <summary>
        /// Nombre de Cuestionario
        /// </summary>
        public Cuestionario Cuestionario { get; set; }

        public ICollection<Respuesta> Respuestas { get; set; }

        #endregion




        #region constructor
        private CuestionarioRealizado()
        {

        }
        #endregion

        /// <summary>
        /// Agregar nuevo cuestionario
        /// </summary>
        public static CuestionarioRealizado Agregar(Cuestionario ao_cuestionario, Tuple<DateTime,DateTime> atp_lapso, List<Respuesta> alo_respuestas, Usuario ao_usuario )
        {
            return new CuestionarioRealizado()
            {
                IDCuestionario = ao_cuestionario.IDCuestionario,
                Cuestionario = ao_cuestionario,
                FechaInicio = atp_lapso.Item1,
                FechaTermino = atp_lapso.Item2,
                IDUsuario = ao_usuario.IDUsuario,
                Usuario = ao_usuario,
                Respuestas = alo_respuestas
            };
            
        }

    }
}