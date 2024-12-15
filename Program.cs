using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            // Consultar cotação atual
            decimal cotacaoAtual = await ObterCotacaoDolar();

            
            Console.Write("Digite o valor em dólares (USD): ");
            decimal valorEmDolar = decimal.Parse(Console.ReadLine());

            // Calcular conversão
            decimal valorEmReal = valorEmDolar * cotacaoAtual;

            
            Console.WriteLine($"\nCotação atual: 1 USD = R$ {cotacaoAtual:F2}");
            Console.WriteLine($"Valor em dólares: USD {valorEmDolar:F2}");
            Console.WriteLine($"Valor em reais: R$ {valorEmReal:F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static async Task<decimal> ObterCotacaoDolar()
    {
        string apiUrl = "https://api.exchangerate-api.com/v4/latest/USD";

        using (HttpClient cliente = new HttpClient())
        {
            HttpResponseMessage resposta = await cliente.GetAsync(apiUrl);
            resposta.EnsureSuccessStatusCode();

            string conteudoResposta = await resposta.Content.ReadAsStringAsync();
            JObject dadosConversao = JObject.Parse(conteudoResposta);

            decimal cotacaoBRL = dadosConversao["rates"]["BRL"].Value<decimal>();
            return cotacaoBRL;
        }
    }
}