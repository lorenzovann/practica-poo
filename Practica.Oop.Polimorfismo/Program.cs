using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Oop.Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplos de cálculo de salarios
            DocentePorHora docentePorHora = new DocentePorHora("Juan", 40);
            DocenteContratoFijo docenteFijo = new DocenteContratoFijo("Ana", 3000, true);
            EmpleadoAdministrativo admin = new EmpleadoAdministrativo("Luis", 2500, false);

            Console.WriteLine($"{docentePorHora.Nombre} - Salario: {docentePorHora.CalcularSalario()}");
            Console.WriteLine($"{docenteFijo.Nombre} - Salario: {docenteFijo.CalcularSalario()}");
            Console.WriteLine($"{admin.Nombre} - Salario: {admin.CalcularSalario()}");

            Console.ReadKey();
        }
    }
}

