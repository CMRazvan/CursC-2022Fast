using System;

namespace TemaLab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex6
            //Se citesc trei numere de la tastatura, x,y,z.Scrieti un program care va afisa cele trei valori in ordine
            //descrescatoare.
            //• Exemplu: citim 3,9,0 Afisam: 9 3 0

            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 6");
            Console.WriteLine("Se citesc trei numere de la tastatura, x,y,z.Scrieti un program care va afisa cele trei valori in ordine");
            Console.WriteLine("descrescatoare.");
            Console.WriteLine("• Exemplu: citim 3,9,0 Afisam: 9 3 0");


            Console.WriteLine("Tasteaza primul numar:");

            int x;
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Tasteaza al doilea numar:");

            int y;
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Tasteaza al Treilea numar:");

            int z;
            z = int.Parse(Console.ReadLine());

            if (x > y)
            {
                if (y > z)
                {
                    Console.WriteLine("Ordinea numerelor este: " + z + ", " + y + ", " + x);
                } 
                else
                {
                    Console.WriteLine("Ordinea numerelor este: " + z + ", " + x + ", " + y);
                }
                
            }
            else 
            {
                if(x > z)
                {
                    Console.WriteLine("Ordinea numerelor este: " + z + ", " + x + ", " + y);
                }
                else
                {
                    Console.WriteLine("Ordinea numerelor este: " + z + ", " + y + ", " + x);
                }
            }

        }
    }
}
