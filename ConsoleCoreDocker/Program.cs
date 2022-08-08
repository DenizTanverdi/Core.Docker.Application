using System;

namespace ConsoleCoreDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 1000)
            {
                Console.WriteLine("Hello word");
                i++;
                System.Threading.Thread.Sleep(1000);
                //elimde bir puliah olduğu için .net core runtime lazım
            }
        }
    }
}
