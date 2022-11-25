using System;

namespace TemaLab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
            //paralelipiped dreptunghic, va afisa volumul lui
            Console.WriteLine("Bine ai venit la Curs C# , acum rezolvam temele:");
            Console.WriteLine("Exercitiul 1");
            Console.WriteLine("Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui");
            Console.WriteLine("paralelipiped dreptunghic, va afisa volumul lui");

            int a;
            int b;
            int c;

            Console.WriteLine("Spune valoare primei laturi");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Spune valoare a doua latura");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Spune valoare a treialatura");
            
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Cele trei valori sunt: a = " + a + ", b = " + b + ", c = " + c );

            int rezultatVolum = a * b * c;

            Console.WriteLine("Volumul paralelipipedului este: " + rezultatVolum + "cm3");



        }
    }
}
