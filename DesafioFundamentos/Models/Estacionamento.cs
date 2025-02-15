using System;
using System.Collections.Generic;
using System.Linq;

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
            // implementado
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); 
            // Verifica se a entrada não está vazia
            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa.ToUpper()); 
                Console.WriteLine($"Veículo {placa.ToUpper()} adicionado com sucesso!");
            }

            else
            {
                Console.WriteLine("Placa inválida! Tente novamente.");
            }

        }


        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
             // implementado
            string placa = Console.ReadLine();
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // implementado
                if (int.TryParse(Console.ReadLine(), out int horas) && horas > 0)
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                     // implementado
                    veiculos.Remove(placa.ToUpper()); 
                    Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
                }

                else
                {
                    Console.WriteLine("Entrada inválida para as horas. Tente novamente.");
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
                Console.WriteLine("Os veículos estacionados são:");
                
                 // implementado
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                }

            }

            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

        }

    }
    
}
