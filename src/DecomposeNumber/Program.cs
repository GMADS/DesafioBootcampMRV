using DecomposeNumber.Services.Services.v1;
using System;

namespace DecomposeNumber
{
    class Program
    {
        static DecomposeNumberService _decomposeNumberService = new DecomposeNumberService();

        static void Main(string[] args)
        {
            ExecuteAppAsync();

            Console.ReadLine();
        }

        static async void ExecuteAppAsync()
        {
            var number = 0;

            Console.WriteLine("Bem vindo ao decompose number");

            while (number == 0)
            {
                Console.WriteLine("Digite um número");

                var getNumber = Console.ReadLine();
                Console.WriteLine();

                var checkNumber = Int32.TryParse(getNumber, out number);

                if (!checkNumber)
                    Console.WriteLine("Número inválido, tente novamente");

                if (number <= 0 && checkNumber)
                    Console.WriteLine("Digite um número maior que 0");
            }

            var response = await _decomposeNumberService.GetDivisorNumbersAsync(number);

            Console.WriteLine($"Número de Entrada: {number}");

            Console.WriteLine();
            Console.WriteLine("Números divisores:");
            response.DividerNumbers?.ForEach(delegate (int number)
            {
                Console.Write($"{number} - ");
            });

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Divisores Primos:");
            response.DividerNumbersPrime?.ForEach(delegate (int number)
            {
                Console.Write($"{number} - ");
            });        
        }
    }
}
