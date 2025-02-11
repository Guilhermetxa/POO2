using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 18;


            Console.WriteLine(idade);

            if(idade >= 18)
            {
                Console.WriteLine("Parabéns");
            }
            else
            {
                //Console.WriteLine("Vc tem somente" + idade + "anos");
                Console.WriteLine($"Vc tem somente {idade} anos");
            }

            //Carro carro02 = new();

            Carro carro = new Carro();
            carro.Modelo = "Fusca";
            carro.Ano = 1988;
            carro.Velocidade = 40;

        }
    }
}
