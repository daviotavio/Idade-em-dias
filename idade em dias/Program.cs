using System;

namespace idade_em_dias
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            // int dias = 365;

            Console.Write("informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Sua idade em dias é: " + idade * 365);
        }
    }
}
