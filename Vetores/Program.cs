using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            int i = 0;
            //Cadastro dos nomes
            for (int x = 0; x < 10; x++)
            {
                Console.Write("Informe o "+ (x + 1) +"o. nome..: " );
                nomes[x] = Console.ReadLine();
            }

            Console.Clear();  // limpa a tela do console

            //impressão dos nomes
            while (i < 10)
            {
                Console.WriteLine(nomes[i]);
                i++;
            }
            Console.ReadKey();

        }
    }
}
