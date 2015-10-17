using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPCuestionario
{
    public class Alternativas
    {
        public int Descripcion { get; set; }

        public int IDAlternativa { get; set; }


        public int RAlternativa { get; set; }


        public ICollection<Pregunta> Preguntas { get; set; }

    
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
