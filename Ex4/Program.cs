using System;
using System.Globalization; //importa a cultura variável

namespace SISTEMADEALUNO
{
    class Program
    {
        static void Main(string[] args) //método que executa o programa
        {
            Console.WriteLine("Digite a primeira nota:"); //Exibe mensagem pedindo a primeira nota
            double numero1 = double.Parse(// lê a primeira nota como texto e converte em double ("ponto" como separador inicial)
                Console.ReadLine(),
                CultureInfo.InvariantCulture //comando para garantir o separador decimal 
            );

            Console.WriteLine("Digite a segunda nota:");//idem
            double numero2 = double.Parse(
                Console.ReadLine(),
                CultureInfo.InvariantCulture
            );

            if(numero1 > numero2){
                System.Console.WriteLine("O numero: " + numero1 + " é maior que " + numero2 + ".");
            } else{
                System.Console.WriteLine("O numero: " + numero2 + " é maior que " + numero1 + ".");

            }
            
        }
    }
}
