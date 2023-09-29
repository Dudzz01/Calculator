using System;
using CalculatorProject.CalculatorActions;

namespace CalculatorProject
{
    class Program
    {


        public static void Main(string[] args)
        {

            MenuCalculator();
        }


        public static void MenuCalculator()
        {
            Console.Clear();
            int menuOptions = 1;


            while (menuOptions != 0)
            {
                System.Console.WriteLine
                (
                    "\nSelecione quais opcoes você deseja utilizar na Calculadora Virtual\n 0: Sair do programa.\n 1: Soma de 2 números.\n 2: Subtracao de 2 números.\n 3: Multiplicacao de 2 números.\n 4: Divisao de 2 números. \n 5: Potenciacao de 2 números."
                );
                menuOptions = int.Parse(Console.ReadLine());

                switch (menuOptions)
                {
                    case 0:
                        System.Console.WriteLine("\nSaindo da Calculadora...");
                        break;

                    case 1:
                        System.Console.WriteLine("\nOpcao de soma selecionada.\n");
                        Calculator.Soma();
                        break;
                    case 2:
                        System.Console.WriteLine("\nOpcao de subtracao selecionada.\n");
                        Calculator.Subtracao();
                        break;
                    case 3:
                        System.Console.WriteLine("\nOpcao de multiplicacao selecionada.\n");
                        Calculator.Multiplicacao();
                        break;

                    case 4:
                        System.Console.WriteLine("\nOpcao de divisao selecionada.\n");
                        Calculator.Divisao();
                        break;

                    case 5:
                        System.Console.WriteLine("\nOpcao de potenciacao selecionada.\n");
                        Calculator.Potenciacao();
                        break;

                    default:
                        System.Console.WriteLine("\nErro no sistema, tente novamente.");
                        break;

                }
            }
        }

    }
}
