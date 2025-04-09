using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // OUTPUT
            Console.WriteLine("================ LOGIN ================");

            // INPUT
            // Solicitar o nome do usuário
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();

            // Solicitar a idade do usuário
            Console.WriteLine("Digite sua idade: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("========================================");

            // OUTPUT
            Console.WriteLine("Nome do usuário: " + name);
            Console.WriteLine("Idade do usuário: " + age);
        }
    }
}
