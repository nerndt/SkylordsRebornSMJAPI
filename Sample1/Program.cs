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
            SMJCard[] cards = Instances.CardService.GetCardList();
            // Use LINQ commands to get specific cards - for example get MasterArchers

            var queryCards = cards.Where(item => item.cardName == "Wheel of Gifts"); // "Master Archers"); "Wheel of Gifts" "Shaman"
            SMJCard queryCard = queryCards.FirstOrDefault();

            if (queryCard != null)
            {
                var quryCardType = queryCard.type;
            }

        }
    }
}