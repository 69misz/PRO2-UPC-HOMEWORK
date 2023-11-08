using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion4
{
    public class clsEmpleados
    {
        Nombre ="";
        SueldoDiario = 0.0m;
        Edad = 0;
    }
    {
        public string Nombre;

        public decimal SueldoMensual;

        public int Edad;

        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }
    }
}