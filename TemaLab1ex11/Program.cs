using System;

namespace TemaLab1ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex11
            /*Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele
            “unu” daca numarul citit este 1
            “doi” daca numarul citit este 2
            “trei” daca numarul citit este 3
            “cinci” daca numarul citit este 5
            “opt” daca numarul citit este 8
            “neidentificat” pentru orice alt caz */

            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 11");
            Console.WriteLine("Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele");
            Console.WriteLine("“unu” daca numarul citit este 1");
            Console.WriteLine("“doi” daca numarul citit este 2");
            Console.WriteLine("“trei” daca numarul citit este 3");
            Console.WriteLine("“cinci” daca numarul citit este 5");
            Console.WriteLine("“opt” daca numarul citit este 8");
            Console.WriteLine("“neidentificat” pentru orice alt caz");

            Console.WriteLine("Tasteaza numar si eu iti tranform numarul in text:");

            int numar;

            numar = int.Parse(Console.ReadLine());

            switch (numar)
            {
                case 1:
                    Console.WriteLine("Numarul este: unu");
                    break;
                case 2:
                    Console.WriteLine("Numarul este: doi");
                    break;
                case 3:
                    Console.WriteLine("Numarul este: trei");
                    break;
                case 5:
                    Console.WriteLine("Numarul este: cinci");
                    break;
                case 8:
                    Console.WriteLine("Numarul este: opt");
                    break;
                default:
                    Console.WriteLine("Numarul este neindentificat");
                    break;
            }

        }
    }
}
