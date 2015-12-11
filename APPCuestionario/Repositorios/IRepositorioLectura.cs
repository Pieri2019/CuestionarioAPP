using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APPCuestionario.Repositorios
{
    public interface IRepositorioLectura<T>
    {
        T ObtenerPorCodigo(params object[] ao_llaves);
        IQueryable<T> Listas();
        IList<T> ObtenerPorExpresion(Expression<Func<T, bool>> ao_llaves = null, string as_incluir - null, byte aby_limite = 0);
    }
}
