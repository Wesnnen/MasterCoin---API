# Conversor de Dólares (USD) para Reais (BRL)

Este projeto é um simples conversor de moeda que solicita ao usuário um valor em dólares (USD), consulta a cotação do dólar em tempo real e exibe o valor convertido em reais (BRL). Ele utiliza a [Exchangerate-API](https://www.exchangerate-api.com/) para obter a cotação atual do dólar.

## Funcionalidades

- Consulta a cotação do dólar em tempo real usando a API Exchangerate.
- Solicita ao usuário um valor em dólares (USD).
- Calcula a conversão para reais (BRL) com base na cotação obtida.
- Exibe a cotação atual do dólar em reais e o valor convertido.

## Requisitos

- .NET Core 3.1 ou superior.
- Biblioteca `Newtonsoft.Json` para manipulação de dados JSON.

## Como Usar

1. Clone este repositório ou faça o download do código.
2. Abra o projeto no Visual Studio ou no editor de sua escolha.
3. Instale o pacote `Newtonsoft.Json` no seu projeto via NuGet:
   ```bash
   Install-Package Newtonsoft.Json
   ```
4. Execute o programa.
5. O programa solicitará o valor em dólares (USD) e, em seguida, exibirá o valor convertido para reais (BRL) com base na cotação atual.

## Exemplo de execução:
```less
Digite o valor em dólares (USD): 100
Cotação atual: 1 USD = R$ 5.50
Valor em dólares: USD 100.00
Valor em reais: R$ 550.00
```
## Estrutura do Código
O código está estruturado em duas partes principais:

1. **Função ObterCotacaoDolar**:
  * Esta função faz uma solicitação HTTP para a API Exchangerate, obtém a cotação atual do dólar e retorna o valor da cotação em reais (BRL).
  * A URL da API utilizada é: https://api.exchangerate-api.com/v4/latest/USD.
  * A função é assíncrona, ou seja, utiliza async e await para realizar a chamada à API sem bloquear o thread principal.

2. **Função `Main`**:
  * Solicita ao usuário um valor em dólares.
  * Chama a função ObterCotacaoDolar para obter a cotação em tempo real.
  * Calcula e exibe o valor em reais, com base no valor fornecido pelo usuário e na cotação atual.

## Considerações
  * O código utiliza a API Exchangerate-API para obter a cotação do dólar, que é uma API gratuita com limites de requisições. Certifique-se de verificar os detalhes e as limitações da API no site Exchangerate-API.
  * O valor retornado pela API é arredondado para duas casas decimais ao ser exibido para o usuário.


