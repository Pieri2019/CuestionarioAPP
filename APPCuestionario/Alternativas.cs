using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{
    /// <summary>
    /// Clase utilizada para la representación de Alternativas
    /// </summary>
    public class Alternativas
    {
        /// <summary>
        /// Describe la alternativa
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Identificador de la Alternativa
        /// </summary>
        public int  IDAlternativa { get; set; }

        /// <summary>
        /// Indica si la alternativa es correcta o no
        /// </summary>
        public string RAlternativa { get; set; }
        
        /// <summary>
        /// Lista de Alternativas por pregunta
        /// </summary>
        public Pregunta Pregunta { get; set; }

        /// <summary>
        /// Constructor de la clase Alternativas
        /// </summary>
        private Alternativas()
        { 
        }

        /// <summary>
        /// Método que se utilizará para actualizar alternativas de una pregunta
        /// </summary>
        /// <param name="descrip_al">Descripción de la Alternativa</param>
        /// <param name="r_al">Indica si el resultado es correcto o no </param>
        /// <returns></returns>
    
        public static Alternativas Actualizar(string descrip_al, string r_al)
        {
            return (
                new Alternativas()
                {
                    Descripcion = descrip_al,
                    RAlternativa = r_al

                }
                );
        }

        /// <summary>
        /// Método que se utilizará para agregar alternativas a una pregunta
        /// </summary>
        /// <param name="descrip_al">Descripción de la Alternativa</param>
        /// <param name="r_al">Indica si el resultado es correcto o no </param>
        /// <returns></returns>

        public static Alternativas Agregar(string descrip_al, string r_al)
        {
            return (
                new Alternativas
                {
                    Descripcion= descrip_al,
                    RAlternativa=r_al

                });
        }

        public void Eliminar(Pregunta ao_pregunta)
        {
            
        }
    }
}
