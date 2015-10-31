using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{
 /// <summary>
 /// Clase utilizada para la representación de un Usuario 
 /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Apellido del Usuario
        /// </summary>
        public string Apellido { get; set; }
        /// <summary>
        /// Contraseña del Usuario
        /// </summary>
        public string Contraseña { get; set; }
        /// <summary>
        /// Identificador del Usuario
        /// </summary>
        public int IDUsuario { get; set; }

        /// <summary>
        /// Nombre del Usuario
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Rol designado al Usuario
        /// </summary>
        public string Rol { get; set; }
        /// <summary>
        /// Lista de Cuestionarios
        /// </summary>
        public ICollection<Cuestionario> Cuestionarios { get; set; }

        /// <summary>
        /// Constructor de la clase Usuario
        /// </summary>
        private Usuario() { 
        
        }


        /// <summary>
        /// Método que se utilizará para actualizar la información de un usuario
        /// </summary>
        /// <param name="nomb_usu">Nombre del usuario</param>
        /// <param name="ape_usu">Apellido del usuario</param>
        /// <param name="con_usu">Contraseña del usuario</param>
        /// <returns></returns>
        
        //Previamente se obtiene el ID del usuario que se desea modificar la información.
        public static Usuario Actualizar(string nomb_usu, string ape_usu, string con_usu)
        {
            return (
                new Usuario()
                {
                    Nombre = nomb_usu,
                    Apellido = ape_usu,
                    Contraseña = con_usu
                }
                );


        }

        /// <summary>
        /// Método que se utilizará para agregar un Usuario
        /// </summary>
        /// <param name="nomb_usu">Nombre del usuario</param>
        /// <param name="ape_usu">Apellido del usuario</param>
        /// <param name="con_usu">Contraseña del usuario</param>
        /// <param name="rol_usu">Rol que desempeña el usuario</param>
        /// <returns></returns>
        public static Usuario Agregar(string nomb_usu, string ape_usu, string con_usu, string rol_usu)
        {
            return(
                
                new Usuario(){
                Nombre= nomb_usu,
                Apellido= ape_usu,
                Contraseña= con_usu,
                Rol =rol_usu

                } ) ;


        }
    }
}
