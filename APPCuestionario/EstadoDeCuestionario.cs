using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{
    /// <summary>
    /// Clase utilizada para la representación del Estado de cuestionario
    /// </summary>
    public class EstadoDeCuestionario
    {

        #region Propiedades

        /// <summary>
        /// Descripcion del Estado
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// ID del estado de cuestionario
        /// </summary>
        public int IDEstadoDeCuestionario { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de la clase Cuestionario
        /// </summary>
        private EstadoDeCuestionario() { }

        #endregion
        #region Metodos


        public void Actualizar(string descrip_estado, int id_estado)
        {

            Descripcion = descrip_estado;
            IDEstadoDeCuestionario = id_estado;
            
        }

        public static EstadoDeCuestionario  Agregar(string descrip_estado, int id_estado)
        {
            return (
                 new EstadoDeCuestionario ()
                 {
                     Descripcion = descrip_estado,
                     IDEstadoDeCuestionario= id_estado
                 }
              );
        }
        
        #endregion
    }
}
