using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{ 
        /// <summary>
        /// Clase utilizada para la representación de Pregunta
        /// </summary>

    public class Pregunta
    {

        #region Propiedades
        /// <summary>
        /// Descripcion de la Pregunta
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// ID de la Pregunta
        /// </summary>
        public int IDPregunta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IDCuestionario { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Cuestionario Cuestionario { get; set; }

        #endregion
        //public ICollection<Alternativa> Alternativas { get; set; }


        #region Metodos

        
        public void Actualizar()
        {
           
        }

        public void Agregar()
        {
           
        }

        public void Anular()
        {
           
        }
        #endregion
    }
}
