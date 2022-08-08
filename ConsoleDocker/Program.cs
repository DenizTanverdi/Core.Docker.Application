using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDocker
{
     class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<1000)
            {
                Console.WriteLine("Hello word");
                i++;
                System.Threading.Thread.Sleep(1000);
            }
           
        }
    }
}
