using System;
using System.Globalization;


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da variavel e solicitando o numero de pessoas
            Console.WriteLine("Digite a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            Console.WriteLine("Digite a altura das pessoas: ");

            //for para registrar as alturas na memoria
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //Declaração da variavel soma
            double soma = 0.0;

            //for para somar todas as alturas
            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }
            //Calculo da media
            double media = soma / n;
            
            //Resultados
            Console.WriteLine("soma: " + soma);
            Console.WriteLine("Media: " + media);
            Console.ReadKey();
        }
    }
}
