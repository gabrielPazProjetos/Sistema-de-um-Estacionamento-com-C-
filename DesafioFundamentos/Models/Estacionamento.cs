using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine()?.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
                return;
            }

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Este veículo já está estacionado.");
                return;
            }

            veiculos.Add(placa);
            Console.WriteLine($"Veículo {placa} adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine()?.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
                return;
            }

            if (!veiculos.Contains(placa))
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
                return;
            }

            Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            if (!int.TryParse(Console.ReadLine(), out int horas) || horas < 0)
            {
                Console.WriteLine("Quantidade de horas inválida.");
                return;
            }

            decimal valorTotal = precoInicial + (precoPorHora * horas);
            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido. Valor total: R$ {valorTotal:F2}");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (var placa in veiculos)
                {
                    Console.WriteLine($"- {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
