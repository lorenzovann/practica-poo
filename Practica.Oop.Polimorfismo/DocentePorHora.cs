using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Oop.Polimorfismo
{
    public class DocentePorHora : Empleado
    {
        public int HorasTrabajadas { get; set; }
        private const decimal TARIFA_POR_HORA = 800;

        public DocentePorHora(string nombre, int horasTrabajadas)
            : base(nombre, true)  // No afecta si alcanzó meta o no
        {
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularSalario()
        {
            return HorasTrabajadas * TARIFA_POR_HORA;
        }
    }
}
