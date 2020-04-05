using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnd5_TreasureGeneratorApp
{
    class SpecificItemPicker
    {
        /// <summary>
        /// ***********************************************************************************************************************************
        /// - The only purpuse of this class is to send back a string.
        /// - Origin story: I realised that i needed to create that class when i saw that some of the magic tables entries contained more options
        ///   then one.
        /// ***********************************************************************************************************************************
        /// </summary>

        #region INSTANCE VARIABLES
        #endregion
        private Random rndNbr;
        private ArrayList specificItems;

        #region INSTANCE CONSTRUCTORS - PROPERTIES - METHODES
        #endregion
        //==CONSTRUCTOR
        public SpecificItemPicker()
        {
            this.rndNbr = new Random(DateTime.Now.Millisecond);
            specificItems = new ArrayList();
        }

        //==METHODES
        public string FigPicker() //Return a figurine. (Magic Table H pg 148 of the DM's Guide)
        {
            specificItems.Clear();
            specificItems.Add("Bronze griffon");
            specificItems.Add("Ebony fly");
            specificItems.Add("Golden lions");
            specificItems.Add("Ivory goats");
            specificItems.Add("Marble elephant");
            specificItems.Add("Onyx dog");
            specificItems.Add("Wooden wildcat");
            specificItems.Add("Serpentine owl");

            rndNbr.Next(0, specificItems.Count + 1);

            return "Figurine of wondrous power: " + specificItems+";";
        }
        public string ArmorPicker() //Return a type of armor. (Magic Table G pg 147 of the DM's Guide)
        {
            specificItems.Clear();
            specificItems.Add("Magic Armor, +2 half plate");
            specificItems.Add("Magic Armor, +2 half plate");
            specificItems.Add("Magic Armor, +2 plate");
            specificItems.Add("Magic Armor, +2 plate");
            specificItems.Add("Magic Armor, +3 studded leather");
            specificItems.Add("Magic Armor, +3 studded leather");
            specificItems.Add("Magic Armor, +3 breastplate");
            specificItems.Add("Magic Armor, +3 breastplate");
            specificItems.Add("Magic Armor, +3 splint");
            specificItems.Add("Magic Armor, +3 splint");
            specificItems.Add("Magic Armor, +3 half plate");
            specificItems.Add("Magic Armor, +3 plate");

            rndNbr.Next(0, specificItems.Count +1);

            return "Magic armor: " + specificItems + ";";
        }
    }
}
