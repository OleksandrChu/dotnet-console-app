using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = BuildMessage("world");
            Console.WriteLine(message);
        }

        static String BuildMessage(String name) => String.Format("Hello {0}!", name);
    }
}
