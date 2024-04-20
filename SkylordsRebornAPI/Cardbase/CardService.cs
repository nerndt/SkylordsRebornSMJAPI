using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SkylordsRebornAPI.Cardbase.Cards;

namespace SkylordsRebornAPI.Cardbase
{
    public class CardService
    {
        private readonly string baseUrl = "https://smj.cards/api/"; // NGE04182024 THIS GETS AN OK RESPONSE FROM THE SERVER // "https://cardbase.skylords.eu/";
        // private readonly string baseUrl = "https://skylords-reborn-skylords-reborn-api-hub-backend.staging.skylords.eu/"; // NGE04182024 THIS GETS AN OK RESPONSE FROM THE SERVER // "https://cardbase.skylords.eu/";
        private string urlContent = null;

        async Task ReadWebPageAsync(string url)
        {
            var httpClient = new HttpClient();
            var stream = await httpClient.GetStreamAsync(url);

            using var reader = new StreamReader(stream);
            urlContent = reader.ReadToEnd();
            Console.WriteLine(urlContent); // Display the fetched content
        }

        public SMJCard[] GetCardList()
        {
            var url = $"{baseUrl}cards";
            try
            {
                WebClient client = new WebClient();
                string json = client.DownloadString(url);

                Root SMJRoot = JsonConvert.DeserializeObject<Root>(json);
                List<SMJCard> cardlist = SMJRoot.data;
                return cardlist.ToArray();
            }
            catch (Exception ex) // SMJ.cards/api/cards must have changed the JSON!!!!
            {
                return null;
            }
        }

        public SMJCard[] HandleCardRequest(List<Tuple<RequestProperty, string>> requestProperties)
        {
            var url = $"{baseUrl}cards";

            /* // NGE04192024
            for (var index = 0; index < requestProperties.Count; index++)
            {
                var requestProperty = requestProperties[index];
                url +=
                    $"{(index > 0 ? "&" : "")}{Enum.GetName(typeof(RequestProperty), requestProperty.Item1)}={requestProperty.Item2}";
            }
            */

            // Call the method
            // ReadWebPageAsync(url).Wait();

            WebClient client = new WebClient();
            string json = client.DownloadString(url);

            //List<SMJCard> cardlist = new List<SMJCard>();

            Root SMJRoot = JsonConvert.DeserializeObject<Root>(json);
            List<SMJCard> cardlist = SMJRoot.data;
            return cardlist.ToArray();

            //dynamic array = JsonConvert.DeserializeObject(json); 
            //if (array != null && array.data != null) {
            //dynamic cardListDynamic = array.data;
            //    foreach (var item in cardListDynamic) // Collect all card information
            //    {
            //        // Console.WriteLine($"{item}");
            //        SMJCard jobjectInstance = (SMJCard) JObject.FromObject(item);
            //        cardlist.Add(item);
            //    }
            //}
            //return cardlist.ToArray();


            //var webRequest = WebRequest.Create(url);
            //webRequest.ContentType = "application/json; charset=utf-8";
            //var response = webRequest.GetResponse();
            //string text;
            //using (var sr = new StreamReader(response.GetResponseStream()!))
            //{
            //    text = sr.ReadToEnd();
            //}

            //var deserializeObject = JsonConvert.DeserializeObject<APIWrap<Card>>(text);
            //if (deserializeObject.Success != true)
            //    throw new Exception(
            //        $"There has been an error with the API.\n{deserializeObject.Exception.Details}");
            //var cards = deserializeObject.Result;
            //return cards;
        }
    }
}