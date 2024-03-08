using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_1005_Average_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("MEDIA = " + ((A*3.5 + B*7.5)/(3.5+7.5)).ToString("0.00000"));
            Console.ReadKey();
        }
    }
}
