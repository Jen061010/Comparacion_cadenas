using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacion_cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "10";
            var b = "2";
            /*string res;
            var bol=string.Compare(a , b);
            if (bol < 0) {
                res = "La cadena mayor es " + b;
            }
            else if (bol == 0)
            {
                a = b;
                res = "Cadenas iguales!";
            }
            else {
                res ="La cadena mayor es "+ a;
            }
             * Console.WriteLine(res);
             */
            if (string.Compare(a, b) > string.Compare(b, a))
            {
                Console.WriteLine("La cadena mayor es a: " + a);

            }
            else if (string.Compare(a, b) < string.Compare(b, a))
            {
                Console.WriteLine("La cadena mayor es b: " + b);
            }
            else {
                Console.WriteLine("Las cadenas son iguales: "+a);
            }
            Console.ReadLine();
            
        }
    }
}
