using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?

namespace PEProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program maior = new Program(); 
            maior.maiorPrimo(); 

        }

        private void maiorPrimo()
        {
            Int64 num = 600851475143;
            //List<Int64> primos = new List<Int64>();

            for (Int64 i = 2; i < num; i++)
            { 
                if (ePrimo(i)) //Verifica se o numero é primo através do método criado ePrimo
                { 
                    while (num % i == 0)
                    {
                        num = num / i;
                        //if(!primos.Contains(i))
                        //primos.Add(i);
                    }
                }
            
            }
            Console.WriteLine("O maior numero primo é {0}", num);
            Console.ReadKey();
            
        }

        private bool ePrimo(Int64 num)
        {
            for (Int64 i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }


    }
}
