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
       
        public string Descripcion { get; set; }

        public int IDPregunta { get; set; }

        public int IDCuestionario { get; set; }

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
