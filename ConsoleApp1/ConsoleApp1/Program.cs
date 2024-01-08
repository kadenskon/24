using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter da numba");
            int num = 0; 
            int.TryParse(Console.ReadLine(),out num);
            Console.WriteLine(num*num);
            Console.ReadLine();
        }
    }
}
