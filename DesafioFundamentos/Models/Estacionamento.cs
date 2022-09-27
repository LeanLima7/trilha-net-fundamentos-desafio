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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
           
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string novoVeiculo = Console.ReadLine();
            // Recebe as informações do usuário e insete na string novoVeiculo
           
            veiculos.Add(novoVeiculo);
            // Adiciona a informação recebida na lista 'veiculos'
            
             // *Implementado
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
         
            string placa = Console.ReadLine();

            // Recebe a informação digitada pelo usuário e armazena na strin placa

            // *Implementado

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                horas = Convert.ToInt16(Console.ReadLine());
                // Recebe a informação do usuário como srting e converte para inteito para a informação ser armazenada na variavel horas

                decimal valorTotal = 0; 
                 valorTotal = precoInicial + (precoPorHora * horas);
                // Realiza o calculo conforme solicitado.

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados

                 foreach(string veiculosEstacionados in veiculos)
                {
                    Console.WriteLine(veiculosEstacionados);
                }
                
                 // *Implementado

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
