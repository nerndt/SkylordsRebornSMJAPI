using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SkylordsRebornAPI;
using SkylordsRebornAPI.Cardbase;
using SkylordsRebornAPI.Cardbase.Cards;
using System.Linq;
using System.Diagnostics;
using static SkylordsRebornAPI.Cardbase.GenerateRandomCardDeck;

namespace Sample1
{
    internal static class Program
    {
        private static readonly JsonSerializerSettings Settings = new()
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            Formatting = Formatting.Indented,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new StringEnumConverter()
            }
        };

        public static SMJCard? GetCardFromOfficialCardId(SMJCard[]? cardsSMJ, int cardId)
        {
            if (cardsSMJ != null)
            {
                SMJCard[] cards = (SMJCard[])cardsSMJ;
                foreach (SMJCard card in cards)
                {
                    var result = card.officialCardIds.FirstOrDefault(i => i == cardId);
                    if (result != 0)
                    {
                        return card;
                    }
                }
            }
            return null;
        }

        private static void Main()
        {
            SMJCard[] cardsSMJ = Instances.CardService.GetSMJCardList();
            string message = string.Format("Number of cards in SMJ.cards api:{0}", cardsSMJ.Count());
            Console.WriteLine(message);

            // Use LINQ commands to get specific cards - for example get MasterArchers

            var queryCards = cardsSMJ.Where(item => item.cardName == "Wheel of Gifts"); // "Master Archers"); "Wheel of Gifts" "Shaman"
            SMJCard queryCard = queryCards.FirstOrDefault();

            if (queryCard != null)
            {
                var quryCardType = queryCard.type;
            }

            SkylordsRebornCard[] cardsSLR = Instances.CardService.GetSkylordsRebornCardList();
            message = string.Format("Number of cards in SkylordsReborn api:{0}", cardsSLR.Count());
            Console.WriteLine(message);
            
            // Use LINQ commands to get specific cards - for example get MasterArchers

            var queryCardsSLR = cardsSLR.Where(item => item.cardName == "Wheel of Gifts"); // "Master Archers"); "Wheel of Gifts" "Shaman"
            SkylordsRebornCard queryCardSLR = queryCardsSLR.FirstOrDefault(); // If multiple cards are returned, take the first one

            if (queryCardSLR != null)
            {
                var quryCardType = queryCardSLR.cardType;
            }

            // Try to Generate a Random card deck and pass 
            GenerateRandomDeckProps props = new GenerateRandomDeckProps();
            props.OrbsOrder = new List<int> { 2, 3, 2, 1 }; // Fire 0, Shadow 1, Nature 2, Frost 3
            props.Neutrals = false;
            props.Duplicates = true;
            List<SMJCard> deck = GenerateRandomDeck(cardsSMJ, props);
            string randomDeckInputString = string.Format("/importdeck [{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19}]",
                deck[0].officialCardIds[0],
                deck[1].officialCardIds[0],
                deck[2].officialCardIds[0],
                deck[3].officialCardIds[0],
                deck[4].officialCardIds[0],
                deck[5].officialCardIds[0],
                deck[6].officialCardIds[0],
                deck[7].officialCardIds[0],
                deck[8].officialCardIds[0],
                deck[9].officialCardIds[0],
                deck[10].officialCardIds[0],
                deck[11].officialCardIds[0],
                deck[12].officialCardIds[0],
                deck[13].officialCardIds[0],
                deck[14].officialCardIds[0],
                deck[15].officialCardIds[0],
                deck[16].officialCardIds[0],
                deck[17].officialCardIds[0],
                deck[18].officialCardIds[0],
                deck[19].officialCardIds[0]
                );
            Console.WriteLine(randomDeckInputString);

            int unitPower = 75; // Nomad power cost - should be able to find info about card

            SMJCard? card = GetCardFromOfficialCardId(cardsSMJ, deck[0].officialCardIds[0]);
            if (card != null)
            {
                unitPower = card.powerCost[3]; // Assume unit fully upgraded for now!!!!
                Console.WriteLine("Found Card Name:{0} Power Cost:{1}", card.cardName, unitPower);
            }

        }
    }
}