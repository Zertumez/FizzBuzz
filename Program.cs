using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numeros = new int[100];

            // for (int i = 0; i < numeros.Length; i++)
            // {
            //     numeros[i] = i + 1;
            // }

            //  for (int i = 0; i < numeros.Length; i++)
            // {
            //     if((numeros[i] % 3) == 0)
            //     {
            //         Console.WriteLine("Fizz");
            //     }
            //     else if((numeros[i] % 3 == 0) && (numeros[i] % 5 == 0))
            //     {
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else if((numeros[i] % 5) == 0)
            //     {
            //         Console.WriteLine("Buzz");
            //     }
            //     else
            //     {
            //         Console.WriteLine(numeros[i]);
            //     }
            // }

           string[] fizzbuzz = new[]
           {
              "FizzBuzz", "{0}", "{0}", "Fizz", "{0}", "Buzz", "Fizz",
               "{0}", "{0}", "Fizz", "Buzz", "{0}", "Fizz", "{0}", "{0}"
           };
          for (int i = 1; i <= 100; i++)
           {
               Console.WriteLine(string.Format(fizzbuzz[i % 15], i));
           }
        }
    }
}
