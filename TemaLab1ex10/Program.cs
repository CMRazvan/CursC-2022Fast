using System;

namespace TemaLab1ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex10

            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 10");
            Console.WriteLine("Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura.");
            Console.WriteLine(" Numarul are exact 2 cifre");

            int numarul;
            int memorie;
            int suma = 0;

            numarul = int.Parse(Console.ReadLine());
            memorie = numarul;

            while (memorie != 0)
            {
                suma += memorie % 10;
                memorie /= 10;
                
            }

            Console.WriteLine(suma);

        }
    }
}
