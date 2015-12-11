using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCuestionario.Repositorios
{
    public interface IRepositorio<T> : IRepositorioLectura<T>

    {
        bool Adicionar(T ao_entidad);
        bool Actualizar(T aao_entidad);
        bool GuardarCambios();
    }
}
