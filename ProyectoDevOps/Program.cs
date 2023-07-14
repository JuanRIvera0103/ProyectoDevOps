using ProyectoDevOps;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cuenta = new CuentaBanco(200);

            //Hackeo para ser millonario.
            while (cuenta.balance > 0)
            {
                cuenta.Agregar(200);
            }
        }
    }
}