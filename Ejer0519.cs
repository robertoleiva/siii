using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AREAS;

namespace AREAS
{
    class Program
    {
        static void Main(string[] args)
        {


           
            Console.WriteLine("Ingrese Base del rectangulo: ");
            int Ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Altura del rectangulo: ");
            int Altura = int.Parse(Console.ReadLine());

            Rectangulo obj = new Rectangulo();
            obj.Setanch(Ancho);
            obj.Setalt(Altura);
            obj.imprimir();

            Console.WriteLine("Ingrese lado del Cuadrado: ");
            double la = double.Parse(Console.ReadLine());
            Perimetro obj2 = new Perimetro();
            obj2.SetLado(la);
            obj2.CalculoPerimetro(obj2.Lado);
            Console.WriteLine("Su perimetro  es: " + obj2.imprimirP());

            Console.ReadKey();





        }
    }
}
