using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

//antes de criar a api , instalar no pacote de nuget: newtonsoft.Json

//httpClient : Usado para fazer requisiçoes HTTP, como get, post,put,delete.

//GetAsync: metodo assincrono usado para fazer requisição Get.

//ReadAsStringAsync: Lê a resposta da API como uma string.

//JsonConvert.DeserializeObject: Usado para converter o Json da resposta em um Objeto C#
//quando você marca um método como async, o compilador permite o uso de await dentro dele,
//que é a palavra chave que indica onde o código deve esperar por uma operação assincrona.
//os dados, sempre depende de algum recurso para exibir algo. Ex: Console.Write

namespace Api
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Criação da instancia do HttpClient
            HttpClient client = new HttpClient();

            //Define a Url do api
            string apiUrl = "https://fakestoreapi.com/products";

            try
            {
                //Enviar uma requisição Get para a api  
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                //Verificar se a requisição foi bem-sucedidda
                if (response.IsSuccessStatusCode)
                {
                    //ler o conteudo da resposta como uma string
                    string jsonResult = await response.Content.ReadAsStringAsync();

                    //Converter p JSON para mum objeto C#
                    var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonResult);
                    Console.WriteLine("Resposta da API: ");

                    //Exibir o resultado
                    //Console.WriteLine(jsonResult);

                    foreach (var produto in jsonObject)

                    {
                    Console.WriteLine($"nome: {produto.title}" + $" Nota: {produto.rating.rate}");
                    }
                }
                else
                {
                    Console.WriteLine($"Erro na requisição: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                //Fechar o HttpClient
                client.Dispose();
            }
        }
    }
}