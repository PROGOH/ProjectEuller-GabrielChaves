using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cada novo termo na seqüência de Fibonacci é gerado pela soma dos dois termos anteriores. Ao iniciar com 1 e 2, os primeiros 10 será termos:
//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
//Considerando os termos da sucessão de Fibonacci cujos valores não ultrapassem quatro milhões, encontrar a soma dos termos ainda valorizados.

namespace PEProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(2);

            int anterior = 1;
            int atual = 2;
            int temp = 0;

            while (atual < 4000000)
            {
                if ((anterior + atual) % 2 == 0)
                    lista.Add(anterior + atual);

                temp = atual;
                atual = anterior + atual;
                anterior = temp;
            }

            Console.Write("Solução: {0}", lista.Sum());
            Console.ReadKey();
        }
    }
}
