using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace Microsoft.Bot.Sample.LuisBot
{
    // For more information about this template visit http://aka.ms/azurebots-csharp-luis
    [Serializable]
    public class BasicLuisDialog : LuisDialog<object>
    {
        public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(
            ConfigurationManager.AppSettings["LuisAppId"],
            ConfigurationManager.AppSettings["LuisAPIKey"],
            domain: ConfigurationManager.AppSettings["LuisAPIHostName"])))
        {
        }

        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            //string message = $"I'm the Cred Bot. I can understand requests to create, delete, and read notes. \n\n Detected intent: " + string.Join(", ", result.Intents.Select(i => i.Intent));
            //string message = "Olá! Eu sou o Credicitrus Bot. Sou novo na empresa e ainda estou aprendendo muitas coisas. Você precisa de alguma ajuda?";
            await context.PostAsync("Olá! Eu sou o Credicitrus Bot \U0001F916 \n Sou novo na Cooperativa e ainda estou aprendendo muitas coisas. Você precisa de alguma ajuda?");
            context.Wait(MessageReceived);
        }

        //[LuisIntent("None")]
        //public async Task NoneIntent(IDialogContext context, LuisResult result)
        //{
        //    await this.ShowLuisResult(context, result);
        //}

        // Go to https://luis.ai and create a new intent, then train/publish your luis app.
        // Finally replace "Greeting" with the name of your newly created intent in the following handler
        [LuisIntent("Cumprimento")]
        public async Task GreetingIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisResult(context, result);
            //await context.PostAsync($"Olá! Qual seu nome?");
        }

        [LuisIntent("Cancel")]
        public async Task CancelIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisResult(context, result);
        }

        [LuisIntent("Help")]
        public async Task HelpIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisResult(context, result);
        }

        private async Task ShowLuisResult(IDialogContext context, LuisResult result)
        {
            string entities = "Entidades:\n";
            result.Entities.ToList().ForEach(x => entities += string.Format("{0}: {1} ({2}) \n", x.Type, x.Entity, x.Score.ToString()));

            await context.PostAsync($"Você disse: {result.Query} \n Intenção: { result.Intents[0].Intent} \n " + entities);
            context.Wait(MessageReceived);
        }
    }
}