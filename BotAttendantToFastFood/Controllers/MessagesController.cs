using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using BotAttendantToFastFood.Dialogs;
using BotAttendantToFastFood.Form;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Connector;

namespace BotAttendantToFastFood
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            //Teste de Atualização de idioma
            //var CurrentUICulture = Thread.CurrentThread.CurrentUICulture;
            //var CurrentCulture = Thread.CurrentThread.CurrentCulture;

            activity.Locale = "pt-BR"; //Ficará com localização e idioma fixo apenas por enquanto

            if (activity.Type == ActivityTypes.Message) //Testa se foi enviado uma mensagem
            {
                //Se for enviado um activity do tipo mensagem será instanciado um Dialog e chamará o LuisDialog()
                await Conversation.SendAsync(activity, CriarDialogo);
            }
            else //Se o tipo de atividade não for uma mensagem
            {
                /*
                É chamado o método HandleSystemMessage, ou seja, "Lidar com a mensagem do Sistema"
                E é passado como parametro a activity para ser tratada.
                */
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        internal static IDialog<Pedido> CriarDialogo()
        {
            return Chain.From(() => new InteractionWithLuis(Pedido.BuildForm));
        }

        /*
        O método HandleSystemMessage trata de lidar com a atividade que foi passada como parâmetro, assim ele verifica
        pelo tipo da atividade que foi passada e de acordo com cada caso ele executa algum comando dentro dos if's e else's
        */
        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}