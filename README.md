# SkylordsRebornSMJSLRAPI
A .Net API Implementation for Skylords Reborn API originally cloned from SkylordsRebornAPI

## Example
```csharp
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

```
