using System;

namespace UFSCAR.MLP.CALC
{
    public class Operacao
    {
        public Operacao(bool valid = false)
        {
            if (valid)
            {
                // Ask the user to type the first number..
                Console.WriteLine("Type a number, and then press Enter");
                int num1 = Convert.ToInt32(Console.ReadLine());

                // Ask the user to type the second number.
                Console.WriteLine("Type another number, and then press Enter");
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Ask the user to choose an option.
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                Escolha(Console.ReadLine(), num1, num2);
            }
        }

        public double Somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Subtrair(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public double Dividir(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return numero1 / numero2;
        }

        public bool Escolha(string selecao, int num1, int num2)
        {
            bool retorno = false;

            // Use a switch statement to do the math.
            switch (selecao)
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + Somar(num1, num2));
                    retorno = true;
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + Subtrair(num1, num2));
                    retorno = true;
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + Multiplicar(num1, num2));
                    retorno = true;
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + Dividir(num1, num2));
                    retorno = true;
                    break;
                default:
                    Console.WriteLine($"Choose a valid operation and try again.");
                    break;
            }

            return retorno;
        }

        public bool Encerrar()
        {
            bool retorno = false;
            Console.WriteLine("Would you like to close the program ? (Y/N)");
            string encerrar = Console.ReadLine();

            switch (encerrar.ToUpper())
            {
                case "Y":
                    Console.WriteLine($"Thanks!");
                    retorno = true;
                    break;
                case "N":
                    Console.WriteLine($"Try again, let's go!");
                    retorno = false;
                    break;
                default:
                    Console.WriteLine($"Try again, let's go!");
                    retorno = false;
                    break;
            }
            return retorno;
        }
    }
}