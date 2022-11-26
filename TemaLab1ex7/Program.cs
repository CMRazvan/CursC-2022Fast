using System;

namespace TemaLab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ex7
            //Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
            //impar
            // In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
            // Google: even and odd number

            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 7");
            Console.WriteLine("Scrieti un program care va verifica daca un numar citit de la tastatura este par sau");
            Console.WriteLine("impar.");
            Console.WriteLine(" In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.");
            Console.WriteLine(" Google: even and odd number.");

            Console.WriteLine("Tasteaza numar si eu iti zic daca e par sau impar:");

            int numar;

            numar = int.Parse(Console.ReadLine());

            if(numar % 2 == 0)
            {
                Console.WriteLine("Numarul este par.");
            }
            else
            {
                Console.WriteLine("Numarul este impar.");
            }

        }
    }
}
