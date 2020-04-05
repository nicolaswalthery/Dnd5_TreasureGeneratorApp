using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnd5_TreasureGeneratorApp
{
    class LootAndShoot
    {
        /*The LootAndShoot class is only here the generate a weapon.
         * This is work in progress so don't check this out, it is not finished yet and it is bad coding. ;)*/
        #region STATIC ELEMENTS
        #endregion
        #region STATIC VARIABLES
        #endregion

        #region STATIC CONSTRUCTORS - PROPERTIES - METHODES
        #endregion

        //===========================================

        #region INSTANCE ELEMENTS
        #endregion
        #region INSTANCE VARIABLES
        #endregion
        private Dice oneD20;
        private int weaponRarityCheck;
        
        #region INSTANCE CONSTRUCTORS - PROPERTIES - METHODES
        #endregion
        //==CONSTRUCTOR
        public LootAndShoot(int weaponRarityCheck)
        {
            this.oneD20 = new Dice(1, 20);
            this.WeaponRarityCheck = weaponRarityCheck;
        }
        private int WeaponRarityCheck
        {
            set
            {
                if (value < 1 || value > 20)
                    throw new Exception("The players's level that determine the modifier for the weapon rarity can't be inferior to 1 or superior to 20.");
                this.weaponRarityCheck = value;
            }
        }
        //==PROPERTIES
        private string WeaponType
        {
            get
            {
                string retVal = "";
                int dO/*diceOutcome*/ = this.oneD20.ThrowIt;

                if(dO <= 5)
                    retVal += "| Weapon Type: One-handed small arm | Damage: 1d6    | Base Cost: 250"+
                              "|Range: 50/200                      | Weight: 3 lb   | Properties: Light";
                else if (dO <= 10)
                    retVal += "| Weapon Type: Two-handed small arm | Damage: 1d8    | Base Cost: 350" +
                              "|Range: 100/400                     | Weight: 12 lb  | Properties: x2 magazine";
                else if(dO <= 15)
                    retVal += "| Weapon Type: Heavy weapon         | Damage: 1d10   | Base Cost: 550" +
                              "|Range: 200/800                     | Weight: 40 lb  | Properties: x3 magazine, heavy";
                else if(dO <= 20)
                    retVal += "| Weapon Type: Super heavy weapon   | Damage: 1d6+6  | Base Cost: 750" +
                              "|Range: 300/1200                    | Weight: 150 lb | Properties: x4 magazine, heavy, AP";
                return retVal;
            }
        }
        private string WeaponRarity
        {
            get
            {
                string retVal = "";
                int dO/*diceOutcome*/ = this.oneD20.ThrowIt;

                if      (dO <= 7)
                {
                    retVal += "|Rarity: Common      | Benefit: None   | Table Rolls: 1 company" +
                              "|Cost: 0           |";
                    retVal += "\n"+this.Company;
                }
                else if (dO <= 13)
                {
                    retVal += "|Rarity: Uncommon    | Benefit: +1 attack and +1 damage | Table Rolls: 1 company, 1 line" +
                              "|Cost: x2          |";
                    retVal += "\n" + this.Company;
                }
                else if (dO <= 18)
                {
                    retVal += "|Rarity: Rare        | Benefit: +1 attack and +2 damage | Table Rolls: 1 company, 1 line, 1 model" +
                              "|Cost: x5          |";
                    retVal += "\n" + this.Company;
                }
                else if (dO <= 22)
                {
                    retVal += "|Rarity: Epic        | Benefit: +2 attack and +3 damage | Table Rolls: 1 company, 1 line, 1 model" +
                              "|Cost: x10         |";
                    retVal += "\n" + this.Company;
                }
                else if (dO <= 25)
                {
                    retVal += "|Rarity: Masterwork  | Benefit: +2 attack and +4 damage | Table Rolls: 1 company, 1 line, 2 model" +
                              "|Cost: x30         |";
                    retVal += "\n" + this.Company;
                }
                else if (dO >= 26)
                {
                    retVal += "|Rarity: Legendary   | Benefit: +3 attack and +5 damage | Table Rolls: 1 company, 2 line, 2 model" +
                              "|Cost: x60         |";
                    retVal += "\n" + this.Company;
                }
                return retVal;
            }
        }
        private string Company
        {
            get
            {
                string retVal = "";
                int dO/*diceOutcome*/ = this.oneD20.ThrowIt;

                if (dO == 1)
                    retVal += "| Company: | Damage Type:  |  Magazine:       |  TL:   |"+
                              "| Mifune   |     Acid      |  Reload Cell 15  |   4    |";
                else if (dO == 2)
                    retVal += "| Company: | Damage Type:  |  Magazine:       |  TL:   |" +
                              "| Gunsmith |     Cold      |  Reload Cell 15  |  4     |";
                else if (dO == 3)
                    retVal += "| Company: | Damage Type:  |  Magazine:       |  TL:   |" +
                              "| Viper    | Fire Reload   |  Cell 15         |  4     |";
                else if (dO == 4)
                    retVal += "| Company: | Damage Type:        |  Magazine:       |  TL:   |" +
                              "| Moses    | Pincher (lightning) |  Reload Cell 15  |  3     |";
                else if (dO == 5)
                    retVal += "| Company: | Damage Type:                 | Magazine:       |  TL:   |" +
                              "| Seburo   | Sonic (thunder & bludgeoning | Reload Cell 15  |  3     |";
                else if (dO <= 10)
                    retVal += "| Company: | Damage Type:                           | Magazine:  |  TL: |" +
                              "| Federated| Firearms Traditional bullet (piercing) | Reload 20  |  2   |";
                else if (dO <= 12)
                    retVal += "| Company:  | Damage Type:      | Magazine:      |  TL: |" +
                              "| NecroTech | Nuclear (radiant) | Reload Cell 20 |  3   |";
                else if (dO <= 14)
                    retVal += "| Company:  | Damage Type:      | Magazine:      |  TL: |" +
                              "| Alphaden  | Laser (fire)      | Reload Cell 20 |  4   |";
                else if (dO <= 16)
                    retVal += "| Company:  | Damage Type:            | Magazine:       |  TL: |" +
                              "| Marathon  | Plasma (radiant & fire) | Reload Cell 20  |  5   |";
                else if (dO <= 18)
                    retVal += "| Company:       | Damage Type:        | Magazine:  |  TL: |" +
                              "| Morita Limited | Magnetic (piercing) | Reload 20  |  3   |";
                else if (dO ==19)
                    retVal += "| Company:       | Damage Type:      | Magazine:  |  TL: |" +
                              "| NecroTech      | Necrotic Reload   | Cell 20    |  3   |";
                else if (dO == 20)
                    retVal += "| Company:       | Damage Type:   | Magazine:      |  TL: |" +
                              "| Spirit Systems | Force          | Reload Cell 20 |  3   |";
                return retVal;
            }
        }
        public string GenerateWeapon() /* Leçon: il vaut mieux mettre tout dans des variables pour pouvoir controler leur affichage par après.*/
        {
            string retVal = "";
            return retVal = "Weapon Type  : \n\n"+this.WeaponType + "\n" +
                            "Weapon Rarity: \n\n"+this.WeaponRarity;
        }

            

    }
}
