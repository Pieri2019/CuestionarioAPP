using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCuestionario.Datos.EF.Contextos
{
    class InicializadorDB : CreateDatabaseIfNotExists<IEContexto>
    {
        protected override void Seed(IEContexto context)
        {
            base.Seed(context);
            var Usuario01 = Usuario.Agregar( "Pierina", "Alvarez Kuong", "pierina2015","C");
            var Usuario02 = Usuario.Agregar( "Mauricio", "Puma Chipana", "mauricio2015", "C");
            var Usuario03 = Usuario.Agregar("Giordy", "Mamani Aguilar", "giordy2015", "R");
            var Usuario04 = Usuario.Agregar( "Renzo", "Rojas Lozano", "renzo2015", "C");
            var Usuario05 = Usuario.Agregar("Arturo", "Chavez Mirabal", "arturo015", "R");

            context.Usuarios.Add(Usuario01);
            context.Usuarios.Add(Usuario02);
            context.Usuarios.Add(Usuario03);
            context.Usuarios.Add(Usuario04);
            context.Usuarios.Add(Usuario05);
            context.SaveChanges();
        }

    }
}
