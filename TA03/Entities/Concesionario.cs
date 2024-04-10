using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA03.Entities
{
    class Concesionario
    {
        public Concesionario() { }

        public String Codigo { get; set; }
        public String Cliente { get; set; }
        public String Direccion { get; set; }
        public String Tipo { get; set; }
        public String Marca { get; set; }
        public double Precio { get; set; }

      }
}
