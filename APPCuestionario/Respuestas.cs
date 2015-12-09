using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{

    /// <summary>
    /// Clase utilizada para la representación de Respuestas
    /// </summary>
    public class Respuesta
    {

        #region Propiedades

        /// <summary>
        /// 
        /// </summary>
        public int IDRespuesta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IDPregunta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IDAlternativa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Alternativa Alternativa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IDCuestionarioRealizado { get; set; }

        public Pregunta Pregunta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CuestionarioRealizado CuestionarioRealizado { get; set; }

        #endregion
        #region Metodos

      
        public void Resolver()
        {
          
        } 
        #endregion
    }
}