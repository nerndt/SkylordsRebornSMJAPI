using System;
using System.Dynamic;
using System.Linq;
using Newtonsoft.Json;
using SkylordsRebornAPI;
using SkylordsRebornAPI.Auction;
using SkylordsRebornAPI.Cardbase;

namespace Sample2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var requestBody = new RequestBody
            {
                Input = "Shaman",
                Min = 0,
                Max = 1000
            };
            Console.WriteLine($"Amount of auctions: {Instances.AuctionService.GetAmountOfAuctions(requestBody)}");
            // NGE04202024 Does not work!!!!! var cardInfo = Instances.AuctionService.GetCardInfo(CardId.Batariel);
            // NGE04202024 Does not work!!!!! var nameOfCard = Enum.GetName(typeof(CardId), CardId.Batariel);
            // NGE04202024 Does not work!!!!! Console.WriteLine($"Card Info {nameOfCard}: \n{JsonConvert.SerializeObject(cardInfo)}");

            SkylordsRebornCard[] cardsSLR = Instances.CardService.GetSkylordsRebornCardList(); // Get all cards in game
            // Use LINQ commands to get specific cards - for example get MasterArchers

            var queryCardsSLR = cardsSLR.Where(item => item.cardId == (int)CardId.Batariel); // "Master Archers"); "Wheel of Gifts" "Shaman"
            SkylordsRebornCard queryCardSLR = queryCardsSLR.FirstOrDefault(); // If multiple cards are returned, take the first one

            var nameOfCard = Enum.GetName(typeof(CardId), CardId.Batariel);
            Console.WriteLine($"Card Info {nameOfCard}: \n{JsonConvert.SerializeObject(queryCardSLR)}");
            
            var auctionEntries = Instances.AuctionService.GetAuctionEntriesOfPage(1, 30, requestBody);
            var firstOrDefaultEntry = auctionEntries.FirstOrDefault();
            Console.WriteLine($"AuctionEntry: {JsonConvert.SerializeObject(firstOrDefaultEntry)}");
            if (firstOrDefaultEntry != null)
                Console.WriteLine(
                    $"Specific AuctionEntry: {JsonConvert.SerializeObject(Instances.AuctionService.GetAuctionEntryInfo((int) firstOrDefaultEntry.AuctionId))}");
        }
    }
}