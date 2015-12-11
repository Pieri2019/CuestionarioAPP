using APPCuestionario.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace APPCuestionario.Datos.EF.Repositorios
{
    public class RepositorioLectura<T> : IRepositorioLectura<T> where T : class
    {
        public IDbSet<T> Entidad { get; set; }

        public RepositorioLectura(IEContexto ao_contexto) {

            this.Entidad = ao_contexto.Set<T>();

        }

        public RepositorioLectura()
            : this(new IEContexto("IEDb"))
        {

        }

        public IQueryable<T> Listas()
        {
            return Entidad;
        }

        public T ObtenerPorCodigo(params object[] ao_llaves)
        {
            return Entidad.Find(ao_llaves);
        }

        public IList<T> ObtenerPorExpresion(Expression<Func<T, bool>> ao_llaves = null, string as_incluir = null, byte aby_limite = 0)
        {
            return Entidad.Where(ao_llaves).ToList();
        }
    }
}
