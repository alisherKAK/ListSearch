using Newtonsoft.Json;

namespace ListSearch
{
    public class PlayRequirements
    {
        [JsonProperty("REQ_MINION_TARGET")]
        public int REQMINIONTARGET { get; set; }

        [JsonProperty("REQ_TARGET_TO_PLAY")]
        public int REQTARGETTOPLAY { get; set; }

        [JsonProperty("REQ_ENEMY_TARGET")]
        public int? REQENEMYTARGET { get; set; }

        [JsonProperty("REQ_TARGET_WITH_RACE")]
        public int? REQTARGETWITHRACE { get; set; }

        [JsonProperty("REQ_MINIMUM_ENEMY_MINIONS")]
        public int? REQMINIMUMENEMYMINIONS { get; set; }

        [JsonProperty("REQ_TARGET_FOR_COMBO")]
        public int? REQTARGETFORCOMBO { get; set; }

        [JsonProperty("REQ_FRIENDLY_TARGET")]
        public int? REQFRIENDLYTARGET { get; set; }

        [JsonProperty("REQ_TARGET_IF_AVAILABLE")]
        public int? REQTARGETIFAVAILABLE { get; set; }

        [JsonProperty("REQ_NUM_MINION_SLOTS")]
        public int? REQNUMMINIONSLOTS { get; set; }

        [JsonProperty("REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS")]
        public int? REQTARGETIFAVAILABLEANDMINIMUMFRIENDLYMINIONS { get; set; }

        [JsonProperty("REQ_MINION_OR_ENEMY_HERO")]
        public int? REQMINIONORENEMYHERO { get; set; }

        [JsonProperty("REQ_STEADY_SHOT")]
        public int? REQSTEADYSHOT { get; set; }

        [JsonProperty("REQ_TARGET_WITH_DEATHRATTLE")]
        public int? REQTARGETWITHDEATHRATTLE { get; set; }

        [JsonProperty("REQ_HAND_NOT_FULL")]
        public int? REQHANDNOTFULL { get; set; }

        [JsonProperty("REQ_FRIENDLY_MINIONS_OF_RACE_DIED_THIS_GAME")]
        public int? REQFRIENDLYMINIONSOFRACEDIEDTHISGAME { get; set; }

        [JsonProperty("REQ_FRIENDLY_MINION_DIED_THIS_GAME")]
        public int? REQFRIENDLYMINIONDIEDTHISGAME { get; set; }

        [JsonProperty("REQ_LEGENDARY_TARGET")]
        public int? REQLEGENDARYTARGET { get; set; }

        [JsonProperty("REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND")]
        public int? REQTARGETIFAVAILABLEANDDRAGONINHAND { get; set; }

        [JsonProperty("REQ_WEAPON_EQUIPPED")]
        public int? REQWEAPONEQUIPPED { get; set; }

        [JsonProperty("REQ_ENEMY_WEAPON_EQUIPPED")]
        public int? REQENEMYWEAPONEQUIPPED { get; set; }

        [JsonProperty("REQ_TARGET_MAX_ATTACK")]
        public int? REQTARGETMAXATTACK { get; set; }

        [JsonProperty("REQ_MINIMUM_TOTAL_MINIONS")]
        public int? REQMINIMUMTOTALMINIONS { get; set; }

        [JsonProperty("REQ_NONSELF_TARGET")]
        public int? REQNONSELFTARGET { get; set; }

        [JsonProperty("REQ_STEALTHED_TARGET")]
        public int? REQSTEALTHEDTARGET { get; set; }

        [JsonProperty("REQ_HERO_TARGET")]
        public int? REQHEROTARGET { get; set; }

        [JsonProperty("REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT")]
        public int? REQMINIONSLOTORMANACRYSTALSLOT { get; set; }

        [JsonProperty("REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY")]
        public int? REQENTIREENTOURAGENOTINPLAY { get; set; }

        [JsonProperty("REQ_UNDAMAGED_TARGET")]
        public int? REQUNDAMAGEDTARGET { get; set; }

        [JsonProperty("REQ_DAMAGED_TARGET")]
        public int? REQDAMAGEDTARGET { get; set; }

        [JsonProperty("REQ_MUST_TARGET_TAUNTER")]
        public int? REQMUSTTARGETTAUNTER { get; set; }

        [JsonProperty("REQ_TARGET_MIN_ATTACK")]
        public int? REQTARGETMINATTACK { get; set; }

        [JsonProperty("REQ_DRAG_TO_PLAY")]
        public int? REQDRAGTOPLAY { get; set; }

        [JsonProperty("REQ_TARGET_EXACT_COST")]
        public int? REQTARGETEXACTCOST { get; set; }

        [JsonProperty("REQ_SECRET_ZONE_CAP_FOR_NON_SECRET")]
        public int? REQSECRETZONECAPFORNONSECRET { get; set; }

        [JsonProperty("REQ_FROZEN_TARGET")]
        public int? REQFROZENTARGET { get; set; }

        [JsonProperty("REQ_MUST_PLAY_OTHER_CARD_FIRST")]
        public int? REQMUSTPLAYOTHERCARDFIRST { get; set; }

        [JsonProperty("REQ_TARGET_IF_AVAILABLE_AND_NO_3_COST_CARD_IN_DECK")]
        public int? REQTARGETIFAVAILABLEANDNO3COSTCARDINDECK { get; set; }

        [JsonProperty("REQ_TARGET_NOT_VAMPIRE")]
        public int? REQTARGETNOTVAMPIRE { get; set; }

        [JsonProperty("REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS")]
        public int? REQTARGETIFAVAILABLEANDMINIMUMFRIENDLYSECRETS { get; set; }

        [JsonProperty("REQ_CANNOT_PLAY_THIS")]
        public int? REQCANNOTPLAYTHIS { get; set; }

        [JsonProperty("REQ_OPPONENT_PLAYED_CARDS_THIS_GAME")]
        public int? REQOPPONENTPLAYEDCARDSTHISGAME { get; set; }

        [JsonProperty("REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN")]
        public int? REQTARGETIFAVAILABEANDELEMENTALPLAYEDLASTTURN { get; set; }
    }
}
