using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
          //Console.WriteLine("Hello World!");
            //this is a commentary
            //console.WriteLine("Hello Clen!");
            /* 1. The program ask the users name
             * 2. The user enters their name
             * 3. The program greets the user by their name*/
            Console.WriteLine("What`s you name?");
            string Name;
            //read the input from the user
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
        }
    }
}
