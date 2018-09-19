using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JobInterview2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1-й способ через сложение столбиком");
            BigNumber a = new BigNumber("175872");
            BigNumber b = new BigNumber("1234567890123456789012345678901234567890");                        

            Console.WriteLine(a.ToString());
            Console.WriteLine("+");
            Console.WriteLine(b.ToString());
            Console.WriteLine("=");
            var r = a + b;            
            Console.WriteLine(r);

            Console.WriteLine("---");

            Console.WriteLine("2-й способ через System.Numerics");
            var a2 = new BigNumber2("175872");
            var b2 = new BigNumber2("1234567890123456789012345678901234567890");
            Console.WriteLine(a.ToString());
            Console.WriteLine("+");
            Console.WriteLine(b.ToString());
            var r2 = a2 + b2;
            Console.WriteLine("=");
            Console.WriteLine(r2);            
            Console.ReadLine();
        }

    }
       
}
