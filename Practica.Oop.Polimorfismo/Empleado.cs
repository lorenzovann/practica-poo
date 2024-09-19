using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Oop.Polimorfismo
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public bool AlcanzóMeta { get; set; }

        public Empleado(string nombre, bool alcanzóMeta)
        {
            Nombre = nombre;
            AlcanzóMeta = alcanzóMeta;
        }

        public virtual decimal CalcularSalario()
        {
            return 0;
        }
    }
}
