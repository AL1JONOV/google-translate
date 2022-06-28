using System;
using Telegram.Bot;
using GoogleTranslateFreeApi;
using System.Net;
using Xceed.Wpf.Toolkit;
using System.Windows;
//using MessageBox = System.Windows.MessageBox;
using GoogleCloudPrintApi;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;
using GoogleTranslateFreeApi.TranslationData;
using GoogleCloudPrintApi;
using GoogleTranslateFreeApi;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        private static string token = "5407360361:AAG96Vf3XTYMGMXEQf_DN4s-GqIdLN5fR5M";
        private static GoogleTranslator translater;
        private static TelegramBotClient client;

        public static void  Main()
        {


            client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();





        }

        private static async void OnMessageHandler(object? sender, MessageEventArgs e)
        {
           var url = "https://apimicrosofttranslator.com/V2/Http.svc/Translate?" + $"to{Language.English}+from{Language.Uzbek}";
           // var URl = "https://translate.google.com/?sl=uz&tl=ru&op=translate" + $"to{Language.English}+from{Language.Uzbek}" ;
            var message = e.Message;

            if (message.Text == "English")
            {


              
                await client.SendTextMessageAsync(message.Chat.Id, message.Text);
               
                await translater.TranslateLiteAsync(
                    originalText: $"{message.Chat.Id}",
                  
                    fromLanguage: Language.English,
                    toLanguage: Language.Uzbek
                    );

               
            }
            else
                if (message.Text == "Uzbek")
            {

                await client.SendTextMessageAsync(message.Chat.Id, message.Text);
                await translater.TranslateLiteAsync(
                originalText: $"{message.Chat.Id}",
                fromLanguage: Language.English,
                toLanguage: Language.Uzbek
                );

            }

         //   Console.WriteLine($"Salom => {message.Text}");

            // await client.SendTextMessageAsync(message.Chat.Id, message.Text);

            


        }
    }
}


       
        /*
if (message.ToString() != null)
{
    translator.TranslateLiteAsync
        (
        originalText: $"{message.ToString()}",
        fromLanguage: Language.Uzbek,
        toLanguage: Language.English
        );
    //Console.WriteLine(message.ToString());
    Console.WriteLine(translator.ToString());
}
*/






        /* private static string token = "5407360361:AAG96Vf3XTYMGMXEQf_DN4s-GqIdLN5fR5M";
         private static GoogleTranslator translater;
          GoogleTranslator translator = new GoogleTranslator();
         private static TelegramBotClient client;
         static void Main(string[] args)
         {
             client = new TelegramBotClient(token);
             client.StartReceiving();
             client.OnMessage += OnMessageHandler;
             Console.ReadLine();
             client.StopReceiving();
             //Console.WriteLine("Assalomu Alaykum : Hi every one: ");
         }*/



        /// /////////////      /// /////////////////////////////////////////////////////////////////////////////////+//////////////////////////////////////////////////////+++++++


        /* private static async void OnMessageHandler(object? sender, MessageEventArgs e)
         {


             var message = e.Message;

             Console.WriteLine($"Salom => {message.Text}");

            // await client.SendTextMessageAsync(message.Chat.Id, message.Text);

             if (message.Text == "English")
             {



                 //await client.SendTextMessageAsync(message.Chat.Id, message.Text);
                 await translater.TranslateLiteAsync(
                     originalText: $"{message.Chat.Id}",
                     fromLanguage: Language.English,
                     toLanguage: Language.Uzbek
                     );
             }
             else
                 if (message.Text == "Uzbek")
             {

                 //await client.SendTextMessageAsync(message.Chat.Id, message.Text);
                 await translater.TranslateLiteAsync(
                 originalText: $"{message.Chat.Id}",
                 fromLanguage: Language.English,
                 toLanguage: Language.Uzbek
                 );

             }*/

  
      /*  private static IReplyMarkup GetButtens()
        {

            return new ReplyKeyboardMarkup
            {

                Keyboard = new List<List<KeyboardButton>>
            {

                new List<KeyboardButton>{ new KeyboardButton { Text = "Start"} }


            }
            };*/
        
  
    




        /*  public string Trnslatwithgoogle(string input, string languagePair)
        {
            try
            {
                string url = String.Format($"http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}");

                WebClient webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.Default;
                string result = webClient.DownloadString(url);
                result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
                result = result.Substring(result.IndexOf(">") + 1);
                result = result.Substring(0, result.IndexOf("</span>"));
                return result.Trim();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                return string.Empty;
            }
        }*/



    


