using System;

namespace TemaLab1ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex9
            //Scrieti un program care interschimba valoarea a doua variabile intregi.

            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 9");
            Console.WriteLine("Scrieti un program care interschimba valoarea a doua variabile intregi.");


            int a;
            int b; 
            int schimb;

            Console.Write("Introduceti primul numar a = ");
            a = int.Parse(Console.ReadLine());
            
            Console.Write("Introduceti al doilea numar b = ");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("a=" + a + " , b=" + b);
            
            schimb = a;
            a = b;
            b = schimb;
            
            Console.Write("Numerele inlocuite sunt a=" + a + " b=" + b);

        }
    }
}
