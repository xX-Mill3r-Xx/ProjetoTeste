using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola, Mundo");
            Console.Write($"Entre com seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"O nome do usuario é {nome}");
            Console.ReadKey();
        }
    }
}
