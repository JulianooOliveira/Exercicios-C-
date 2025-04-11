using System;
using System.Globalization; //importa a cultura variável

namespace SISTEMADEALUNO
{
    class Program
    {
        static void Main(string[] args) //método que executa o programa
        {
            Console.WriteLine("Digite um número qualquer: "); //Exibe mensagem pedindo a primeira nota
            int numero = int.Parse(// lê a primeira nota como texto e converte em double ("ponto" como separador inicial)
                Console.ReadLine());

            if(numero % 2 == 0){
                Console.WriteLine("O número " + numero + " é par.");
            }else{
                Console.WriteLine("O número " + numero + " é impar.");
            }
            
        }
    }
}
