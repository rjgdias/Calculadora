using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            double num1, num2, calc;
            do
            {
                Console.Clear();
                Console.WriteLine("Calculadora.");
                Console.WriteLine("========-=-=-=-================");
                Console.WriteLine(" 1 - Soma" +
                    "\r\n 2 - Subtração" +
                    "\r\n 3 - Multiplicação" +
                    "\r\n 4 - Divisão" +
                    "\r\n 5 - Sair.");
                Console.WriteLine("Digite aqui :");
                escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro numero da soma: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número da soma: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    calc = num1 + num2;
                    Console.WriteLine($"A soma deu : {calc}");
                    Console.ReadLine();
                }

                if (escolha == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro numero da subtração: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número da subtração: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    calc = num1 - num2;
                    Console.WriteLine($"A subtração deu : {calc}");
                    Console.ReadLine();
                }
                if (escolha == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro numero da multiplicação: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número da multiplicação: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    calc = num1 * num2;
                    Console.WriteLine($"A multriplicação deu : {calc}");
                    Console.ReadLine();
                }
                if (escolha == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o dividendo: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o divisor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    calc = num1 / num2;
                    Console.WriteLine($"A divisão deu : {calc}");
                    Console.ReadLine();
                }
                if (escolha == 5) { Console.Clear(); Console.WriteLine("Você saiu."); Console.ReadLine(); }
            } while (escolha != 5);
        }
    }
}
