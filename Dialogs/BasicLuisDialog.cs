using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using LuisBot.Data;
using LuisBot.Models;
using LuisBot.Repositories;
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
            await context.PostAsync("Desculpe, não consegui entender o que você disse \U0001F614 \n Tente novamente");
            context.Wait(MessageReceived);
        }

        // Go to https://luis.ai and create a new intent, then train/publish your luis app.
        // Finally replace "Greeting" with the name of your newly created intent in the following handler
        [LuisIntent("Cumprimento")]
        public async Task GreetingIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisResult(context, result);
        }

        [LuisIntent("PA")]
        public async Task PAIntent(IDialogContext context, LuisResult result)
        {
            Filial filial;

            var numeroFilial = result.Entities.FirstOrDefault(c => c.Type == "numero_pa");

            if (numeroFilial != null && numeroFilial.Entity != null)
            {
                filial = new PARepository().ObterPorNumero(Convert.ToInt32(numeroFilial.Entity));

                if ((result.Query.Contains("localização")) ||
                (result.Query.Contains("localizacao")) ||
                (result.Query.Contains("onde fica")) ||
                (result.Query.Contains("onde é")) ||
                (result.Query.Contains("endereço")) ||
                (result.Query.Contains("endereco")))
                {
                    await context.PostAsync($"A localização do PA {filial.Numero} - {filial.Descricao} é:");
                    context.Wait(MessageReceived);

                    await context.PostAsync($"{filial.Endereco}, {filial.Bairro} - {filial.Municipio}/{filial.UF}");
                    context.Wait(MessageReceived);
                }
            }
            else
            {
                await context.PostAsync($"Humm... Não consegui entender! O que você precisa saber sobre nossos PA's? \n Ex.: Qual endereço do PA 5 ?");
                context.Wait(MessageReceived);
            }
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