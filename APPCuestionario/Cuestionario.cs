using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{
    public class Cuestionario
    {
        public int Descripcion { get; set; }

        public int FechaFin { get; set; }

        public int FechaInicio { get; set; }

        public int IDCuestionario { get; set; }

        public int NPreguntas { get; set; }

        public int Orden { get; set; }

        public int Tiempo { get; set; }

        public int Titulo { get; set; }
        public ICollection<EstadoDeCuestionario> EstadoDeCuestionarios { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Pregunta> Preguntas { get; set; }

    
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
