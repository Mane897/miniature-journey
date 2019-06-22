using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CLSempleados
    {
        //Constructor
        public CLSempleados()
        {
             Nombre = "Alejandro";
             SueldoDiario = 25.6m;
             Edad = 25;
        }


            private decimal _Sueldodiario;
            private string _Nombre;
            private int _Edad;

        public decimal SueldoDiario { get => _Sueldodiario ; set => _Sueldodiario = value; }

        public int Edad { get => _Edad ; set => _Edad = value; }

        

        public string Nombre { get => _Nombre; set => _Nombre = value; }

        //metodo
        public decimal CalcularSalario(int numerodias)
        {
            return SueldoDiario * numerodias;
        }

    }
}
