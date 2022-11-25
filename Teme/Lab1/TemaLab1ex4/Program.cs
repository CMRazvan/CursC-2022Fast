using System;

namespace TemaLab1ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex4
            //  Scrieti un program care va afisa semnul unui numar citit de la tastatura
            //• Daca numarul este pozitiv, va afisa “+”
            //• Daca numarul este negativ, va afisa “-”
            //• Daca numarul este 0, va afisa “0”

            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 4");
            Console.WriteLine("Scrieti un program care va afisa semnul unui numar citit de la tastatura");
            Console.WriteLine("• Daca numarul este pozitiv, va afisa “+”");
            Console.WriteLine("• Daca numarul este negativ, va afisa “-”");
            Console.WriteLine("• Daca numarul este 0, va afisa “0”");
            
            Console.WriteLine("Tasteaza numarul:");

            int numarul;

            numarul = int.Parse(Console.ReadLine());

            if(numarul > 0)
            {
                Console.WriteLine("Numarul este Pozitiv: + ");
            }
                else if(numarul < 0)
            {
                Console.WriteLine("Numarul este Negativ: - ");
            }
                else
            {
                Console.WriteLine("Numarul este... , nu este numar este: 0 ");
            }





        }
    }
}
