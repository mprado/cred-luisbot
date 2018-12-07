using System;
using System.Threading.Tasks;
using System.Web.Http;

using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Dialogs;
using System.Web.Http.Description;
using System.Net.Http;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.Bot.Sample.LuisBot
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// receive a message from a user and send replies
        /// </summary>
        /// <param name="activity"></param>
        [ResponseType(typeof(void))]
        public virtual async Task<HttpResponseMessage> Post([FromBody] Activity activity)
        {
            // check if activity is of type message
            if (activity.GetActivityType() == ActivityTypes.Message)
            {
                await Conversation.SendAsync(activity, () => new BasicLuisDialog());
            }
            else
            {
                await HandleSystemMessage(activity);
            }
            return new HttpResponseMessage(System.Net.HttpStatusCode.Accepted);
        }

        private async Task<Activity> HandleSystemMessage(Activity message)
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

                //var reply = message.CreateReply("Olá! Eu sou o Credicitrus Bot. Sou novo na empresa e ainda estou aprendendo muitas coisas. Você precisa de alguma ajuda?");
                //ConnectorClient connector = new ConnectorClient(new Uri(message.ServiceUrl));
                //await connector.Conversations.ReplyToActivityAsync(reply);

                IConversationUpdateActivity update = message;
                var client = new ConnectorClient(new Uri(message.ServiceUrl), new MicrosoftAppCredentials());
                if (update.MembersAdded != null && update.MembersAdded.Any())
                {
                    var reply = message.CreateReply("Olá! Eu sou o Credicitrus Bot. \U0001F916 \n Sou novo na Cooperativa e ainda estou aprendendo muitas coisas. Você precisa de alguma ajuda?");
                    ConnectorClient connector = new ConnectorClient(new Uri(message.ServiceUrl));
                    await connector.Conversations.ReplyToActivityAsync(reply);

                    //foreach (var newMember in update.MembersAdded)
                    //{
                    //    if (newMember.Id != message.Recipient.Id)
                    //    {
                    //        var reply = message.CreateReply();
                    //        reply.Text = $"Hello {newMember.Name}! I'm the Credicitrus Bot. I'm new to the company and I'm still learning many things. Do you need any help?";
                    //        await client.Conversations.ReplyToActivityAsync(reply);
                    //    }
                    //}
                }
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