using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class Program
    {
        public static void Main(string[] args){

        Console.WriteLine("Digite seu nome: "); //Exibe mensagem pedindo o nome do aluno
        string nome = Console.ReadLine(); //Lê o nome digitado e armazena a variável "nome"

        Console.WriteLine("Qual ano você nasceu? "); //Exibe mensagem pedindo o nome do aluno
        int anoNascimento = int.Parse(Console.ReadLine()); //Lê o nome digitado e armazena a variável "nome"

        int anosVida = 2025 - anoNascimento;

        Console.WriteLine("Olá " + nome + ", seja muito bem vindo! Você tem " + anosVida + " anos de idade.");
        }


    }
}