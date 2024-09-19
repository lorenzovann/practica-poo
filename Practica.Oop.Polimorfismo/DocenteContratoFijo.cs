using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Oop.Polimorfismo
{
    public class DocenteContratoFijo : Empleado
    {
        public decimal SalarioFijo { get; set; }

        public DocenteContratoFijo(string nombre, decimal salarioFijo, bool alcanzóMeta)
            : base(nombre, alcanzóMeta)
        {
            SalarioFijo = salarioFijo;
        }

        public override decimal CalcularSalario()
        {
            if (AlcanzóMeta)
            {
                return SalarioFijo;
            }
            else
            {
                return SalarioFijo / 2;
            }
        }
    }
}
