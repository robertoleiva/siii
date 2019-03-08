using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal1
{
    class Nombres
    {

        public string C, M, L, F, res;

        public void imprimir()
        {


            res = C;
            Console.WriteLine("El nombre es: Carlos" );

        }


        public void imprimir(string M)
        {


            res = M;
            Console.WriteLine("El nombre es: Maria" );

        }

        public void imprimir(string L, string F)
        {


            res = L;
            Console.WriteLine("El nombre es: Luis y Fernando" );

        }



    }
}
