using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            CLSempleados empleado;
            empleado = new CLSempleados();

            empleado.Edad = 25;
            empleado.Nombre = "Alejandro";
            empleado.SueldoDiario = 25.6m;
            decimal total;
            total = empleado.CalcularSalario(30);

            Console.WriteLine("El salario mensual del empleado " + empleado.Nombre);
            Console.WriteLine("Es: " + total.ToString("C"));
            Console.ReadKey();
;        }
    }
}
