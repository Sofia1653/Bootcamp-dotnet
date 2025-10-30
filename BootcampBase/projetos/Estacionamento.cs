using System;
using System.Collections.Generic; 

namespace BootcampBase
{
    public class Estacionamento
    {
        private decimal precoFixo;
        private decimal precoExtra;
        private List<string> veiculos = new List<string>(); 
        
        public Estacionamento(decimal precoFixo, decimal precoExtra)
        {
            this.precoFixo = precoFixo;
            this.precoExtra = precoExtra;
        }

        public int Menu()
        {
            Console.WriteLine("\nDigite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            int resposta;
            while (!int.TryParse(Console.ReadLine(), out resposta) || resposta < 1 || resposta > 4)
            {
                Console.WriteLine("Opção inválida! Digite novamente:");
            }

            return resposta;
        }

        public void CadastrarVeiculo()
        {
            Console.Write("Digite a placa do carro: ");
            string placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo {placa} cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa inválida!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do carro a ser removido: ");
            string placa = Console.ReadLine()?.ToUpper();

            if (veiculos.Contains(placa))
            {
                Console.Write("Quantas horas você ficou no estacionamento? ");
                int tempo;

                while (!int.TryParse(Console.ReadLine(), out tempo) || tempo < 1)
                {
                    Console.WriteLine("Digite um número válido de horas:");
                }

                decimal total = precoFixo + precoExtra * (tempo - 1);
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido. Valor total: R$ {total:F2}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado!");
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("\n=== Veículos Cadastrados ===");

            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
            else
            {
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
        }

        
    }
}

//Programa
/*Console.WriteLine("Seja bem-vindo ao sistema de estacionamento\n");

Console.Write("Qual é o preço inicial? R$ ");
decimal precoFixo = Convert.ToDecimal(Console.ReadLine());

Console.Write("Qual é o preço por hora adicional? R$ ");
decimal precoExtra = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoFixo, precoExtra);

bool rodando = true;
while (rodando)
{
    int opcao = estacionamento.Menu();

    switch (opcao)
    {
        case 1:
            estacionamento.CadastrarVeiculo();
            break;
        case 2:
            estacionamento.RemoverVeiculo();
            break;
        case 3:
            estacionamento.ListarVeiculos();
            break;
        case 4:
            rodando = false;
            Console.WriteLine("Encerrando o sistema");
            break;
    }
}*/