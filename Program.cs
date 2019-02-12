using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            decimal x = 0.0m;
            float m = 0.0f;
            double d = 0.0D;
            string cadena = "Hola mundo!";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue; // Puede almacenar fecha u hora
            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine("El valor de m es: {0:F2}", m);
            Console.WriteLine("El valor de d es: {0:F2}", d);
            Console.WriteLine("El valor de la cadena es: " + cadena);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortTimeString());
            Console.ReadKey();

        }
    }
}
