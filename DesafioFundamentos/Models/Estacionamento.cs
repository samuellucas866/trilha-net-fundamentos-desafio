using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        
        private List<string> veiculos = new List<string>();
        
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
              
            // Implementado o metodo para adicionar o veículo a lista e ser armazenado/adicionado.
            Console.WriteLine("Digite a placa do veículo que vai estacionar: ");           
            veiculos.Add(Console.ReadLine());
        
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            Console.ReadLine();

            //Implementado o metodo para que a string placa receba a placa declarada e armazenada!!!
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para remover: ");
            placa = Console.ReadLine();

            
           // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                //Implementado o laço While para que o usuário informe a quantidade de horas!!!
                int horas = 0;
                decimal valorTotal = 0; 

                while(int.TryParse(Console.ReadLine(), out horas) && horas >0)
                {
                
                    valorTotal = precoInicial + precoPorHora * horas;         
                
                //Implementado o método para remover veículo.

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:" + veiculos.Count());
                
                // Implementado o laço foreach para listar os veículos estacionados e o método count,
                // para listar os veículos adicionados e quantos são.               
                foreach(string placa in veiculos)
                {
                    Console.WriteLine(placa.ToString());
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        
    }
}
