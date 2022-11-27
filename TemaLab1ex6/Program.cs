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

            //Varianta 1

            if (x > y & x > z & y > z)
            {   // x=3 y=2 z=1 => 3 2 1 
                Console.WriteLine("Ordinea numerelor este: " + x + ", " + y + ", " + z);

            }
            if (x > y & x > z & z > y)
            {   // x=3 y=1 z=2 => 3 2 1 
                Console.WriteLine("Ordinea numerelor este: " + x + ", " + z + ", " + y);

            }

            if (y > x & y > z & x > z)
            {   // x=2 y=3 z=1 => 3 2 1 
                Console.WriteLine("Ordinea numerelor este: " + y + ", " + x + ", " + z);

            }
            if (y > x & y > z & z > x)
            {   // x=1 y=3 z=1 => 3 2 1 
                Console.WriteLine("Ordinea numerelor este: " + y + ", " + z + ", " + x);

            }

            if (z > y & z > x & y > x)
            {   // x=1 y=2 z=3 => 3 2 1 
                Console.WriteLine("Ordinea numerelor este: " + z + ", " + y + ", " + x);

            }
            if (z > y & z > x & x > y)
            {   // x=2 y=1 z=3 => 3 2 1 
                Console.WriteLine("Ordinea numerelor este: " + z + ", " + x + ", " + y);

            }

            /* varianta 2 de calcul
            if (x > y)
            {
                if (y > z)
                {// x y z 
                    Console.WriteLine("Ordinea numerelor este: " + x + ", " + y + ", " + z);
                }
                else
                {// x z y
                    Console.WriteLine("Ordinea numerelor este: " + x + ", " + z + ", " + y);
                }
            }
            else if(y > z) 
            {
                if (x > z)
                {// y x z
                    Console.WriteLine("Ordinea numerelor este: " + y + ", " + x + ", " + z);
                }
                else
                {// y z x
                    Console.WriteLine("Ordinea numerelor este: " + y + ", " + z + ", " + x);
                }
            }
            else
            {
                if (x > y)
                {// z x y
                    Console.WriteLine("Ordinea numerelor este: " + z + ", " + y + ", " + x);
                }
                else
                {// z y x
                    Console.WriteLine("Ordinea numerelor este: " + z + ", " + x + ", " + y);
                }
            }
            */
        }
    }
}
