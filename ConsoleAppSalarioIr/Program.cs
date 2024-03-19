using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSalarioIr
{
    internal class Program
    {
        private static int salli;

        static void Main(string[] args)
        {
             double salli = 0;
            
            Console.WriteLine("Qual a forma de contratação? (A)ssalariado, (C)omissionado, (H)orista ");
            string cont = Console.ReadLine();

            switch (cont)
            {
                case "A":
                    Console.WriteLine("Qual o valor do salário bruto? ");
                    double salb = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor de desconto? ");
                    double desc = double.Parse(Console.ReadLine());
                    salli = salb - desc;
                    Console.WriteLine("O valor do salário líquido é de " +  salli);
                    break;

                case "C":
                    Console.WriteLine("Quantas peças vendeu? ");
                    int pecas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a comissão por peça? ");
                    double comi = double.Parse(Console.ReadLine());
                    salli = pecas * comi;
                    Console.WriteLine("O valor a ganhar vai ser de " + salli);
                    break;

                case "H":
                    Console.WriteLine("Quantas horas trabalhou? ");
                    double horas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor por hora? ");
                    double val = double.Parse(Console.ReadLine());
                    salli = horas * val;
                    Console.WriteLine("O valor a ganhar vai ser de " + salli);
                    break;

                default: 
                    Console.WriteLine("Opção Inválida");
                    break;
            }

            if (salli < 2000)
            {
                double ir = salli * 0.075;
                Console.WriteLine("O IR vai ser de " + ir);
            }
            else if (salli < 4000)
            {
                double ir = salli * 0.12;
                Console.WriteLine("O IR vai ser de " + ir);
            }
            else 
            {
                double ir = salli * 0.15;
                Console.WriteLine("O IR vai ser de " + ir);
            }


            Console.ReadKey();
        }
    }
}
