using System;

namespace CalculatorProject.CalculatorActions
{
    class Calculator
    {
        public static void Soma()
        {
            System.Console.WriteLine("Digite o primeiro valor: ");
            //float v1 = (float)Convert.ToDouble(Console.ReadLine());
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("\nDigite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            System.Console.WriteLine($"\nO valor da soma de {v1} + {v2} é igual a {resultado}");
        }

        public static void Subtracao()
        {
            System.Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("\nDigite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 - v2;
            System.Console.WriteLine($"\nO valor da subtracao de {v1} - {v2} é igual a {resultado}");
        }

        public static void Multiplicacao()
        {
            System.Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("\nDigite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            System.Console.WriteLine($"\nO valor da multiplicacao de {v1} * {v2} é igual a {resultado}");
        }

        public static void Divisao()
        {
            System.Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("\nDigite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            System.Console.WriteLine($"\nO valor da divisão de {v1} / {v2} é igual a {resultado}");
        }


        public static void Potenciacao()
        {
            System.Console.WriteLine("Digite o valor a ser elevado: ");
            double v1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o expoente: ");
            double exp = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(v1, exp);
            System.Console.WriteLine($"\nO valor da potenciacao de {v1} ^ {exp} é igual a {resultado}");
        }

    }
}