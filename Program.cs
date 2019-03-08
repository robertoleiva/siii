using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal1
{
    class Program
    {
        static void Main(string[] args)
        {



           
            

            Semaforo sem = new Semaforo("Avanzar","Precaucion", "DETENERSE");
            Nombres Nom = new Nombres();
           Console.WriteLine("Luz Verde es: " + sem.V);
            Console.WriteLine("Luz Naranja es: " + sem.N);
            Console.WriteLine("Luz Roja: " + sem.R);
            Console.WriteLine();


            Nom.imprimir();
            Nom.imprimir("M");
            Nom.imprimir("L, F");
            Console.WriteLine();

            string n, ape, dir;

            Console.WriteLine("Ingrese su Nombre :");
            n = Console.ReadLine();

            Console.WriteLine("Ingrese su Apellido :");
            ape = Console.ReadLine();

            Console.WriteLine("Ingrese su Direccion :");
            dir = Console.ReadLine();

            Console.ReadKey();


        }
    }
}
