using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ca_questao03;

namespace Questão_02
{
    internal class Program
    {
        static void Main()
        {
            // Exemplo de uso
            Pilha pilhaDePecas = new Pilha();

            pilhaDePecas.Inserir("Cúpula de Vidro");
            pilhaDePecas.Inserir("Lâmpada");
            pilhaDePecas.Inserir("Hélice Quebrada");
            pilhaDePecas.Inserir("Suporte");

            pilhaDePecas.ExibirPilha(); // Mostrar o estado inicial da pilha

            // Solicitar ao usuário a peça original e a nova peça
            Console.Write("Digite a peça original a ser trocada: ");
            string pecaOriginal = Console.ReadLine();

            Console.Write("Digite a nova peça: ");
            string pecaNova = Console.ReadLine();

            // Trocar a peça original pela nova
            pilhaDePecas.TrocarPeca(pecaOriginal, pecaNova);

            // Exibindo as peças na pilha após a troca
            Console.WriteLine("Peças na pilha após a troca:");
            pilhaDePecas.ExibirPilha();
        }


    }
}
