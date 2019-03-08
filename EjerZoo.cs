using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciozoologico
{
    class Program
    {

        public string grup1, grup2, grup3, grup4;

        static void Main(string[] args)
        {



            Program zoo = new Program();
            Console.WriteLine(zoo.Gene1() + zoo.Gene2() + zoo.Gene3() + zoo.Gene4());
            Console.ReadKey();

        }

        string Gene1()
        {
            return "Aves: 10 ";

        }


        string Gene2()
        {
            return "Reptiles: 20 ";


        }

        string Gene3()
        {
            return "Mamiferos: 15";


        }

        string Gene4()
        {
            return "Acuaticos: 10 ";


        }


    }



}


    

