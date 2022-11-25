using System;

namespace TemaLab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex2
            //Scrieti un program care va calcula media aritmetica a trei numere citite de la
            //tastatura

            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 2");
            Console.WriteLine("Scrieti un program care va calcula media aritmetica a trei numere citite de la");
            Console.WriteLine("tastatura");

            int a;
            int b;
            int c;

            Console.WriteLine("Scrie primul numar:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Scrie al doilea numar:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Scrie al treilea numar:");

            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Cele trei valori sunt: a = " + a + ", b = " + b + ", c = " + c);

            int mediaAritmetica = ( a + b + c ) / 3;

            Console.WriteLine("Media aritmetica a celor trei numere este: " + mediaAritmetica);
        }
    }
}
