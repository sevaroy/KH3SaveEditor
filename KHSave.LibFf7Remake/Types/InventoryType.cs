/*
    Kingdom Hearts Save Editor
    Copyright (C) 2019 Luciano Ciccariello

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using KHSave.Attributes;

namespace KHSave.LibFf7Remake.Types
{
    public enum InventoryType
    {
        [Info("Emtpy")] Empty = 0,
        [Consumable("Potion")] Potion = 1,
        [Consumable("Hi-Potion")] HiPotion,
        [Consumable] Ether,
        [Consumable("Turbo Ether")] TurboEther,
        [Consumable] Elixir,
        [Consumable("Phoenix Down")] PhoenixDown,
        [Consumable] Antidote,
        [Consumable("Echo Mist")] EchoMist,
        [Consumable] Adrenaline,
        [Consumable] Sedative,
        [Consumable] Remedy,
        [Consumable] Celeris,
        [Consumable] Grenade,
        [Consumable] Spiderweb,
        [Consumable("Hazardous Material")] HazardousMaterial,
        [Consumable("Big Bomber")] BigBomber,
        [Consumable("Motolov Cocktail")] MotolovCocktail,
        [Consumable("Orb of Gravity")] OrbOfGravity,
        [Consumable("Smelling Salts")] SmellingSalts,
        [Money("Gil")] Gil,
        [Consumable("Maiden's Kiss")] MaidensKiss,
        [Consumable("Mega-Potion")] MegaPotion,

        [Consumable("AI Programming Core")] AiProgrammingCore = 31,
        [Consumable("Fuzzy Wuzzy")] FuzzyWuzzy,
        [Consumable("Mr. Cuddlesworth")] MrCuddlesWorth,

        [KeyItem("Sector 5 Reactor Card")] Sector5ReactorCard = 100,
        [KeyItem("Tournament Entry Form")] TournamentEntryForm = 102,
        [KeyItem("Madam M's Endorsement")] MadamEndorsement,
        [KeyItem("Andrea Endorsement")] AndreaEndorsement,
        [KeyItem("Shinra ID Card")] ShinraIDCard = 111,

        [KeyItem("Grappling Gun")] GrapplingGun = 115,
        [KeyItem("Grappling Gun")] GrapplingGun2,
        [KeyItem("Key to the Sewers")] KeySewers,
        [Money("Moogle Medal")] MoogleMedal,
        [KeyItem("Sam’s Coin")] SamCoin,
        [KeyItem("Shinra Keycard (59th floor)")] ShinraKeycard59,
        [KeyItem("Hojo's Research Lab Keycard")] HojoResearchLabKeycard,
        [KeyItem("Combat Analyzer")] CombatAnalyzer,
        [KeyItem("Watch Security Key")] WatchSecurityKey,
        [KeyItem("Handmade Necklace")] HandmadeNecklace,
        [KeyItem("Behemoth Horn")] BehemothHorn,
        [KeyItem("Medicinal Flowers")] MedicinalFlowers,
        [KeyItem("Sam's Delivery Lifetime Pass")] SamDeliveryLifetimePass = 132,

        [KeyItem("Madam M’s Requests")] MadamMRequest = 139,
        [KeyItem("Sam's Requests")] SamRequest,
        [KeyItem("The Sauce")] TheSauce,
        [KeyItem("Medicine Voucher")] MedicineVoucher,
        [KeyItem("VIP Card")] VipCard,
        [KeyItem("Yellow Flower")] YellowFlower,

        [KeyItem("Graveyard Key")] GraveyardKey = 148,
        [KeyItem("Guardian Angel’s Calling Cards")] GuardianAngelCallingCards,
        [KeyItem("Vialabrew")] Vialabrew,
        [KeyItem("Crimson Spike")] CrimsonSpike,
        [KeyItem("Bottle of Antiemetic")] BottleOfAntiemetic,
        [KeyItem("Deodorizing Tablets")] DeodorizingTablets,
        [KeyItem("Packets of Antacid")] PacketsOfAntacid,
        [KeyItem("Moogle Membership Card")] MoogleMembershipCard,
        [KeyItem("Gysahl Greens")] GysahlGreens,
        [KeyItem("Doctor's List")] DoctorsList,
        [KeyItem("Moogle's Mortar")] MooglesMortar,
        [KeyItem("Map to the Hideout")] MapToTheHideout,
        [KeyItem("Ruby Tiara")] RubyTiara,
        [KeyItem("Diamond Tiara")] DiamondTiara,
        [KeyItem("Emerald Tiara")] EmeraldTiara,
        [KeyItem("Johnny's Wallet")] JohnnysWallet,
        [KeyItem("Corneo Vault Key")] CorneoVaultKey,
        [KeyItem("Shinra Keycard (60th floor)")] ShinraKeycard60,
        [KeyItem("Shinra Keycard (61st floor)")] ShinraKeycard61,
        [KeyItem("Shinra Keycard (63rd floor)")] ShinraKeycard63,
        [KeyItem("Shinra Executive Keycard (64th floor)")] ShinraExecutiveKeycard,
        [KeyItem("Letter from the Guardian Angel")] LetterFromTheGuardianAngel,
        [KeyItem("Andrea's Earrings")] AndreaEarrings,
        [KeyItem("Real Calling Card")] RealCallingCard,
        [KeyItem("Fake Calling Card")] FakeCallingCard,
        [KeyItem("Corneo Vault Note")] CorneoVaultNote,


        [Armor("Bronze Bangle")] BronzeBangle = 9001,
        [Armor("Iron Bangle")] IronBangle,
        [Armor("Titanium Bangle")] TitaniumBangle,
        [Armor("Gothic Bangle")] GothicBangle,

        [Armor("Leather Bracer")] LeatherBracer = 9007,
        [Armor("Studder Bracer")] StudderBracer,
        [Armor("Heavy-Duty Bracer")] HeavyDutyBracer,

        [Armor("Mesmeric Bracelet")] MesmericBracelet = 9012,
        [Armor("Mythril Bracelet")] MythrilBracelet,
        [Armor("Sorcerer's Bracelet")] SorcererBracelet,

        [Accessory("Power Wristguards")] PowerWristguards = 9017,
        [Accessory("Bulletproof Vest")] BulletproofVest,
        [Accessory("Earrings")] Earrings,
        [Accessory("Talisman")] Talisman,
        [Accessory("Headband")] Headband,
        [Accessory("Star Pendant")] StarPendant,
        [Accessory("Fury Ring")] FuryRing,
        [Accessory("Revival Earrings")] RevivalEarrings,
        [Accessory("Whistlewind Scarf")] WhistlewindScarf,
        [Accessory("Mythical Amulet")] MythicalAmulet,
        [Accessory("Healing Carcanet")] HealingCarcanet,
        [Accessory("Clarity Pendant")] ClarityPendant,
        [Accessory("Transference Module")] TransferenceModule,
        [Accessory("Spectral Cogwheel")] SpectralCogwheel,
        [Accessory("Moogle's Amulet")] MoogleAmulet,
        [Accessory("Enfeeblement Ring")] EnfeeblementRing,
        [Accessory("Crescent Moon Charm")] CrescentMoonCharm,
        [Accessory("Champion Belt")] ChampionBelt,
        [Accessory("Protective Boots")] ProtectiveBoots,
        [Accessory("Circlet")] Circlet,
        [Accessory("Tarot Cards")] TarotCards,
        [Accessory("Otherworldly Crystal")] OtherworldlyCrystal,
        [Accessory("Salvation Badge")] SalvationBadge,
        
        [MagicMateria("Healing")] Healing = 10001,
        [MagicMateria("Cleansing")] Cleansing,
        [MagicMateria("Revival")] Revival,
        [MagicMateria("Fire")] Fire,
        [MagicMateria("Ice")] Ice,
        [MagicMateria("Lightning")] Lightning,
        [MagicMateria("Wind")] Wind,
        [MagicMateria("Poison")] Poison,
        [MagicMateria("Binding")] Binding,
        [MagicMateria("Time")] Time,
        [MagicMateria("Barrier")] Barrier,
        [MagicMateria("Subversion")] Subversion,

        [SupportMateria("Magnify")] Magnify = 11001,
        [SupportMateria("Elemental Materia")] Elemental,
        [SupportMateria("Warding Materia")] Warding,
        [SupportMateria("HP Absorption Materia")] HPAbsorption,
        [SupportMateria("MP Absorption Materia")] MPAbsorption,
        [SupportMateria("Synergy Materia")] Synergy,
        [SupportMateria("AP Up Materia")] APUp,

        [CommandMateria("Steal Materia")] Steal = 12001,
        [CommandMateria("Assess Materia")] Assess,
        [CommandMateria("Enemy Skill Materia")] EnemySkill,
        [CommandMateria("Chakra Materia")] Chakra,
        [CommandMateria("Prayer Materia")] Prayer,
        [CommandMateria("ATB Boost Materia")] ATBBoost,

        [CompleteMateria("HP Up Materia")] HPUp = 13001,
        [CompleteMateria("MP Up Materia")] MPUp,
        [CompleteMateria("Magic Up Materia")] MagicUp,
        [CompleteMateria("Luck Up Materia")] LuckUp,
        [CompleteMateria("Gil Up Materia")] GilUp,
        [CompleteMateria("EXP Up Materia")] EXPUp,
        [CompleteMateria("Item Master Materia")] ItemMaster,
        [CompleteMateria("ATB Stagger Materia")] ATBStagger,
        [CompleteMateria("First Strike Materia")] FirstStrike,
        [CompleteMateria("Steadfast Block Materia")] SteadfastBlock,
        [CompleteMateria("Skill Master Materia")] SkillMaster,
        [CompleteMateria("Deadly Dodge Materia")] DeadlyDodge,
        [CompleteMateria("Parry Materia")] Parry,
        [CompleteMateria("ATB Assist Materia")] ATBAssist,
        [CompleteMateria("Auto-Cure  Materia")] AutoCure,
        [CompleteMateria("Provoke Materia")] Provoke,
        [CompleteMateria("Pedometer Materia")] Pedometer,
        [CompleteMateria("Refocus Materia")] Refocus,

        [SummonMateria("Chocobo & Moogle Materia")] ChocoboAndMoogle = 14001,
        [SummonMateria("Shiva Materia")] Shiva,
        [SummonMateria("Ifrit Materia")] Ifrit,
        [SummonMateria("Leviathan Materia")] Leviathan,
        [SummonMateria("Bahamut Materia")] Bahamut,
        [SummonMateria("Fat Chocobo Materia")] FatChocobo,
        [SummonMateria("Carbuncle Materia")] Carbuncle,
        [SummonMateria("Cactuar Materia")] Cactuar,
        [SummonMateria("Chocobo Chick Materia")] ChocoboChick,
    }
}
