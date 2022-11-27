using System;

namespace TemaLab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex5
            //Se citesc doua numere de la tastatura, x,y.Scrieti un program care va afisa cele doua valori in ordine crescatoare.
            //• Exemplu: citim ,9,0 Afisam: 0 9

            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 5");
            Console.WriteLine("Se citesc doua numere de la tastatura, x,y.Scrieti un program care va afisa cele doua valori in ordine crescatoare.");
            Console.WriteLine("• Exemplu: citim ,9,0 Afisam: 0 9");


            Console.WriteLine("Tasteaza primul numar:");

                int x;
                x = int.Parse(Console.ReadLine());

            //Pentru a simplifica codul se poate si asa  int x = int.Parse(Console.ReadLine()); - !!!!!

            Console.WriteLine("Tasteaza al doilea numar:");

                int y;
                y = int.Parse(Console.ReadLine());

            //Pentru a simplifica codul se poate si asa  int y = int.Parse(Console.ReadLine()); - !!!!!

            if (x > y)
            {
                Console.WriteLine("Ordinea numerelor este: " + y + ", " + x);
            }
            else
            {
                Console.WriteLine("Ordinea numerelor este: " + x + ", " + y);

            }

        }
    }
}
