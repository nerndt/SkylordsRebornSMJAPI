// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
// Entered "https://smj.cards/api/cards" in a web browser
// copied the contents into https://json2csharp.com/
// Copied the class output to here

using Newtonsoft.Json;
using System.Collections.Generic;

namespace SkylordsRebornAPI.Cardbase
{
    public class Ability
    {
        public string abilityIdentifier { get; set; }
        public string abilityName { get; set; }
        public int abilityType { get; set; }
        public int abilityAffinity { get; set; }
        public List<bool> abilityAvailability { get; set; }
        public bool abilityHidden { get; set; }
        public List<int> abilityStars { get; set; }
        public string abilityDescription { get; set; }
        public List<List<string>> abilityDescriptionValues { get; set; }
        public List<int> abilityCost { get; set; }
    }

    public class AbilityAffinity
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    public class AbilityType
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    public class Affinity
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    public class AttackType
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    public class Boosters
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }

        [JsonProperty("5")]
        public string _5 { get; set; }

        [JsonProperty("6")]
        public string _6 { get; set; }

        [JsonProperty("7")]
        public string _7 { get; set; }

        [JsonProperty("8")]
        public string _8 { get; set; }

        [JsonProperty("9")]
        public string _9 { get; set; }

        [JsonProperty("-3")]
        public string _minus3 { get; set; }

        [JsonProperty("-2")]
        public string _minus2 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    public class BuildingClass
    {
        [JsonProperty("~")]
        public string building { get; set; }

    }

    public class Color
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }

        [JsonProperty("5")]
        public string _5 { get; set; }

        [JsonProperty("6")]
        public string _6 { get; set; }

        [JsonProperty("7")]
        public string _7 { get; set; }

        [JsonProperty("8")]
        public string _8 { get; set; }

        [JsonProperty("9")]
        public string _9 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    public class SMJCard
    {
        public string _id { get; set; }
        public string cardSlug { get; set; }
        public string cardName { get; set; }
        public string cardNameSimple { get; set; }
        public string cardNameImage { get; set; }
        public List<int> officialCardIds { get; set; }
        public string description { get; set; }
        public int edition { get; set; }
        public int color { get; set; }
        public int promo { get; set; }
        public int rarity { get; set; }
        public int orbsTotal { get; set; }
        public int orbsNeutral { get; set; }
        public int orbsFire { get; set; }
        public int orbsShadow { get; set; }
        public int orbsNature { get; set; }
        public int orbsFrost { get; set; }
        public int orbsFireShadow { get; set; }
        public int orbsNatureFrost { get; set; }
        public int orbsFireNature { get; set; }
        public int orbsShadowFrost { get; set; }
        public int orbsShadowNature { get; set; }
        public int orbsFireFrost { get; set; }
        public int affinity { get; set; }
        public int type { get; set; }
        public string unitModel { get; set; }
        public string category { get; set; }
        public string unitSpecies { get; set; }
        public string unitClass { get; set; }
        public string buildingClass { get; set; }
        public string spellClass { get; set; }
        public int gender { get; set; }
        public int movementType { get; set; }
        public int attackType { get; set; }
        public int offenseType { get; set; }
        public int defenseType { get; set; }
        public int maxCharges { get; set; }
        public int squadSize { get; set; }
        public int starterCard { get; set; }
        public List<int> powerCost { get; set; }
        public List<int> damage { get; set; }
        public List<int> health { get; set; }
        public List<int> boosters { get; set; }
        public List<string> upgradeMaps { get; set; }
        public List<Ability> abilities { get; set; }
    }

    public class DefenseType
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    //public enum Edition
    //{
    //    Twilight = 1,
    //    Renegade = 2,
    //    LostSouls = 4,
    //    Amii = 8
    //}

    public class Edition
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Enums
    {
        public Edition edition { get; set; }
        public Color color { get; set; }
        public Promo promo { get; set; }
        public Rarity rarity { get; set; }
        public Affinity affinity { get; set; }
        public Type type { get; set; }
        public Gender gender { get; set; }
        public MovementType movementType { get; set; }
        public AttackType attackType { get; set; }
        public OffenseType offenseType { get; set; }
        public DefenseType defenseType { get; set; }
        public SquadSize squadSize { get; set; }
        public StarterCard starterCard { get; set; }
        public Boosters boosters { get; set; }
        public UpgradeMaps upgradeMaps { get; set; }
        public AbilityType abilityType { get; set; }
        public AbilityAffinity abilityAffinity { get; set; }
        public UnitModel unitModel { get; set; }
        public UnitSpecies unitSpecies { get; set; }
        public UnitClass unitClass { get; set; }
        public BuildingClass buildingClass { get; set; }
        public SpellClass spellClass { get; set; }
        public MaxCharges maxCharges { get; set; }
    }

    public class Gender
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    public class MaxCharges
    {
        [JsonProperty("4")]
        public List<int> _4 { get; set; }

        [JsonProperty("8")]
        public List<int> _8 { get; set; }

        [JsonProperty("12")]
        public List<int> _12 { get; set; }

        [JsonProperty("16")]
        public List<int> _16 { get; set; }

        [JsonProperty("20")]
        public List<int> _20 { get; set; }

        [JsonProperty("24")]
        public List<int> _24 { get; set; }
    }

    public class MovementType
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    public class OffenseType
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    public class Promo
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }
    }

    public class Rarity
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }
    }

    public class Root
    {
        public bool success { get; set; }
        public Enums enums { get; set; }
        public List<SMJCard> data { get; set; }
    }

    public class SpellClass
    {
        [JsonProperty("~")]
        public string spellClass { get; set; }

    }

    public class SquadSize
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }

        [JsonProperty("6")]
        public string _6 { get; set; }

        [JsonProperty("-1")]
        public string _minus1 { get; set; }
    }

    public class StarterCard
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }
    }

    public class Type
    {
        [JsonProperty("0")]
        public string _0 { get; set; }

        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }
    }

    public class UnitClass
    {
        [JsonProperty("~")]
        public string unitClass { get; set; }
    }

    public class UnitModel
    {
        [JsonProperty("~")]
        public string unitModel { get; set; }
    }

    public class UnitSpecies
    {
        [JsonProperty("~")]
        public string unitSpecies { get; set; }
    }

    public class UpgradeMaps
    {
        [JsonProperty("0-0")]
        public string _00 { get; set; }

        [JsonProperty("1-1")]
        public string _11 { get; set; }

        [JsonProperty("1-2")]
        public string _12 { get; set; }

        [JsonProperty("1-3")]
        public string _13 { get; set; }

        [JsonProperty("1-4")]
        public string _14 { get; set; }

        [JsonProperty("1-5")]
        public string _15 { get; set; }

        [JsonProperty("1-6")]
        public string _16 { get; set; }

        [JsonProperty("1-7")]
        public string _17 { get; set; }

        [JsonProperty("1-8")]
        public string _18 { get; set; }

        [JsonProperty("1-9")]
        public string _19 { get; set; }

        [JsonProperty("2-1")]
        public string _21 { get; set; }

        [JsonProperty("2-2")]
        public string _22 { get; set; }

        [JsonProperty("2-3")]
        public string _23 { get; set; }

        [JsonProperty("2-4")]
        public string _24 { get; set; }

        [JsonProperty("2-5")]
        public string _25 { get; set; }

        [JsonProperty("2-6")]
        public string _26 { get; set; }

        [JsonProperty("2-7")]
        public string _27 { get; set; }

        [JsonProperty("4-1")]
        public string _41 { get; set; }

        [JsonProperty("4-2")]
        public string _42 { get; set; }

        [JsonProperty("4-3")]
        public string _43 { get; set; }

        [JsonProperty("4-4")]
        public string _44 { get; set; }

        [JsonProperty("4-5")]
        public string _45 { get; set; }

        [JsonProperty("4-6")]
        public string _46 { get; set; }

        [JsonProperty("4-7")]
        public string _47 { get; set; }

        [JsonProperty("4-8")]
        public string _48 { get; set; }
    }
}
