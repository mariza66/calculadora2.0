using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 0.0;
            double valor2 = 0.0;
            int opcao = 0;
            
            Console.WriteLine("digite o primeiro valor");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o segundo valor");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4- Multiplicação");
            Console.WriteLine("5- Nada,só estou dando uma olhadinha" + "\n");

            if (opcao == 1)
            {
                Console.WriteLine("digite essa opção");
                opcao = Convert.ToInt16(Console.ReadLine());

                if (opcao == 2)
                    Console.WriteLine(valor1 - valor2);

                if (opcao == 3) ;
                Console.WriteLine(valor1 / valor2);

                if (opcao == 4)
                    Console.WriteLine(valor1 * valor2);

                if (opcao == 5) ;

                Console.WriteLine("EXIT");
                opcao = (int)Convert.ToDouble(Console.ReadLine);

                   


            }   
                

               

             


        }
    }
}
