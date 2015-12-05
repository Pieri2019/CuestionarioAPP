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
        /// <summary>
        /// Descripción del cuestionarioRealizado
        /// </summary>
        public int Descripcion { get; set; }

        /// <summary>
        /// Duracion de Cuestionario relizado
        /// </summary>
        public int Duracion { get; set; }

        /// <summary>
        /// Fecha de culminacion de CuestionarioRealizado
        /// </summary>
        public int FechaTermino { get; set; }


        public int IDCuestionarioRealizado { get; set; }


        public int IDCuestionario { get; set; }


        public int IDUsuario { get; set; }

        public Usuario Usuario { get; set; }

        public Cuestionario Cuestionario { get; set; }


        public void Agregar()
        {
            throw new System.NotImplementedException();
        }

        public void Realizar()
        {
            throw new System.NotImplementedException();
        }
    }
}