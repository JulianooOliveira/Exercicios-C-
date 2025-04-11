using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class Program
    {
        public static void Main(string[] args){
                    Console.WriteLine("Digite o nome do aluno:"); //Exibe mensagem pedindo o nome do aluno
        string nome = Console.ReadLine(); //Lê o nome digitado e armazena a variável "nome"

        Console.WriteLine("Olá " + nome + ", seja muito bem vindo!");
        }
    }
}