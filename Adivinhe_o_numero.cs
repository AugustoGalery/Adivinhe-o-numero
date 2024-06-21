using System;

namespace AdivinheONumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativas = 0;
            bool acertou = false;

            Console.WriteLine("Adivinhe o Número (entre 1 e 100)");

            while (!acertou)
            {
                Console.Write("Digite seu palpite: ");
                int palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo!");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Muito alto!");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
                    acertou = true;
                }
            }
        }
    }
}
