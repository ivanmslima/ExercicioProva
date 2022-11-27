using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite um número:  ");

            int nun, maior = 0;

            for (int i= 0; i < 10; i++)
            {
                Console.WriteLine("Informe um número: ");
                    nun = int.Parse(Console.ReadLine());

                if(nun > maior)
                {
                    maior = nun;
                }
            }
            Console.WriteLine($"O maior número é {maior}");


            


        }
    }
}