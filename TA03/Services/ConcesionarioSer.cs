using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA03.Repositories;

namespace TA03.Services
{
    class ConcesionarioSer
    {
        private ConcesionarioRep concesionarioRep = new ConcesionarioRep();

        public bool Regitrar(Entities.Concesionario conce)
        {
            if (concesionarioRep.Existe(conce.Codigo))
            {
                return false;
            }
            else
            {
                concesionarioRep.Registrar(conce);
                return true;
            }
        }


        public List<Entities.Concesionario> ListarTodo()
        {
            return ConcesionarioRep.ListarTodo();
        }


        public void Eliminar(String Codigo)
        {
            concesionarioRep.Eliminar(Codigo);
        }

        public void EliminarTodo()
        {
            concesionarioRep.EliminarTodo();
        }

        public List<Entities.Concesionario> Buscar(String Cliente)
        {
            return concesionarioRep.Buscar(Cliente);
        }

        public List<Entities.Concesionario> Ordenar()
        {
            return concesionarioRep.Ordenar();
        }

    }
}
