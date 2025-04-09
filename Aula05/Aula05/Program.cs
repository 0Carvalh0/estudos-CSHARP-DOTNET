using System.Reflection.Emit;

namespace Aula05;

public class Program
{

    public static void Main(string[] args)
    {
        int op, res = 0, mod = 0;
        string cont;
        do
        {
            Label:
            Console.Clear();
            Console.WriteLine("============= CALCULADORA SIMPLES =============");

            Console.WriteLine("Qual operação você deseja fazer? ");
            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
            op = int.Parse(Console.ReadLine());
            Console.Clear();
            if (op < 1 || op > 4)
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
                goto Label;
            }

            Console.WriteLine("Digite o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                // SOMA
                res = n1 + n2;
            }
            else if (op == 2)
            {
                // SUBTRAÇÃO
                res = n1 - n2;
            }
            else if (op == 3)
            {
                //MULTIPLICAÇÃO
                res = n1 * n2;
            }
            else if (op == 4)
            {
                // DIVISÃO
                res = n1 / n2;
                mod = n1 % n2;
            }

            Console.WriteLine("Resultado: " + res);

            if (op == 4)
            {
                Console.WriteLine("O resto da divisão: " + mod);
            }

            Console.WriteLine("Deseja continuar fazendo calculos? [s/n]");
            cont = Console.ReadLine();
        } while (cont == "s");
    }
}
