using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA03.Repositories
{
    class ConcesionarioRep
    {
        private static List<Entities.Concesionario> concesionarios = new List<Entities.Concesionario>();

        public bool Existe(String Codigo)
        {
            return concesionarios.Exists(elec => elec.Codigo.Equals(Codigo));
        }

        public void Registrar(Entities.Concesionario elec)
        {
            concesionarios.Add(elec);
        }

        public static List<Entities.Concesionario> ListarTodo()
        {
            return concesionarios;
        }


        public void Eliminar(String Codigo)
        {
            concesionarios.RemoveAll(elec => elec.Codigo.Equals(Codigo));
        }

        public void EliminarTodo()
        {
            concesionarios.Clear();
        }


        public List<Entities.Concesionario> Buscar(String Cliente)
        {
            return concesionarios.Where(elec => elec.Cliente.Contains(Cliente)).ToList();
        }

        public List<Entities.Concesionario> Ordenar()
        {
            return concesionarios.OrderBy(elec => elec.Precio).ToList();
        }
    }
}
