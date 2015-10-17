using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{
    public class Pregunta
    {
        public int Descripcion { get; set; }

        public int IDPregunta { get; set; }

        public ICollection<Cuestionario> Cuestionarios { get; set; }

        public ICollection<Alternativas> Alternativas { get; set; }

    
        public void Actualizar()
        {
            throw new System.NotImplementedException();
        }

        public void Agregar()
        {
            throw new System.NotImplementedException();
        }

        public void Eliminar()
        {
            throw new System.NotImplementedException();
        }
    }
}
