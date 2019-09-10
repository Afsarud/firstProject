using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloAfsar
{
    class Program
    {
        static void Main(string[] args)
        {
            String fstName = "";
            String sndName = "";
            Console.WriteLine("Type your first name:");
            fstName = Console.ReadLine();
            Console.WriteLine("Hi: "+fstName);

            Console.WriteLine("Type your Second name:");
            sndName = Console.ReadLine();
            Console.WriteLine("Hi: "+ sndName);
            Console.WriteLine("Your Full Name: "+fstName  +sndName);
            Console.ReadKey();
        }
    }
}
