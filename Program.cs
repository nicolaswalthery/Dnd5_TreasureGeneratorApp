using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Dnd5_TreasureGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region The CODE WRITER AREA
            /// <EXPLANATION> on how codeCreator is working here !
            /// 1*] codeWriterItemTableI is instanciated with the adresse of the file (default file) where the content 
            ///     must be taken: name of the object ( object's name or description, number of time it appears in the table).
            /// 2*] Next, codeWriterItemTableI.CodeCreator is used to generate the code and write it in a .txt file which file path is specified 
            ///     in the first parameter of codeWriterItemTableI.CodeCreator().
            ///     (normally in the default file location is named: "Default_Content").
            /// </EXPLANATION>

            /// 1*]
            Table_Manager codeWriterItemTableI = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Magic_Item_Tables\Table_I.txt");
            /// 2*]
            codeWriterItemTableI.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Magic_Item_Tables", @"Table_I.txt", "magicItemTableI");
            

            //GEMSTONES CODEWRITER
            Table_Manager codeWriterGem10 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\Gemstones_10GP.txt");
            codeWriterGem10.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\", @"Gemstones_10GPcode.txt", "gemstones10");

            Table_Manager codeWriterGem50 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\Gemstones_50GP.txt");
            codeWriterGem50.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\", @"Gemstones_50GPcode.txt", "gemstones50");

            Table_Manager codeWriterGem100 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\Gemstones_100GP.txt");
            codeWriterGem100.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\", @"Gemstones_100GPcode.txt", "gemstones100");

            Table_Manager codeWriterGem500 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\Gemstones_500GP.txt");
            codeWriterGem500.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\", @"Gemstones_500GPcode.txt", "gemstones500");

            Table_Manager codeWriterGem1000 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\Gemstones_1000GP.txt");
            codeWriterGem1000.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\", @"Gemstones_1000GPcode.txt", "gemstones1000");

            Table_Manager codeWriterGem5000 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\Gemstones_5000GP.txt");
            codeWriterGem5000.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Gemstones_Tables\", @"Gemstones_5000GPcode.txt", "gemstones5000");
            

            //ART OBJECTS CODEWRITER
            Table_Manager codeWriterArtObject25 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Art_Objects_Tables\Art_Objects_25GP.txt");
            codeWriterArtObject25.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Art_Objects_Tables\", @"Art_Objects_25GPcode.txt", "artObject25");

            Table_Manager codeWriterArtObject250 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Art_Objects_Tables\Art_Objects_250GP.txt");
            codeWriterArtObject250.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Art_Objects_Tables\", @"Art_Objects_250GPcode.txt", "artObject250");

            Table_Manager codeWriterArtObject750 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Art_Objects_Tables\Art_Objects_750GP.txt");
            codeWriterArtObject750.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Art_Objects_Tables\", @"Art_Objects_750GPcode.txt", "artObject750");

            Table_Manager codeWriterArtObject2500 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Art_Objects_Tables\Art_Objects_2500GP.txt");
            codeWriterArtObject2500.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Art_Objects_Tables\", @"Art_Objects_2500GPcode.txt", "artObject2500");

            Table_Manager codeWriterArtObject7500 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Art_Objects_Tables\Art_Objects_7500GP.txt");
            codeWriterArtObject7500.CodeCreator(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Art_Objects_Tables\", @"Art_Objects_7500GPcode.txt", "artObject7500");

            #endregion

            #region  The Dnd5e tables: INDIVIDUAL TREASURE. (.TXT)

            //==INDIVIDUAL TREASURES TABLES 
            //CR 0-4                            [Dnd5e]
            Table_Manager individualTreasureCR0_4 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Individual_Treasure\Individual_Treasure_CR0-4.txt");

            individualTreasureCR0_4.DeleteAll();
            individualTreasureCR0_4.AddLine("3d6 (10) CP ;", 30);
            individualTreasureCR0_4.AddLine("4d6 (14) SP ;", 30);
            individualTreasureCR0_4.AddLine("3d6 (10) EP ;", 10);
            individualTreasureCR0_4.AddLine("3d6 (10) GP ;", 15);
            individualTreasureCR0_4.AddLine("ld6 (3) PP ;", 5);

            //CR 5-10                            [Dnd5e]
            Table_Manager individualTreasureCR5_10 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Individual_Treasure\Individual_Treasure_CR5-10.txt");

            individualTreasureCR5_10.DeleteAll();
            individualTreasureCR5_10.AddLine("4d6 x 100 (l ,400) CP and ld6 x 10 (35) EP ;", 30);
            individualTreasureCR5_10.AddLine("6d6 x 10 (210) SP and 2d6 x 10 (70) GP ;", 30);
            individualTreasureCR5_10.AddLine("3d6 x 10 (105) EP and 2d6 x 10 (70) GP ;", 10);
            individualTreasureCR5_10.AddLine("4d6 x 10 (140) GP ;", 15);
            individualTreasureCR5_10.AddLine("2d6 x 10 (70) GP and 3d6 (10) PP ;", 15);

            //CR 11-16                            [Dnd5e]
            Table_Manager individualTreasureCR11_16 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Individual_Treasure\Individual_Treasure_CR11-16.txt");

            individualTreasureCR11_16.DeleteAll();
            individualTreasureCR11_16.AddLine("4d6 x l 00 (l ,400) SP and ld6 x 100 (350) GP ;", 20);
            individualTreasureCR11_16.AddLine("ld6 x 1 00 (350) EP and ld6 x 1 00 (350) GP ;", 15);
            individualTreasureCR11_16.AddLine("2d6 x 100 (700) GP and ld6 x 10 (35) PP ;", 40);
            individualTreasureCR11_16.AddLine("2d6 x 100 (700)  GP and 2d6 x 10 (70)  PP ;", 25);

            //CR 17+                              [Dnd5e]
            Table_Manager individualTreasureCR17plus = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Individual_Treasure\Individual_Treasure_CR17+.txt");

            individualTreasureCR17plus.DeleteAll();
            individualTreasureCR17plus.AddLine("2d6 x 1 ,000 (7,000) EP and 8d6 x 1 00 (2,800) GP ;", 15);
            individualTreasureCR17plus.AddLine("ld6 x 1 ,000 (3,500) GP and ld6 x 1 00 (350) PP ;", 40);
            individualTreasureCR17plus.AddLine("ld6 x 1 ,000 (3,500) GP and 2d6 x 1 00 (700) PP ;", 45);

            #endregion

            #region  The Dnd5e tables: MAGIC ITEM TABLES. (.TXT)

            //TABLE A
            Table_Manager magicItemTableA = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Magic_Item_Tables\Table_A.txt");

            magicItemTableA.DeleteAll();
            magicItemTableA.AddLine("Potion of healing;", 50);
            magicItemTableA.AddLine("Spell scroll (cantrip);", 10);
            magicItemTableA.AddLine("Potion of climbing;", 10);
            magicItemTableA.AddLine("Spell scroll (1st level);", 20);
            magicItemTableA.AddLine("Spell scroll (2nd level);", 5);
            magicItemTableA.AddLine("Potion of greater healing;", 4);
            magicItemTableA.AddLine("Bag of holding;", 1);
            magicItemTableA.AddLine("Driftglobe;", 1);

            //TABLE B
            Table_Manager magicItemTableB = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Magic_Item_Tables\Table_B.txt");
            magicItemTableB.DeleteAll();
            magicItemTableB.AddLine("Potion of greater healing;",15);
            magicItemTableB.AddLine("Potion of fire breath;", 7);
            magicItemTableB.AddLine("Potion of resistance;",7);
            magicItemTableB.AddLine("Ammunition, +l;", 5);
            magicItemTableB.AddLine("Potion of animal friendship;", 5);
            magicItemTableB.AddLine("Potion of hill giant strength;", 5);
            magicItemTableB.AddLine("Potion of growth;",5);
            magicItemTableB.AddLine("Potion of water breathing;", 5);
            magicItemTableB.AddLine("Spell scroll (2nd level);",5);
            magicItemTableB.AddLine("Spell scroll (3rd level);",5);
            magicItemTableB.AddLine("Bag of holding;",3);
            magicItemTableB.AddLine("Keoghtom's ointment;",3);
            magicItemTableB.AddLine("Oil of slipperiness;", 3);
            magicItemTableB.AddLine("Dust of disappearance;", 2);
            magicItemTableB.AddLine("Dust of dryness;", 2);
            magicItemTableB.AddLine("Dust of sneezing and choking;", 2);
            magicItemTableB.AddLine("Elemental gem;",2);
            magicItemTableB.AddLine("Philter of love;", 2);
            magicItemTableB.AddLine("Alchemy jug;",1);
            magicItemTableB.AddLine("Cap of water breathing;",1);
            magicItemTableB.AddLine("Cloak of the manta ray;",1);
            magicItemTableB.AddLine("Driftglobe;",1);
            magicItemTableB.AddLine("Goggles of night;",1);
            magicItemTableB.AddLine("Helm of comprehending languages;",1);
            magicItemTableB.AddLine("Immovable rod;",1);
            magicItemTableB.AddLine("Lantern of revealing;",1);
            magicItemTableB.AddLine("Mariner's armor;",1);
            magicItemTableB.AddLine("Mithral armor;",1);
            magicItemTableB.AddLine("Potion of poison;",1);
            magicItemTableB.AddLine("Ring of swimming;",1);
            magicItemTableB.AddLine("Robe of useful items;",1);
            magicItemTableB.AddLine("Rope of climbing;",1);
            magicItemTableB.AddLine("Saddle of the cavalier;",1);
            magicItemTableB.AddLine("Wand of magic detection;",1);
            magicItemTableB.AddLine("Wand of secrets;",1);

            //TABLE C
            Table_Manager magicItemTableC = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Magic_Item_Tables\Table_C.txt");
            magicItemTableC.DeleteAll();
            magicItemTableC.AddLine("Potion of superior healing;",15);
            magicItemTableC.AddLine("Spell scroll (4th level);",7);
            magicItemTableC.AddLine("Ammunition, +2;",5);
            magicItemTableC.AddLine("Potion of clairvoyance;",5);
            magicItemTableC.AddLine("Potion of diminution;", 5);
            magicItemTableC.AddLine("Potion of gaseous form;", 5);
            magicItemTableC.AddLine("Potion of frost giant strength;",5);
            magicItemTableC.AddLine("Potion of stone giant strength;", 5);
            magicItemTableC.AddLine("Potion of heroism;",5);
            magicItemTableC.AddLine("Potion of invulnerabil ity;", 5);
            magicItemTableC.AddLine("Potion of mind reading;",5);
            magicItemTableC.AddLine("Spell scroll (5th level);",5);
            magicItemTableC.AddLine("Elixir of health;",3);
            magicItemTableC.AddLine("Oil of etherealness;",3);
            magicItemTableC.AddLine("Potion of fire giant strength;",3);
            magicItemTableC.AddLine("Quaal's feather token;",3);
            magicItemTableC.AddLine("Scroll of protection;",3);
            magicItemTableC.AddLine("Bag of beans;",2);
            magicItemTableC.AddLine("Bead of force;",2);
            magicItemTableC.AddLine("Chime of opening;",1);
            magicItemTableC.AddLine("Decanter of endless water;",1);
            magicItemTableC.AddLine("Eyes of minute seeing;",1);
            magicItemTableC.AddLine("Folding boat;",1);
            magicItemTableC.AddLine("Heward's handy haversack;",1);
            magicItemTableC.AddLine("Horseshoes of speed;",1);
            magicItemTableC.AddLine("Necklace of fireballs;",1);
            magicItemTableC.AddLine("Peria pt of health;",1);
            magicItemTableC.AddLine("Sending stones;",1);


            //TABLE D
            Table_Manager magicItemTableD = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Magic_Item_Tables\Table_D.txt");
            magicItemTableD.DeleteAll();
            magicItemTableD.AddLine("Potion of supreme healing;",20);
            magicItemTableD.AddLine("Potion of invisibi lity;",10);
            magicItemTableD.AddLine("Potion of speed;",10);
            magicItemTableD.AddLine("Spell scroll (6th level);",10);
            magicItemTableD.AddLine("Spell scroll (7th level) ;",7);
            magicItemTableD.AddLine("Ammunition, +3;",5);
            magicItemTableD.AddLine("Oil of sharpness;",5);
            magicItemTableD.AddLine("Potion of flying;",5);
            magicItemTableD.AddLine("Potion of cloud giant strength;",5);
            magicItemTableD.AddLine("Potion of longevity;",5);
            magicItemTableD.AddLine("Potion of vitality;",5);
            magicItemTableD.AddLine("Spell scroll (8th level);",5);
            magicItemTableD.AddLine("Horseshoes of a zephyr;",3);
            magicItemTableD.AddLine("Nolzur's marvelous pigments;",3);
            magicItemTableD.AddLine("Bag of devouring;",1);
            magicItemTableD.AddLine("Portable hole;",1);


            //TABLE E
            Table_Manager magicItemTableE = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Magic_Item_Tables\Table_E.txt");
            magicItemTableE.DeleteAll();
            magicItemTableE.AddLine("Spell scroll (8th level);",30);
            magicItemTableE.AddLine("Potion of storm giant strength;",15);
            magicItemTableE.AddLine("Potion of supreme healing;",15);
            magicItemTableE.AddLine("Spell scroll (9th level);",15);
            magicItemTableE.AddLine("Universal solvent;",8);
            magicItemTableE.AddLine("Arrow of slaying;",5);
            magicItemTableE.AddLine("Sovereign glue;",2);

            //TABLE F
            Table_Manager magicItemTableF = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Magic_Item_Tables\Table_F.txt");
            magicItemTableF.DeleteAll();
            magicItemTableF.AddLine("Weapon, +l;", 15);
            magicItemTableF.AddLine("Shield, +;",3);
            magicItemTableF.AddLine("Sentinel shield;",3);
            magicItemTableF.AddLine("Amulet of proof against detection and location;",2);
            magicItemTableF.AddLine("Boots of elvenkind;",2);
            magicItemTableF.AddLine("Boots of striding and springing;",2);
            magicItemTableF.AddLine("Bracers of archery;",2);
            magicItemTableF.AddLine("Brooch of shielding;",2);
            magicItemTableF.AddLine("Broom of flying;",2);
            magicItemTableF.AddLine("Cloak of elven kind;",2);
            magicItemTableF.AddLine("Cloak of protection;",2);
            magicItemTableF.AddLine("Gauntlets of ogre power;",2);
            magicItemTableF.AddLine("Hat of disguise;",2);
            magicItemTableF.AddLine("Javel in of lightning;",2);
            magicItemTableF.AddLine("Pearl of power;",2);
            magicItemTableF.AddLine("Rod of the pact keeper, +1;",2);
            magicItemTableF.AddLine("Slippers of spider climbing;",2);
            magicItemTableF.AddLine("Staff of the adder;",2);
            magicItemTableF.AddLine("Staff of the python;",2);
            magicItemTableF.AddLine("Sword of vengeance;",2);
            magicItemTableF.AddLine("Trident of fish command;",2);
            magicItemTableF.AddLine("Wand of magic missiles;",2);
            magicItemTableF.AddLine("Wand of the war mage, + ;",2);
            magicItemTableF.AddLine("Wand of web;",2);
            magicItemTableF.AddLine("Weapon of warning;",2);
            magicItemTableF.AddLine("Adamantine armor (chain mail);",2);
            magicItemTableF.AddLine("Adamantine armor (chain shirt);",2);
            magicItemTableF.AddLine("Adamantine armor (scale mail);",2);
            magicItemTableF.AddLine("Bag of tricks (gray);",1);
            magicItemTableF.AddLine("Bag of tricks (rust);",1);
            magicItemTableF.AddLine("Bag of tricks (tan);", 1);
            magicItemTableF.AddLine("Boots of the winterlands;", 1);
            magicItemTableF.AddLine("Circlet of blasting;", 1);
            magicItemTableF.AddLine("Deck of illusions;", 1);
            magicItemTableF.AddLine("Eversmoking bottle;", 1);
            magicItemTableF.AddLine("Eyes of charming;", 1);
            magicItemTableF.AddLine("Eyes of the eagle;", 1);
            magicItemTableF.AddLine("Figurine of wondrous power (silver raven);", 1);
            magicItemTableF.AddLine("Gem of brightness;", 1);
            magicItemTableF.AddLine("Gloves of missile snaring;", 1);
            magicItemTableF.AddLine("Gloves of swimming and climbing;", 1);
            magicItemTableF.AddLine("Gloves of thievery;", 1);
            magicItemTableF.AddLine("Headband of intellect;", 1);
            magicItemTableF.AddLine("Helm of telepathy;", 1);
            magicItemTableF.AddLine("Instrument of the bards (Doss l ute;", 1);
            magicItemTableF.AddLine("Instrument of the bards (Fochlucan bandore);", 1);
            magicItemTableF.AddLine("Instrument of the bards (Mac- Fuimidh cittern);", 1);
            magicItemTableF.AddLine("Medallion of thoughts;", 1);
            magicItemTableF.AddLine("Necklace of adaptation;", 1);
            magicItemTableF.AddLine("Periapt of wound closure;", 1);
            magicItemTableF.AddLine("Pipes of haunting;", 1);
            magicItemTableF.AddLine("Pipes of the sewers;", 1);
            magicItemTableF.AddLine("Ring of jumping;", 1);
            magicItemTableF.AddLine("Ring of mind shielding;", 1);
            magicItemTableF.AddLine("Ring of warmth;", 1);
            magicItemTableF.AddLine("Ring of water walking;", 1);
            magicItemTableF.AddLine("Quiver of Ehlonna;", 1);
            magicItemTableF.AddLine("Stone of good luck;", 1);
            magicItemTableF.AddLine("Wind fan;", 1);
            magicItemTableF.AddLine("Winged boots;", 1);

            //TABLE G
            Table_Manager magicItemTableG = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Magic_Item_Tables\Table_G.txt");
            SpecificItemPicker figurine = new SpecificItemPicker();
            magicItemTableG.DeleteAll();
            magicItemTableG.AddLine("Weapon, +2;",11);
            magicItemTableG.AddLine(figurine.FigPicker(), 2);
            magicItemTableG.AddLine("Adamantine armor (breastplate);", 1);
            magicItemTableG.AddLine("Adamantine armor (splint);", 1);
            magicItemTableG.AddLine("Amulet of health;", 1);
            magicItemTableG.AddLine("Armor of vulnerability;", 1);
            magicItemTableG.AddLine("Arrow-catching shield;", 1);
            magicItemTableG.AddLine("Belt of dwarvenkind;", 1);
            magicItemTableG.AddLine("Belt of hill giant strength;", 1);
            magicItemTableG.AddLine("Berserker axe;", 1);
            magicItemTableG.AddLine("Boots of levitation;", 1);
            magicItemTableG.AddLine("Boots of speed;", 1);
            magicItemTableG.AddLine("Bowl of commanding water elementals;", 1);
            magicItemTableG.AddLine("Bracers of defense;", 1);
            magicItemTableG.AddLine("Brazier of commanding fire elementals;", 1);
            magicItemTableG.AddLine("Cape of the mountebank;", 1);
            magicItemTableG.AddLine("Censer of controlling air elementals;", 1);
            magicItemTableG.AddLine("Armor, +l chain mail;", 1);
            magicItemTableG.AddLine("Armor of resistance (chain mail);", 1);
            magicItemTableG.AddLine("Armor, + l chain shirt;", 1);
            magicItemTableG.AddLine("Armor of resistance (chain shirt);", 1);
            magicItemTableG.AddLine("Cloak of displacement;", 1);
            magicItemTableG.AddLine("Cloak of the bat;", 1);
            magicItemTableG.AddLine("Cube of force;", 1);
            magicItemTableG.AddLine("Daern's instant fortress;", 1);
            magicItemTableG.AddLine("Dagger of venom;", 1);
            magicItemTableG.AddLine("Dimensional shackles;", 1);
            magicItemTableG.AddLine("Dragon slayer;", 1);
            magicItemTableG.AddLine("Elven chain;", 1);
            magicItemTableG.AddLine("Flame tongue;", 1);
            magicItemTableG.AddLine("Gem of seeing;", 1);
            magicItemTableG.AddLine("Giant slayer;", 1);
            magicItemTableG.AddLine("Glamoured studded leather;", 1);
            magicItemTableG.AddLine("Helm of teleportation;", 1);
            magicItemTableG.AddLine("Horn of blasting;", 1);
            magicItemTableG.AddLine("Horn of Valhalla (silver or brass);", 1);
            magicItemTableG.AddLine("Instrument of the bards (Canaith mandolin);", 1);
            magicItemTableG.AddLine("Instrument of the bards (Clilyre);", 1);
            magicItemTableG.AddLine("loun stone (awareness);", 1);
            magicItemTableG.AddLine("loun stone (protection);", 1);
            magicItemTableG.AddLine("loun stone (reserve);", 1);
            magicItemTableG.AddLine("loun stone (sustenance);", 1);
            magicItemTableG.AddLine("Iron bands of Bilarro;", 1);
            magicItemTableG.AddLine("Armor, + l leather;", 1);
            magicItemTableG.AddLine("Armor of resistance (leather);", 1);
            magicItemTableG.AddLine("Mace of disruption;", 1);
            magicItemTableG.AddLine("Mace of smiting;", 1);
            magicItemTableG.AddLine("Mace of terror;", 1);
            magicItemTableG.AddLine("Mantle of spell resistance;", 1);
            magicItemTableG.AddLine("Necklace of prayer beads;", 1);
            magicItemTableG.AddLine("Periapt of proof against poison;", 1);
            magicItemTableG.AddLine("Ring of animal influence;", 1);
            magicItemTableG.AddLine("Ring of evasion;", 1);
            magicItemTableG.AddLine("Ring of feather falling;", 1);
            magicItemTableG.AddLine("Ring of free action;", 1);
            magicItemTableG.AddLine("Ring of protection;", 1);
            magicItemTableG.AddLine("Ring of resistance;", 1);
            magicItemTableG.AddLine("Ring of spell storing;", 1);
            magicItemTableG.AddLine("Ring of the ram;", 1);
            magicItemTableG.AddLine("Ring of X-ray vision;", 1);
            magicItemTableG.AddLine("Robe of eyes;", 1);
            magicItemTableG.AddLine("Rod of rulership;", 1);
            magicItemTableG.AddLine("Rod of the pact keeper, +2;", 1);
            magicItemTableG.AddLine("Rope of entanglement;", 1);
            magicItemTableG.AddLine("Armor, + l scale mail;", 1);
            magicItemTableG.AddLine("Armor of resistance (scale mail);", 1);
            magicItemTableG.AddLine("Shield, +2;", 1);
            magicItemTableG.AddLine("Shield of missile attraction;", 1);
            magicItemTableG.AddLine("Staff of charming;", 1);
            magicItemTableG.AddLine("Staff of healing;", 1);
            magicItemTableG.AddLine("Staff of swarming insects;", 1);
            magicItemTableG.AddLine("Staff of the woodlands;", 1);
            magicItemTableG.AddLine("Staff of withering;", 1);
            magicItemTableG.AddLine("Stone of controlling earth elementals;", 1);
            magicItemTableG.AddLine("Sun blade;", 1);
            magicItemTableG.AddLine("Sword of life stealing;", 1);
            magicItemTableG.AddLine("Sword of wounding;", 1);
            magicItemTableG.AddLine("Tentacle rod;", 1);
            magicItemTableG.AddLine("Vicious weapon;", 1);
            magicItemTableG.AddLine("Wand of binding;", 1);
            magicItemTableG.AddLine("Wand of enemy detection;", 1);
            magicItemTableG.AddLine("Wand of fear;", 1);
            magicItemTableG.AddLine("Wand of fireballs;", 1);
            magicItemTableG.AddLine("Wand of lightning bolts;", 1);
            magicItemTableG.AddLine("Wand of paralysis;", 1);
            magicItemTableG.AddLine("Wand of the war mage, +2;", 1);
            magicItemTableG.AddLine("Wand of wonder;", 1);
            magicItemTableG.AddLine("Wings of flying;", 1);

            //TABLE H
            Table_Manager magicItemTableH = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Magic_Item_Tables\Table_H.txt");
            magicItemTableH.DeleteAll();
            magicItemTableH.AddLine("Weapon , +3;", 10);
            magicItemTableH.AddLine("Amulet of the planes;", 2);
            magicItemTableH.AddLine("Carpet of flying;", 2);
            magicItemTableH.AddLine("Crystal ball (very rare version);", 2);
            magicItemTableH.AddLine("Ring of regeneration;", 2);
            magicItemTableH.AddLine("Ring of shooting stars;", 2);
            magicItemTableH.AddLine("Ring of telekinesis;", 2);
            magicItemTableH.AddLine("Robe of scintil lating colors;", 2);
            magicItemTableH.AddLine("Robe of stars;", 2);
            magicItemTableH.AddLine("Rod of absorption;", 2);
            magicItemTableH.AddLine("Rod of alertness;", 2);
            magicItemTableH.AddLine("Rod of security;", 2);
            magicItemTableH.AddLine("Rod of the pact keeper, +3;", 2);
            magicItemTableH.AddLine("Scimitar of speed;", 2);
            magicItemTableH.AddLine("Shield, +3;", 2);
            magicItemTableH.AddLine("Staff of fire;", 2);
            magicItemTableH.AddLine("Staff of frost;", 2);
            magicItemTableH.AddLine("Staff of power;", 2);
            magicItemTableH.AddLine("Staff of striking;", 2);
            magicItemTableH.AddLine("Staff of thunder and lightning;", 2);
            magicItemTableH.AddLine("Sword of sharpness;", 2);
            magicItemTableH.AddLine("Wand of polymorph;", 2);
            magicItemTableH.AddLine("Wand of the war mage, +3;", 2);
            magicItemTableH.AddLine("Adamantine armor (half plate);", 1);
            magicItemTableH.AddLine("Adamantine armor (plate);", 1);
            magicItemTableH.AddLine("Animated shield;", 1);
            magicItemTableH.AddLine("Belt of fire giant strength;", 1);
            magicItemTableH.AddLine("Belt of frost (or stone) giant strength;", 1);
            magicItemTableH.AddLine("Armor, + l breastplate;", 1);
            magicItemTableH.AddLine("Armor of resistance (breastplate);", 1);
            magicItemTableH.AddLine("Candle of invocation;", 1);
            magicItemTableH.AddLine("Armor, +2 chain mail;", 1);
            magicItemTableH.AddLine("Armor, +2 chain shirt;", 1);
            magicItemTableH.AddLine("Cloak of arach nida;", 1);
            magicItemTableH.AddLine("Dancing sword;", 1);
            magicItemTableH.AddLine("Demon armor;", 1);
            magicItemTableH.AddLine("Dragon scale mail;", 1);
            magicItemTableH.AddLine("Dwarven plate;", 1);
            magicItemTableH.AddLine("Dwarven thrower;", 1);
            magicItemTableH.AddLine("Efreeti bottle;", 1);
            magicItemTableH.AddLine("Figurine of wondrous power (obsidian steed);", 1);
            magicItemTableH.AddLine("Frost brand;", 1);
            magicItemTableH.AddLine("Helm of brilliance;", 1);
            magicItemTableH.AddLine("Horn of Valhalla (bronze);", 1);
            magicItemTableH.AddLine("Instrument of the bards (Anstruth harp);", 1);
            magicItemTableH.AddLine("loun stone (absorption);", 1);
            magicItemTableH.AddLine("loun stone (agility);", 1);
            magicItemTableH.AddLine("loun stone (fortitude);", 1);
            magicItemTableH.AddLine("Ioun stone (insight);", 1);
            magicItemTableH.AddLine("loun stone (intellect);", 1);
            magicItemTableH.AddLine("loun stone (leadership);", 1);
            magicItemTableH.AddLine("loun stone (strength);", 1);
            magicItemTableH.AddLine("Armor, +2 leather;", 1);
            magicItemTableH.AddLine("Manual of bodily health;", 1);
            magicItemTableH.AddLine("Manual of gainful exercise;", 1);
            magicItemTableH.AddLine("Manual of golems;", 1);
            magicItemTableH.AddLine("Manual of quickness of action;", 1);
            magicItemTableH.AddLine("Mirror of life trapping;", 1);
            magicItemTableH.AddLine("Nine lives stealer;", 1);
            magicItemTableH.AddLine("Oath bow;", 1);
            magicItemTableH.AddLine("Armor, +2 scale mail;", 1);
            magicItemTableH.AddLine("Spellguard shield;", 1);
            magicItemTableH.AddLine("Armor, + l splint;", 1);
            magicItemTableH.AddLine("Armor of resistance (splint);", 1);
            magicItemTableH.AddLine("Armor, + l studded leather;", 1);
            magicItemTableH.AddLine("Armor of resistance (studded leather);", 1);
            magicItemTableH.AddLine("Tome of clear thought;", 1);
            magicItemTableH.AddLine("Tome of leadership and influence;", 1);
            magicItemTableH.AddLine("Tome of understanding;", 1);

            //TABLE I
            Table_Manager magicItemTableI = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Magic_Item_Tables\Table_I.txt");
            SpecificItemPicker SpecificItemPickerArmor = new SpecificItemPicker();
            magicItemTableI.DeleteAll();

            magicItemTableI.AddLine("Defender;", 5);
            magicItemTableI.AddLine("Hammer of thunderbolts;", 5);
            magicItemTableI.AddLine("Luck blade;", 5);
            magicItemTableI.AddLine("Sword of answering;", 5);
            magicItemTableI.AddLine("Holy avenger;", 3);
            magicItemTableI.AddLine("Ring of djinni summoning;", 3);
            magicItemTableI.AddLine("Ring of invisibility;", 3);
            magicItemTableI.AddLine("Ring of spell turning;", 3);
            magicItemTableI.AddLine("Rod of lordly might;", 3);
            magicItemTableI.AddLine("Staff of the magi;", 3);
            magicItemTableI.AddLine("Vorpal sword;", 3);
            magicItemTableI.AddLine("Belt of cloud giant strength;", 2);
            magicItemTableI.AddLine("Armor, +2 breastplate;", 2);
            magicItemTableI.AddLine("Armor, +3 chain mail;", 2);
            magicItemTableI.AddLine("Armor, +3 chain shirt;", 2);
            magicItemTableI.AddLine("Cloak of invisibility;", 2);
            magicItemTableI.AddLine("Crystal ball (legendary version);", 2);
            magicItemTableI.AddLine("Armor, + 1 half plate;", 2);
            magicItemTableI.AddLine("Iron flask;", 2);
            magicItemTableI.AddLine("Armor, +3 leather;", 2);
            magicItemTableI.AddLine("Armor, + 1 plate;", 2);
            magicItemTableI.AddLine("Robe of the arch magi;", 2);
            magicItemTableI.AddLine("Rod of resurrection;", 2);
            magicItemTableI.AddLine("Armor, +l scale mail;", 2);
            magicItemTableI.AddLine("Scarab of protection;", 2);
            magicItemTableI.AddLine("Armor, +2 splint;", 2);
            magicItemTableI.AddLine("Armor, +2 studded leather;", 2);
            magicItemTableI.AddLine("Well of many worlds;", 2);
            magicItemTableI.AddLine(SpecificItemPickerArmor.ArmorPicker(), 1);
            magicItemTableI.AddLine("Apparatus of Kwalish;", 1);
            magicItemTableI.AddLine("Armor of invul nerability;", 1);
            magicItemTableI.AddLine("Belt of storm giant strength;", 1);
            magicItemTableI.AddLine("Cubic gate;", 1);
            magicItemTableI.AddLine("Deck of many things;", 1);
            magicItemTableI.AddLine("Efreeti chain;", 1);
            magicItemTableI.AddLine("Armor of resistance (half plate);", 1);
            magicItemTableI.AddLine("Horn of Valhalla (iron);", 1);
            magicItemTableI.AddLine("Instrument of the bards (Ollamh harp);", 1);
            magicItemTableI.AddLine("loun stone (greater absorption);", 1);
            magicItemTableI.AddLine("loun stone (mastery);", 1);
            magicItemTableI.AddLine("loun stone (regeneration);", 1);
            magicItemTableI.AddLine("Plate armor of etherealness;", 1);
            magicItemTableI.AddLine("Plate armor of resistance;", 1);
            magicItemTableI.AddLine("Ring of air elemental command;", 1);
            magicItemTableI.AddLine("Ring of earth elemental command;", 1);
            magicItemTableI.AddLine("Ring of fire elemental command;", 1);
            magicItemTableI.AddLine("Ring of three wishes;", 1);
            magicItemTableI.AddLine("Ring of water elemental command;", 1);
            magicItemTableI.AddLine("Sphere of annihi lation;", 1);
            magicItemTableI.AddLine("Talisman of pure good;", 1);
            magicItemTableI.AddLine("Talisman of the sphere;", 1);
            magicItemTableI.AddLine("Talisman of ultimate evil;", 1);
            magicItemTableI.AddLine("Tome of the stilled tongue ;", 1);

            #endregion

            #region  The Dnd5e tables: GEMSTONES TABLES. (.TXT)
            //GEMSTONES WORTH 10 GP
            Table_Manager gemstones10 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Gemstones_Tables\Gemstones_10GP.txt");
            gemstones10.DeleteAll();
            gemstones10.AddLine("Azurite (opaque mottled deep blue);", 1);
            gemstones10.AddLine("Banded agate (translucent striped brown, blue, white, or red);", 1);
            gemstones10.AddLine("Blue quartz (transparent pale blue);", 1);
            gemstones10.AddLine("Eye agate (transl ucent circles of gray, white, brown,blue, or green);", 1);
            gemstones10.AddLine("Hematite (opaque gray-black);", 1);
            gemstones10.AddLine("Lapis lazuli (opaque light and dark blue with yellow flecks);", 1);
            gemstones10.AddLine("Malachite (opaque striated light and dark green);", 1);
            gemstones10.AddLine("Moss agate (translucent pink or yellow-white with mossy gray or green markings);", 1);
            gemstones10.AddLine("Obsidian (opaque black);", 1);
            gemstones10.AddLine("Rhodochrosite (opaque light pink);", 1);
            gemstones10.AddLine("Tiger eye (translucent brown with golden center);", 1);
            gemstones10.AddLine("Turquoise (opaque light blue-green);", 1);

            //GEMSTONES WORTH 50 GP
            Table_Manager gemstones50 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Gemstones_Tables\Gemstones_50GP.txt");
            gemstones50.DeleteAll();
            gemstones50.AddLine("Bloodstone (opaque dark gray with red flecks);", 1);
            gemstones50.AddLine("Carnelian (opaque orange to red-brown);", 1);
            gemstones50.AddLine("Chalcedony (opaque white);", 1);
            gemstones50.AddLine("Chrysoprase (translucent green);", 1);
            gemstones50.AddLine("Citrine (transparent pale yellow-brown);", 1);
            gemstones50.AddLine("jasper (opaque blue, black, or brown);", 1);
            gemstones50.AddLine("Moonstone (translucent white with pale blue glow);", 1);
            gemstones50.AddLine("Onyx (opaque bands of black and white, or pure back or white);", 1);
            gemstones50.AddLine("Quartz (transparent white, smoky gray, or yellow);", 1);
            gemstones50.AddLine("Sardonyx (opaque bands of red and white);", 1);
            gemstones50.AddLine("Star rose quartz (translucent rosy stone with white;", 1);
            gemstones50.AddLine("star-shaped center);", 1);
            gemstones50.AddLine("Zircon (transparent pale blue-green);", 1);

            //GEMSTONES WORTH 100GP
            Table_Manager gemstones100 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Gemstones_Tables\Gemstones_100GP.txt");

            gemstones100.DeleteAll();

            gemstones100.AddLine("Amber (transparent watery gold to rich gold);", 1);
            gemstones100.AddLine("Amethyst (transparent deep purple);", 1);
            gemstones100.AddLine("Chrysoberyl (transparent yel low-green to pale green);", 1);
            gemstones100.AddLine("Coral (opaque crimson);", 1);
            gemstones100.AddLine("Garnet (transparent red, brown-green, or violet);", 1);
            gemstones100.AddLine("jade (translucent light green, deep green, or white);", 1);
            gemstones100.AddLine("jet (opaque deep black);", 1);
            gemstones100.AddLine("Pearl (opaque lustrous white, yellow, or pink);", 1);
            gemstones100.AddLine("Spinel (transparent red, red-brown, or deep green);", 1);
            gemstones100.AddLine("Tourmaline (transparent pale green, blue, brown, or red);", 1);

            //GEMSTONES WORTH 500GP
            Table_Manager gemstones500 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Gemstones_Tables\Gemstones_500GP.txt");

            gemstones500.DeleteAll();

            gemstones500.AddLine("Alexandrite (transparent dark green);", 1);
            gemstones500.AddLine("Aquamarine (transparent pale blue-green);", 1);
            gemstones500.AddLine("Black pearl (opaque pure black);", 1);
            gemstones500.AddLine("Blue spinel (transparent deep blue);", 1);
            gemstones500.AddLine("Peridot (transparent rich ol ive green);", 1);
            gemstones500.AddLine("Topaz (transparent golden yellow);", 1);

            //GEMSTONES WORTH 1000GP
            Table_Manager gemstones1000 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Gemstones_Tables\Gemstones_1000GP.txt");

            gemstones1000.DeleteAll();

            gemstones1000.AddLine("Black opal (translucent dark green with black mottling and golden flecks);", 1);
            gemstones1000.AddLine("Blue sapphire (transparent blue-white to medium blue);", 1);
            gemstones1000.AddLine("Emerald (transparent deep bright green);", 1);
            gemstones1000.AddLine("Fire opal (translucent fiery red);", 1);
            gemstones1000.AddLine("Opal (transl ucent pale blue with green and golden mottling);", 1);
            gemstones1000.AddLine("Star ruby (translucent ruby with white star-shaped center);", 1);
            gemstones1000.AddLine("Star sapphire (translucent blue sapphire with white star-shaped center);", 1);
            gemstones1000.AddLine("Yellow sapphire (transparent fiery yellow or yellowgreen);", 1);
            //GEMSTONES WORTH 5000GP
            Table_Manager gemstones5000 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Gemstones_Tables\Gemstones_5000GP.txt");
            gemstones5000.DeleteAll();

            gemstones5000.AddLine("Black sapphire (translucent lustrous black withglowing highlights);", 1);
            gemstones5000.AddLine("Diamond (transparent bl ue-white, canary, pink, brown, or blue);", 1);
            gemstones5000.AddLine("Jacinth (transparent fiery orange);", 1);
            gemstones5000.AddLine("Ruby (transparent clear red to deep crimson);", 1);

            #endregion

            #region  The Dnd5e tables: ART OBJECTS TABLES. (.TXT)
            //ART OBJECT WORTH 25GP
            Table_Manager artObject25 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Art_Objects_Tables\Art_Objects_25GP.txt");
            artObject25.DeleteAll();
            artObject25.AddLine("Silver ewer;", 1);
            artObject25.AddLine("Carved bone statuette;", 1);
            artObject25.AddLine("Small gold bracelet;", 1);
            artObject25.AddLine("Cloth-of-gold vestments;", 1);
            artObject25.AddLine("Black velvet mask stitched with silver thread;", 1);
            artObject25.AddLine("Copper chalice with silver filigree;", 1);
            artObject25.AddLine("Pair of engraved bone dice;", 1);
            artObject25.AddLine("Small mirror set in a painted wooden frame;", 1);
            artObject25.AddLine("Embroidered silk handkerchief;", 1);
            artObject25.AddLine("Gold locket with a painted portrait inside;", 1);

            //ART OBJECT WORTH 250GP
            Table_Manager artObject250 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Art_Objects_Tables\Art_Objects_250GP.txt");
            artObject250.DeleteAll();
            artObject250.AddLine("Gold ring set with bloodstones;", 1);
            artObject250.AddLine("Carved ivory statuette;", 1);
            artObject250.AddLine("Large gold bracelet;", 1);
            artObject250.AddLine("Silver necklace with a gemstone pendant;", 1);
            artObject250.AddLine("Bronze crown;", 1);
            artObject250.AddLine("Silk robe with gold embroidery;", 1);
            artObject250.AddLine("Large well-made tapestry;", 1);
            artObject250.AddLine("Brass mug with jade in lay;", 1);
            artObject250.AddLine("Box of turquoise animal figurines;", 1);
            artObject250.AddLine("Gold bird cage with electrum filigree;", 1);

            //ART OBJECT WORTH 750GP
            Table_Manager artObject750 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Art_Objects_Tables\Art_Objects_750GP.txt");
            artObject750.DeleteAll();
            artObject750.AddLine("Silver chalice set with moonstones;", 1);
            artObject750.AddLine("Silver-plated steel longsword with jet set in hilt;", 1);
            artObject750.AddLine("Carved harp of exotic wood with ivory inlay and zircon gems;", 1);
            artObject750.AddLine("Small gold idol;", 1);
            artObject750.AddLine("Gold dragon comb set with red garnets as eyes;", 1);
            artObject750.AddLine("Bottle stopper cork embossed with gold leaf and set with amethysts;", 1);
            artObject750.AddLine("Ceremonial electrum dagger with a black pearl in the pommel;", 1);
            artObject750.AddLine("Silver and gold brooch;", 1);
            artObject750.AddLine("Obsidian statuette with gold fittings and inlay;", 1);
            artObject750.AddLine("Painted gold war mask;", 1);

            //ART OBJECT WORTH 2500GP
            Table_Manager artObject2500 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Art_Objects_Tables\Art_Objects_2500GP.txt");
            artObject2500.DeleteAll();
            artObject2500.AddLine("Fine gold chain set with a fire opal;", 1);
            artObject2500.AddLine("Old masterpiece painting;", 1);
            artObject2500.AddLine("Embroidered silk and velvet mantle set with numerous moonstones;", 1);
            artObject2500.AddLine("Platinum bracelet set with a sapphire;", 1);
            artObject2500.AddLine("Embroidered glove set with jewel chips;", 1);
            artObject2500.AddLine("Jeweled anklet;", 1);
            artObject2500.AddLine("Gold music box;", 1);
            artObject2500.AddLine("Gold circlet set with four aquamarines;", 1);
            artObject2500.AddLine("Eye patch with a mock eye set in blue sapphire and moonstone;", 1);
            artObject2500.AddLine("A necklace string of small pink pearls;", 1);

            //ART OBJECT WORTH 7500GP
            Table_Manager artObject7500 = new Table_Manager(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Art_Objects_Tables\Art_Objects_7500GP.txt");
            artObject7500.DeleteAll();
            artObject7500.AddLine("Jeweled gold crown;", 1);
            artObject7500.AddLine("Jeweled platinum ring;", 1);
            artObject7500.AddLine("Small gold statuette set with rubies;", 1);
            artObject7500.AddLine("Gold cup set with emeralds;", 1);
            artObject7500.AddLine("Gold jewelry box with platinum filigree;", 1);
            artObject7500.AddLine("Painted gold child's sarcophagus;", 1);
            artObject7500.AddLine("Jade game board with solid gold playing pieces;", 1);
            artObject7500.AddLine("Bejeweled ivory drinking horn with gold filigree;", 1);

            #endregion

            #region UI
         

            string userGenerationSelection = "";
            short  userCR = 0;
            string userMagicItemLetter = "";
            int    lootAndShoot = 0;
            
            Console.WriteLine("Dnd5e Treasure Generator App: What do you want to generate ?\n" +
                              "-----------------------------------------------------------");
            Console.WriteLine("(A) for an INDIVIDUAL TREASURE   generation    (FANTASY / Dnd5e).\n" +
                              "(B) for a  TREASURE HOARD        generation    (FANTASY / Dnd5e).\n" +
                              "(C) for a  MAGIC ITEM            generation    (FANTASY / Dnd5e).\n"+
                              "(D) for a SCI-FI WEAPON          generation    (SCI-FI  / UM5e ).");

            Console.WriteLine("|A piece of advice about loot|\n\n" +
                              "How many loot by campaign:\n" +
                              "-------------------------\n" +
                              "You can hand out as much or as little treasure as you want.\n" +
                              "But over the course of a typical campaign, a party finds treasure hoards amounting to \n" +
                              "** (7)  seven rolls     on the Challenge 0 - 4 table, \n" +
                              "**(18) eighteen rolls   on the Challenge 5 - 10 table, \n" +
                              "**(12) twelve rolls     on the Challenge 11 - 16 table and\n" +
                              "** (8)  eight rolls     on the Challenge 17 + table. \n");
            userGenerationSelection = Console.ReadLine();

            do
            {
                Console.Clear();

                Console.WriteLine("(A) for an INDIVIDUAL TREASURE generation (FANTASY / Dnd5e).\n" +
                                  "(B) for an TREASURE HOARD generation      (FANTASY / Dnd5e).\n" +
                                  "(C) for a  MAGIC ITEM            generation    (FANTASY / Dnd5e).\n" +
                                  "(D) for a SCI-FI WEAPON          generation    (SCI-FI  / UM5e )."+
                                  "(Z)to close the app.\n");

                if (userGenerationSelection.ToUpper() == "A")
                {
                    do
                    {
                        Console.Write("Choose the Challenge Rating (between 1 and 30): ");
                        userCR = Convert.ToInt16(Console.ReadLine());
                    } while (userCR < 0 || userCR > 30);

                    Individual_Treasure indivTreasure = new Individual_Treasure(userCR);
                    Console.WriteLine(indivTreasure.GenerateTreasure());
                }
                else if (userGenerationSelection.ToUpper() == "B")
                {
                    do
                    {
                        Console.Write("Choose the Challenge Rating (between 1 and 30): ");
                        userCR = Convert.ToInt16(Console.ReadLine());
                    } while (userCR < 0 || userCR > 30);

                    Treasure_Hoard_Tables treasureHoard = new Treasure_Hoard_Tables(userCR);
                    Console.WriteLine(treasureHoard.Treasure);
                }
                else if (userGenerationSelection.ToUpper() == "C")
                {
                    do
                    {
                        Console.Write("Choose the table of the magic item (between A and I): ");
                        userMagicItemLetter = Console.ReadLine();
                    } while (!Regex.Match(userMagicItemLetter.ToUpper(), "^[A-I]{1}$").Success);

                    Magic_Item_Tables magicIt = new Magic_Item_Tables(userMagicItemLetter.ToUpper());   
                    Console.WriteLine(magicIt.PickMagicItem());
                }
                else if (userGenerationSelection.ToUpper() == "D")
                {
                    do
                    {
                        Console.Write("Encode the level of your character (between 1 and 20): ");
                        lootAndShoot = Convert.ToInt16(Console.ReadLine());
                    } while (lootAndShoot < 1 || lootAndShoot > 20);

                    LootAndShoot lAndS = new LootAndShoot(lootAndShoot);
                    Console.WriteLine(lAndS.GenerateWeapon());
                }
                    Console.Write("\n---------------------------------\n"+
                                "Another generation? Pick a letter: ");
                userGenerationSelection = Console.ReadLine();
            } while (userGenerationSelection.ToUpper() != "Z");

            #endregion
        }
    }
}
