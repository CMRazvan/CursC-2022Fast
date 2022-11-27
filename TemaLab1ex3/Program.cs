using System;

namespace TemaLab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex3
            //Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
            //tastaura

            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 3");
            Console.WriteLine("Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la");
            Console.WriteLine("tastatura");

            int numarul;

            numarul = int.Parse(Console.ReadLine());

            int lastdigit = numarul % 10;

            Console.WriteLine(lastdigit);

        }
    }
}
