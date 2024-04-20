using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SkylordsRebornAPI;
using SkylordsRebornAPI.Cardbase;
using SkylordsRebornAPI.Cardbase.Cards;
using System.Linq;
using System.Diagnostics;

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

        private static void Main()
        {
            SMJCard[] cardsSMJ = Instances.CardService.GetSMJCardList();
            // Use LINQ commands to get specific cards - for example get MasterArchers

            var queryCards = cardsSMJ.Where(item => item.cardName == "Wheel of Gifts"); // "Master Archers"); "Wheel of Gifts" "Shaman"
            SMJCard queryCard = queryCards.FirstOrDefault();

            if (queryCard != null)
            {
                var quryCardType = queryCard.type;
            }

            SkylordsRebornCard[] cardsSLR = Instances.CardService.GetSkylordsRebornCardList();
            // Use LINQ commands to get specific cards - for example get MasterArchers

            var queryCardsSLR = cardsSLR.Where(item => item.cardName == "Wheel of Gifts"); // "Master Archers"); "Wheel of Gifts" "Shaman"
            SkylordsRebornCard queryCardSLR = queryCardsSLR.FirstOrDefault(); // If multiple cards are returned, take the first one

            if (queryCardSLR != null)
            {
                var quryCardType = queryCardSLR.cardType;
            }
        }
    }
}