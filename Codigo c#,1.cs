using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Se formaran distintas combinaciones numericas con los siguientes numeros:");
            Console.WriteLine("a siendo 2, b siendo 4 y c siendo 1");

            //Primeramente asignare los valores a cada variable:

            int a = 2;
            int b = 4;
            int c = 1;
            //Utilizo int ya que no necesitamos alguno con valores decimales, solo encontramos y trabajaremos en esto en numeros enteros

            Console.WriteLine("comenzaremos con la primera combinacion aacb, la cual quedaria de la siguiente forma:");

            Console.Write(a);
            Console.Write(a);
            Console.Write(c);
            Console.Write(b);

            Console.WriteLine("");
            //le coloco esto para poder tener espaciado entre lineas


            Console.WriteLine("Luego pasaremos a la siguiente combinacion bca, la cual quedaria de la siguiente forma:");

            Console.Write(b);
            Console.Write(c);
            Console.Write(a);

            Console.WriteLine("");

            Console.WriteLine("Por ultimo tendremos la siguiente combinacion bcbc, la cual quedaria de la siguiente forma:");

            Console.Write(b);
            Console.Write(c);
            Console.Write(b);
            Console.Write(c);

            Console.WriteLine("");


            Console.ReadLine();

        }
    }
}
