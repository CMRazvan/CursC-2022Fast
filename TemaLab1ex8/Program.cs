using System;

namespace TemaLab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex8
            //Se citesc doua numere de la tastatura, x si y.Scrieti un program care va verifica
            //daca x este divizibil cu y.
            // In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
            //“indivizibil”.

            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 8");
            Console.WriteLine("Se citesc doua numere de la tastatura, x si y.Scrieti un program care va verifica");
            Console.WriteLine("daca x este divizibil cu y.");
            Console.WriteLine(" In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,");
            Console.WriteLine("“indivizibil”.");

            int x;
            int y;

            Console.WriteLine("Tasteaza primul numar (x):");
            
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Tasteaza al doilea numar (y):");

            y = int.Parse(Console.ReadLine());

            int rezultat = x / y;

            if(rezultat % 2 == 0)
            {
                Console.WriteLine("Divizibil");
            }
            else
            {
                Console.WriteLine("Indivizibil");
            }

        }
    }
}
