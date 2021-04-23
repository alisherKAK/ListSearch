using Newtonsoft.Json;
using System.Collections.Generic;

namespace ListSearch
{
    public class Card
    {
        [JsonProperty("attack")]
        public int Attack { get; set; }

        [JsonProperty("cardClass")]
        public string CardClass { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("dbfId")]
        public int DbfId { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }

        [JsonProperty("health")]
        public int Health { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("collectible")]
        public bool? Collectible { get; set; }

        [JsonProperty("flavor")]
        public string Flavor { get; set; }

        [JsonProperty("playRequirements")]
        public PlayRequirements PlayRequirements { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("mechanics")]
        public List<string> Mechanics { get; set; }

        [JsonProperty("referencedTags")]
        public List<string> ReferencedTags { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("elite")]
        public bool? Elite { get; set; }

        [JsonProperty("targetingArrowText")]
        public string TargetingArrowText { get; set; }

        [JsonProperty("durability")]
        public int? Durability { get; set; }

        [JsonProperty("overload")]
        public int? Overload { get; set; }

        [JsonProperty("spellDamage")]
        public int? SpellDamage { get; set; }

        [JsonProperty("collectionText")]
        public string CollectionText { get; set; }

        [JsonProperty("armor")]
        public int? Armor { get; set; }

        [JsonProperty("entourage")]
        public List<string> Entourage { get; set; }

        [JsonProperty("puzzleType")]
        public int? PuzzleType { get; set; }

        [JsonProperty("hideStats")]
        public bool? HideStats { get; set; }

        [JsonProperty("howToEarn")]
        public string HowToEarn { get; set; }

        [JsonProperty("howToEarnGolden")]
        public string HowToEarnGolden { get; set; }

        [JsonProperty("classes")]
        public List<string> Classes { get; set; }

        [JsonProperty("multiClassGroup")]
        public string MultiClassGroup { get; set; }

        [JsonProperty("questReward")]
        public string QuestReward { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
