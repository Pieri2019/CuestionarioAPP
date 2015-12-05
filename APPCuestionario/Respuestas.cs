using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{
    public class Respuesta
    {

        #region Propiedades

        
        public int IDRespuesta { get; set; }
      

        public int IDPregunta { get; set; }


        public int IDAlternativa { get; set; }


        public Alternativa Alternativa { get; set; }


        public int IDCuestionarioRealizado { get; set; }


        public CuestionarioRealizado CuestionarioRealizado { get; set; }

        #endregion
        #region Metodos

      
        public void Resolver()
        {
          
        } 
        #endregion
    }
}