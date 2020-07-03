using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BotAttendantToFastFood.Form;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using Newtonsoft.Json;

namespace BotAttendantToFastFood.Dialogs
{
    [Serializable]
    [LuisModel("7dc50fca-efc4-43eb-bebc-f53e36de9f7d", "c8247819daf1417982ebf47b7f9b2c10")]
    public class InteractionWithLuis : LuisDialog<Pedido>
    {
        private readonly BuildFormDelegate<Pedido> CriarPedido;

        internal InteractionWithLuis(BuildFormDelegate<Pedido> criarPedido)
        {
            this.CriarPedido = criarPedido;
        }

        //Se as intenções forem retornadas como uma intenção "None" pelo LUIS, cairão no meu método abaixo
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"Desculpe, não consegui compreender a sua intenção na frase **'{result.Query}'**");
        }

        //Dizendo que as intenções que forem retornadas como "Cumprimento" pelo LUIS, cairão no meu método abaixo
        [LuisIntent("Cumprimento")]
        public async Task Cumprimento(IDialogContext context, LuisResult result)
        {
            //await context.PostAsync("Olá, meu nome é **Merviu**, sou o atendente **BOT** do **Hungry Fast-Food** " +
            //                        "e estas são todas as minhas funções para atendê-lo:<br/>" +
            //                        "**->Posso lhe mostrar as nossas opções pelo cardápio.**<br/>" +
            //                        "**->Posso anotar, encaminhar e receber o pagamento do seu pedido.**<br/>" +
            //                        //"**->Posso lhe informar quantos pedidos de clientes estão na frente do seu pedido.**<br/>" +
            //                        "**->Posso lhe informar o endereço do nosso estabelecimento.**<br/>" +
            //                        "**->Posso lhe informar os meios de contato do nosso estabelecimento.**<br/>" +
            //                        "**->Posso lhe informar os dias e horários de funcionamento do nosso estabelecimento.**<br/>"
            //                        //"**->Posso registrar feedbacks ou reclamações sobre o estabelecimento.**<br/>" +
            //                        //"**->Posso lhe informar os valores atuais das moedas EURO, DOLAR e BITCOIN**.<br/>"
            //                        );
            await context.PostAsync("Hello, I'm the **BOT** virtual attendent of **Hungry Fast-Food** " +
                                    "and these are all my functions to serve you:<br/>" +
                                    "**->I can show you our options on the menu.**<br/>" +
                                    "**->I can write down, forward and receive payment for your order.**<br/>" +
                                    //"**->Posso lhe informar quantos pedidos de clientes estão na frente do seu pedido.**<br/>" +
                                    "**->I can inform you the address of our establishment.**<br/>" +
                                    "**->I can inform you the means of contact of our establishment.**<br/>" +
                                    "**->I can inform you the days and hours of operation of our establishment.**<br/>"
                                    //"**->Posso registrar feedbacks ou reclamações sobre o estabelecimento.**<br/>" +
                                    //"**->Posso lhe informar os valores atuais das moedas EURO, DOLAR e BITCOIN**.<br/>"
                                    );
        }

        //Se as intenções forem retornadas como uma intenção "Sobre-bot" pelo LUIS, cairão no meu método abaixo
        [LuisIntent("Sobre-bot")]
        public async Task SobreBot(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Eu me chamo **Merviu**, sou o atendente **BOT** do **Hungry Fast-Food** " +
                                    "e estas são todas as minhas funções para atendê-lo:<br/>" +
                                    "**->Posso lhe mostrar as nossas opções pelo cardápio.**<br/>" +
                                    "**->Posso anotar, encaminhar e receber o pagamento do seu pedido.**<br/>" +
                                    //"**->Posso lhe informar quantos pedidos de clientes estão na frente do seu pedido.**<br/>" +
                                    "**->Posso lhe informar o endereço do nosso estabelecimento.**<br/>" +
                                    "**->Posso lhe informar os meios de contato do nosso estabelecimento.**<br/>" +
                                    "**->Posso lhe informar os dias e horários de funcionamento do nosso estabelecimento.**<br/>"
                                    //"**->Posso registrar feedbacks ou reclamações sobre o estabelecimento.**<br/>" +
                                    //"**->Posso lhe informar os valores atuais das moedas EURO, DOLAR e BITCOIN**.<br/>"
                                    );
        }

        //Se as intenções forem retornadas como uma intenção "Sobre-contato" pelo LUIS, cairão no meu método abaixo
        [LuisIntent("Sobre-contato")]
        public async Task SobreContato(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"Temos: <br/>" +
                                    $"**Telefone Fixo: (32) 3422-0422**<br/>" +
                                    $"**Celular: (32) 98842-4215**<br/>" +
                                    $"**Email: [hungryfastfood@gmail.com](mailto:hungryfastfood@gmail.com)**<br/>" +
                                    $"**Facebook: Hungry FastFood**<br/>" +
                                    $"**Instagram: hungry_fastfood.**<br/>");
        }

        //Se as intenções forem retornadas como uma intenção "Sobre-funcionamento" pelo LUIS, cairão no meu método abaixo
        [LuisIntent("Sobre-funcionamento")]
        public async Task SobreFuncionamento(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Funcionamos **todos os dias da semana**:<br/>" +
                                    "Segunda a Sexta das 15 horas as 22 horas.<br/>" +
                                    "Sábado, Domingo e Feriados das 15 horas as 02 horas.<br/>");
        }

        //Se as intenções forem retornadas como uma intenção "Sobre-localizacao" pelo LUIS, cairão no meu método abaixo
        [LuisIntent("Sobre-localizacao")]
        public async Task SobreLocalizacao(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Atualmente estamos na **Rua Major Vieira**, **número: 324**, localizado no **centro da cidade de Cataguases-MG.**");
        }

        [LuisIntent("Cotacao")]
        public async Task Cotacao(IDialogContext context, LuisResult result)
        {
            var entitiesMoedas = result.Entities?.Select(e => e.Entity); //Testando se captou as entidades de moedas, SE EXISTIR atribuimos cada uma dessas entidades a var moedas
            var filtroMoedas = string.Join(",", entitiesMoedas.ToArray()); //Montando uma string com o nome de cada moeda captada como entidade e as separando por vírgulas
            var endpoint = $"http://api-cotacoes-maratona-bots.azurewebsites.net/api/Cotacoes/{filtroMoedas}"; //Montando a nossa url com o parâmetro "filtroMoedas" contendo os nomes de todas as moedas captadas
            
            await context.PostAsync("Aguarde... estou consultando os valores...");

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(endpoint); //Executando o meu request para a API
                if (!response.IsSuccessStatusCode) //Se houver algum erro no meu request o loop entra aqui
                {
                    await context.PostAsync("Ocorreu um erro... tente mais tarde");
                }
                else //Request OK
                {
                    var json = await response.Content.ReadAsStringAsync(); //Pegando todo conteúdo da minha consulta que virá como um JSON
                    var resultado = JsonConvert.DeserializeObject<Models.Cotacao[]>(json); //Deserializando os objetos JSON que foram coletados

                    var cotacoes = resultado.Select(c => $"{c.Nome}: {c.Valor}"); //Montando a string de resposta referente a cada consulta de moeda
                    await context.PostAsync($"{string.Join(", ",cotacoes.ToArray())}"); //Juntando e separando com vírgula todas as consultas de moedas em uma única string
                }
            }
        }
        
        //Se as intenções forem retornadas como uma intenção "Comprar" pelo LUIS, cairão no meu método abaixo
        [LuisIntent("Comprar")]
        public async Task Comprar(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"Below is our menu:");
            Activity resposta = ((Activity)context.Activity).CreateReply();

            await context.PostAsync(ReturnMenu(resposta)); //Envia o carousel pronto para o client

            //await context.PostAsync("Irei iniciar o formulário...");
            var pedidoForm = new FormDialog<Pedido>(new Pedido(), this.CriarPedido, FormOptions.PromptInStart);
            context.Call<Pedido>(pedidoForm, PedidoCompleto);
        }

        //Será respondido com um carousel que representa o cardápio
        private Activity ReturnMenu( Activity resposta)
        {
                //Recebe o carousel (cardápio completo)
                resposta.AttachmentLayout = AttachmentLayoutTypes.Carousel;

                resposta.Attachments.Add(Cards.getThumbCardHambClassico());
                resposta.Attachments.Add(Cards.getThumbCardHambMisto());
                resposta.Attachments.Add(Cards.getThumbCardHambFrango());
                resposta.Attachments.Add(Cards.getThumbCardHambVegetariano());
                resposta.Attachments.Add(Cards.getThumbCardHambVegano());
                resposta.Attachments.Add(Cards.getThumbCardHambMegaXTudo());
                resposta.Attachments.Add(Cards.getThumbCardBebidaCoca());
                resposta.Attachments.Add(Cards.getThumbCardBebidaRefri());
                resposta.Attachments.Add(Cards.getThumbCardBebidaSuco());

                return resposta;
        }

        private async Task PedidoCompleto(IDialogContext context, IAwaitable<Pedido> result)
        {
            Pedido pedido = null;
            try
            {
                pedido = await result;
            }
            catch (OperationCanceledException)
            {
                await context.PostAsync("Você cancelou o pedido.");
                return;
            }

            if (pedido != null)
            {
                await context.PostAsync($"Seu pedido: {Pedido.IDPedido.ToString()}");
            }
            else
            {
                await context.PostAsync("Formulário retornou vazio");
            }

            context.Wait(MessageReceived);
        }

        async Task ObterItensAsync(IDialogContext context, IAwaitable<IMessageActivity> argumento)
        {
            var atividade = await argumento as Activity;
        }
    }
}