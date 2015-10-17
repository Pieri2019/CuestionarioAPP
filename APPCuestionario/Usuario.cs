using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{
    public class Usuario
    {
        public int Apellido { get; set; }
        public int Contraseña { get; set; }
        public int IDUsuario { get; set; }
        public int Login { get; set; }
        public int Nombre { get; set; }
        public int Rol { get; set; }
        public ICollection<Cuestionario> Cuestionarios { get; set; }


        public void Actualizar()
        {
            throw new System.NotImplementedException();
        }

        public void Agregar()
        {
            throw new System.NotImplementedException();
        }
    }
}
