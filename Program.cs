using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5___Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, nome5, nome6, variavel;

            Console.Write("Digite o Nome #1: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o Nome #2: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o Nome #3: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite o Nome #4: ");
            nome4 = Console.ReadLine();

            Console.Write("Digite o Nome #5: ");
            nome5 = Console.ReadLine();

            Console.Write("Digite o Nome #6: ");
            nome6 = Console.ReadLine();


            variavel = nome1;
            nome1 = nome6;
            nome6 = variavel;
            variavel = null;

            variavel = nome2;
            nome2 = nome5;
            nome5 = variavel;
            variavel = null;

            variavel = nome3;
            nome3 = nome4;
            nome4 = variavel;
            variavel = null;


            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            Console.WriteLine(nome5);
            Console.WriteLine(nome6);

            Console.ReadKey();


        }
    }
}
