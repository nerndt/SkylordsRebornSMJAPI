# SkylordsRebornSMJSLRAPI
A .Net API Implementation for Skylords Reborn API originally cloned from SkylordsRebornAPI
Retrieves information from both  "https://smj.cards/api/" and "https://hub.backend.skylords.eu/api/"
The Sample1 project extracts all "Skylords Reborn" game card information from both sites and puts them in C# classes that can then be queried quickly by LINQ commands
I have also added a deck generator to this project that will make a deck given the orb selections specified in the line before the function call

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
