using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for(int i = 0; i< 1000; i++)
            {               
                if (i % 3 == 0 || i % 5 == 0)
                {
                    soma = soma + i;
                }         
            }
            Console.Write("A soma dos multiplos de 3 e 5 até 100 é: {0}", soma);
            Console.ReadKey();
        }
    }
}
