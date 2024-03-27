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
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"            
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.Clear();
            Console.WriteLine("Placa cadastrada com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();


            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Clear();
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                int quantidadeHoras = int.Parse(Console.ReadLine());

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                decimal valorTotal = precoInicial + (precoPorHora * quantidadeHoras);

                // TODO: Remover a placa digitada da lista de veículos
                Console.Clear();
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.Clear();
                Console.WriteLine("\nOs veículos estacionados são:\n");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Veículo de Placa: {veiculo}");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
