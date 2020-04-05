
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnd5_TreasureGeneratorApp
{
    class Treasure_Hoard_Tables
    {
        /// <summary>
        /// The Treasure_Hoard_Tables will instanciate:
        /// - Every type of die that will be needed to determine how many items, gem, art objects will be generated in the "TreasureHoard" tables.
        /// - Every Gemstones_Tables.
        /// - Every Art_Objects_Tables.
        /// - Every Magic_Item_Tables.
        /// </summary>
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
        private short  challengeRating;
        private Random rndNbr;
        private string treasure;

        private Dice twoD6;
        private Dice twoD4;
        private Dice oneD6;
        private Dice oneD4;
        private Dice threeD6;
        private Dice threeD4;
        private Dice oneD10;
        private Dice oneD8;
        private Dice oneD1;

        private Gemstones_Tables gemstones10;
        private Gemstones_Tables gemstones50;
        private Gemstones_Tables gemstones100;
        private Gemstones_Tables gemstones500;
        private Gemstones_Tables gemstones1000;
        private Gemstones_Tables gemstones5000;

        private Art_Objects_Tables artObject25;
        private Art_Objects_Tables artObject250;
        private Art_Objects_Tables artObject750;
        private Art_Objects_Tables artObject2500;
        private Art_Objects_Tables artObject7500;

        private Magic_Item_Tables magicItemTable_A;
        private Magic_Item_Tables magicItemTable_B;
        private Magic_Item_Tables magicItemTable_C;
        private Magic_Item_Tables magicItemTable_D;
        private Magic_Item_Tables magicItemTable_E;
        private Magic_Item_Tables magicItemTable_F;
        private Magic_Item_Tables magicItemTable_G;
        private Magic_Item_Tables magicItemTable_H;
        private Magic_Item_Tables magicItemTable_I;

        #region INSTANCE CONSTRUCTORS - PROPERTIES - METHODES
        #endregion
        //==CONSTRUCTOR
        public Treasure_Hoard_Tables(short challengeRating)
        {
            /*We instanciate the objects (Dice & Tables: Gem, Art & Magic)*/
            this.twoD6   = new Dice(2, 6);
            this.twoD4   = new Dice(2, 4);
            this.oneD6   = new Dice(1, 6);
            this.oneD4   = new Dice(1, 4);
            this.threeD6 = new Dice(3, 6);
            this.threeD4 = new Dice(3, 4);
            this.oneD10  = new Dice(1, 10);
            this.oneD8   = new Dice(1, 8);
            this.oneD1   = new Dice(1, 1);

            this.gemstones10   = new Gemstones_Tables(10);
            this.gemstones50   = new Gemstones_Tables(50);
            this.gemstones100  = new Gemstones_Tables(100);
            this.gemstones500  = new Gemstones_Tables(500);
            this.gemstones1000 = new Gemstones_Tables(1000);
            this.gemstones5000 = new Gemstones_Tables(5000);

            this.artObject25   = new Art_Objects_Tables(25);
            this.artObject250  = new Art_Objects_Tables(250);
            this.artObject750  = new Art_Objects_Tables(750);
            this.artObject2500 = new Art_Objects_Tables(2500);
            this.artObject7500 = new Art_Objects_Tables(7500);

            this.magicItemTable_A = new Magic_Item_Tables("A");
            this.magicItemTable_B = new Magic_Item_Tables("B");
            this.magicItemTable_C = new Magic_Item_Tables("C");
            this.magicItemTable_D = new Magic_Item_Tables("D");
            this.magicItemTable_E = new Magic_Item_Tables("E");
            this.magicItemTable_F = new Magic_Item_Tables("F");
            this.magicItemTable_G = new Magic_Item_Tables("G");
            this.magicItemTable_H = new Magic_Item_Tables("H");
            this.magicItemTable_I = new Magic_Item_Tables("I");

            /*After instanciate those objects (Dice & Tables: Gem, Art & Magic) then We call them.*/
            this.ChallengeRating = challengeRating;
            this.rndNbr = new Random(DateTime.Now.Millisecond);
            this.Treasure = this.challengeRating.ToString();
        }

        //==PROPERTIES
        //ChallengeRating checks if the challengeRating given to the constructor is correct.
        public short ChallengeRating
        {
            get { return this.challengeRating; }
            private set
            {
                if (value < 0 && value > 30)
                    throw new Exception("The Challenge Rating can't be inferior to 0 or superior to 30.");
                this.challengeRating = value;
            }
        }
        //Treasure will select the right TreasureHoardCRx_y to use according to the challengeRating to generate the treasure.
        public string Treasure
        {
            get { return this.treasure; }
            private set
            {
                if (Convert.ToInt16(value) <= 4)
                    this.treasure = this.TreasureHoardCR0_4();
                else if (Convert.ToInt16(value) <= 10)
                    this.treasure = this.TreasureHoardCR5_10();
                else if (Convert.ToInt16(value) <= 16)
                    this.treasure = this.TreasureHoardCR11_16();
                else
                    this.treasure = this.TreasureHoardCR17plus();
            }
        }

        //==METHODES
        /// <explanation>
        /// The "TreasureHoardx_y" methodes has only one purpuse and it is to call randomly (1d100) a GeneratingTreasure methode that will 
        /// send back as many string the treasure require to be generated.
        /// <explanation/>

        public string TreasureHoardCR0_4()
        {
            string retVal = "";

            int c/*case*/ = rndNbr.Next(1, 101);

            if (c <= 6)
                retVal += "Nothing !? Yep, nothing.";
            else if (c <= 16)
                retVal += this.GeneratingTreasure("10 gp gems", this.twoD6, "GEM", 10); 
            else if (c <= 26)
                retVal += this.GeneratingTreasure("25 art objects", this.twoD4, "ART", 25);
            else if (c <= 36)
                retVal += this.GeneratingTreasure("50 gp gems", this.twoD6, "GEM", 50);
            else if (c <= 44)
                retVal += this.GeneratingTreasure("10 gp gems", this.twoD6, "GEM", 10, "Magic items (A)", "A", this.oneD6);
            else if (c <= 52)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25, "Magic items (A)", "A", this.oneD6);
            else if (c <= 60)
                retVal += this.GeneratingTreasure("50 gp gems", this.twoD6, "GEM", 50, "Magic items (A)", "A", this.oneD6);
            else if (c <= 65)
                retVal += this.GeneratingTreasure("10 gp gems", this.twoD6, "GEM", 10, "Magic items (B)", "B", this.oneD4);
            else if (c <= 70)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD6, "ART", 25, "Magic items (B)", "B", this.oneD4);
            else if (c <= 75)
                retVal += this.GeneratingTreasure("50 gp gems", this.twoD6, "GEM", 50, "Magic items (B)", "B", this.oneD4);
            else if (c <= 78)
                retVal += this.GeneratingTreasure("10 gp gems", this.twoD6, "GEM", 10, "Magic items (C)", "C", this.oneD4);
            else if (c <= 80)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25, "Magic items (C)", "C", this.oneD4);
            else if (c <= 85)
                retVal += this.GeneratingTreasure("50 gp gems", this.twoD6, "GEM", 50, "Magic items (C)", "C", this.oneD4);
            else if (c <= 92)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25, "Magic items (F)", "F", this.oneD4);
            else if (c <= 97)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25, "Magic items (F)", "F", this.oneD4);
            else if(c <= 99)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25, "Magic items (G)", "G", this.oneD1);
            else if (c <= 100)
                retVal += this.GeneratingTreasure("50 gp gems", this.twoD4, "GEM", 50, "Magic items (G)", "G", this.oneD1);

            return retVal;
        }
        public string TreasureHoardCR5_10()
        {
            string retVal = "";

            int c/*case*/ = rndNbr.Next(1, 101);

            if (c <= 4)
                retVal += "Nothing !? Yep, nothing.";
            else if (c <= 10)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25);
            else if (c <= 16)
                retVal += this.GeneratingTreasure("50 gp gems", this.threeD6, "GEM", 50);
            else if(c <= 22) 
                retVal += this.GeneratingTreasure("100 gp gems", this.threeD6, "GEM", 100);
            else if (c <= 28)
                retVal += this.GeneratingTreasure("25O gp art objects", this.twoD4, "ART", 250);
            else if(c <= 32)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25, "Magic items(A)", "A", this.oneD6);
            else if (c <= 36)
                retVal += this.GeneratingTreasure("50 gp gems", this.threeD6, "GEM", 50, "Magic items(A)", "A", this.oneD6);
            else if (c <= 40)
                retVal += this.GeneratingTreasure("100 gp gems", this.threeD6, "GEM", 100, "Magic items(A)", "A", this.oneD6);
            else if (c <= 44)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(A)", "A", this.oneD6);
            else if (c <= 49)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25, "Magic items(B)", "B", this.oneD4);
            else if (c <= 54)
                retVal += this.GeneratingTreasure("50 gp gems", this.threeD6, "GEM", 50, "Magic items(B)", "B", this.oneD4);
            else if (c <= 59)
                retVal += this.GeneratingTreasure("100 gp gems", this.threeD6, "GEM", 100, "Magic items(B)", "B", this.oneD4);
            else if( c <= 63)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(B)", "B", this.oneD4);
            else if (c <= 66)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25, "Magic items(C)", "C", this.oneD4);
            else if (c <= 69)
                retVal += this.GeneratingTreasure("50 gp gems", this.threeD6, "GEM", 50, "Magic items(C)", "C", this.oneD4);
            else if (c <= 72)
                retVal += this.GeneratingTreasure("100 gp gems", this.threeD6, "GEM", 100, "Magic items(C)", "C", this.oneD4);
            else if (c <= 74)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(C)", "C", this.oneD4);
            else if (c <= 76)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25, "Magic items(D)", "D", this.oneD1);
            else if (c <= 78)
                retVal += this.GeneratingTreasure("50 gp gems", this.threeD6, "GEM", 50, "Magic items(D)", "D", this.oneD1);
            else if (c == 79)
                retVal += this.GeneratingTreasure("100 gp gems", this.threeD6, "GEM", 100, "Magic items(D)", "D", this.oneD1);
            else if (c == 80)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(D)", "D", this.oneD1);
            else if (c <= 84)
                retVal += this.GeneratingTreasure("25 gp art objects", this.twoD4, "ART", 25, "Magic items(F)", "F", this.oneD4);
            else if (c <= 88)
                retVal += this.GeneratingTreasure("50 gp gems", this.threeD6, "GEM", 50, "Magic items(F)", "F", this.oneD4);
            else if (c <= 91)
                retVal += this.GeneratingTreasure("100 gp gems", this.threeD6, "GEM", 100, "Magic items(F)", "F", this.oneD4);
            else if (c <= 94)
                retVal += this.GeneratingTreasure("250 gp art objects", twoD4, "ART", 250, "Magic items(F)", "F", this.oneD4);
            else if (c <= 96)
                retVal += this.GeneratingTreasure("100 gp gems", this.threeD6, "GEM", 100, "Magic items(G)", "G", this.oneD4);
            else if (c <= 98)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(G)", "G", this.oneD4);
            else if (c == 99)
                retVal += this.GeneratingTreasure("100 gp gems", this.threeD6, "GEM", 100, "Magic items(H)", "H", this.oneD1);
            else if (c == 100)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(H)", "H", this.oneD1);

            return retVal;
        }
        public string TreasureHoardCR11_16()
        {
            string retVal = "";

            int c/*case*/ = rndNbr.Next(1, 101);

            if (c <= 3)
                retVal += "Nothing !? Yep, nothing.";
            else if (c <= 6)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250);
            else if (c <= 9)
                retVal += this.GeneratingTreasure("750 gp art objects", this.twoD4, "ART", 750);
            else if (c <= 12)
                retVal += this.GeneratingTreasure("500 gp gems", this.threeD6, "GEM", 500);
            else if (c <= 15)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000);
            else if (c <= 19)
            {
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(A)", "A", this.oneD4);
                retVal += this.GeneratingTreasure("Magic items(B)", "B", this.oneD6);
            }
            else if (c <= 23)
            {
                retVal += this.GeneratingTreasure("750 gp art objects", this.twoD4, "ART", 750, "Magic items(A)", "A", this.oneD4);
                retVal += this.GeneratingTreasure("Magic items(B)", "B", this.oneD6);
            }
            else if (c <= 26)
            {
                retVal += this.GeneratingTreasure("500 gp gems", this.threeD6, "GEM", 500, "Magic items(A)", "A", this.oneD4);
                retVal += this.GeneratingTreasure("Magic items(B)", "B", this.oneD6);
            }
            else if (c <= 29)
            {
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items(A)", "A", this.oneD4);
                retVal += this.GeneratingTreasure("Magic items(B)", "B", this.oneD6);
            }
            else if (c <= 35)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(C)", "C", this.oneD6);
            else if (c <= 40)
                retVal += this.GeneratingTreasure("750 gp art objects", this.twoD4, "ART", 750, "Magic items(C)", "C", this.oneD6);
            else if (c <= 45)
                retVal += this.GeneratingTreasure("500 gp gems", this.threeD6, "GEM", 500, "Magic items(C)", "C", this.oneD6);
            else if (c <= 50)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items(C)", "C", this.oneD6);
            else if (c <= 54)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(D)", "D", this.oneD4);
            else if (c <= 58)
                retVal += this.GeneratingTreasure("750 gp art objects", this.twoD4, "ART", 750, "Magic items(D)", "D", this.oneD4);
            else if (c <= 62)
                retVal += this.GeneratingTreasure("500 gp gems", this.threeD6, "GEM", 500, "Magic items(D)", "D", this.oneD4);
            else if (c <= 66)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items(D)", "D", this.oneD4);
            else if (c <= 68)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(E)", "E", this.oneD1);
            else if (c <= 70)
                retVal += this.GeneratingTreasure("750 gp art objects", this.twoD4, "ART", 750, "Magic items(E)", "E", this.oneD1);
            else if (c <= 72)
                retVal += this.GeneratingTreasure("500 gp gems", this.twoD4, "GEM", 500, "Magic items(E)", "E", this.oneD1);
            else if (c <= 74)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items(E)", "E", this.oneD1);
            else if (c <= 76)
            {
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(F)", "F", this.oneD1);
                retVal += this.GeneratingTreasure("Magic items(G)", "G", this.oneD4);
            }
            else if (c <= 78)
            {
                retVal += this.GeneratingTreasure("750 gp art objects", this.twoD4, "ART", 750, "Magic items(F)", "F", this.oneD1);
                retVal += this.GeneratingTreasure("Magic items(G)", "G", this.oneD4);
            }
            else if (c <= 80)
            {
                retVal += this.GeneratingTreasure("500 gp gems", this.threeD6, "GEM", 500, "Magic items(F)", "F", this.oneD1);
                retVal += this.GeneratingTreasure("Magic items(G)", "G", this.oneD4);
            }
            else if (c <= 82)
            {
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items(F)", "F", this.oneD1);
                retVal += this.GeneratingTreasure("Magic items(G)", "G", this.oneD4);
            }
            else if (c <= 85)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(H)", "H", this.oneD4);
            else if (c <= 88)
                retVal += this.GeneratingTreasure("750 gp art objects", this.twoD4, "ART", 750, "Magic items(H)", "H", this.oneD4);
            else if (c <= 90)
                retVal += this.GeneratingTreasure("500 gp gems", this.threeD6, "GEM", 500, "Magic items(H)", "H", this.oneD4);
            else if (c <= 92)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items(H)", "H", this.oneD4);
            else if(c <= 94)
                retVal += this.GeneratingTreasure("250 gp art objects", this.twoD4, "ART", 250, "Magic items(I)", "I", this.oneD1);
            else if (c <= 96)
                retVal += this.GeneratingTreasure("750 gp art objects", this.twoD4, "ART", 750, "Magic items(I)", "I", this.oneD1);
            else if (c <= 98)
                retVal += this.GeneratingTreasure("500 gp gems", this.threeD6, "GEM", 500, "Magic items(I)", "I", this.oneD1);
            else if (c <= 100)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items(I)", "I", this.oneD1);

            return retVal;
        }
        public string TreasureHoardCR17plus()
        {
            string retVal = "";

            int c/*case*/ = rndNbr.Next(1, 101);

            if (c <= 2)
                retVal += "Nothing !? Yep, nothing.";
            else if (c <= 5)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items (C)", "C", this.oneD8);
            else if (c <= 8)
                retVal += this.GeneratingTreasure("2500 art objects", this.oneD10, "ART", 2500, "Magic items (C)", "C", this.oneD8);
            else if (c <= 11)
                retVal += this.GeneratingTreasure("7500 art objects", this.oneD4, "ART", 7500, "Magic items (C)", "C", this.oneD8);
            else if (c <= 14)
                retVal += this.GeneratingTreasure("5000 gp gems", this.oneD8, "GEM", 5000, "Magic items (C)", "C", this.oneD8);
            else if (c <= 22)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items (D)", "D", this.oneD6);
            else if (c <= 30)
                retVal += this.GeneratingTreasure("2500 art objects", this.oneD10, "ART", 2500, "Magic items (D)", "D", this.oneD6);
            else if (c <= 38)
                retVal += this.GeneratingTreasure("7500 art objects", this.oneD4, "ART", 7500, "Magic items (D)", "D", this.oneD6);
            else if (c <= 46)
                retVal += this.GeneratingTreasure("5000 gp gems", this.oneD8, "GEM", 5000, "Magic items (D)", "D", this.oneD6);
            else if (c <= 52)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items (E)", "E", this.oneD6);
            else if (c <= 58)
                retVal += this.GeneratingTreasure("2500 art objects", this.oneD10, "ART", 2500, "Magic items (E)", "E", this.oneD6);
            else if (c <= 63)
                retVal += this.GeneratingTreasure("7500 art objects", this.oneD4, "ART", 7500, "Magic items (E)", "E", this.oneD6);
            else if (c <= 68)
                retVal += this.GeneratingTreasure("5000 gp gems", this.oneD8, "GEM", 5000, "Magic items (E)", "E", this.oneD6);
            else if (c == 69)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items (G)", "G", this.oneD4);
            else if (c == 70)
                retVal += this.GeneratingTreasure("2500 art objects", this.oneD10, "ART", 2500, "Magic items (G)", "G", this.oneD4);
            else if (c == 71)
                retVal += this.GeneratingTreasure("7500 art objects", this.oneD4, "ART", 7500, "Magic items (G)", "G", this.oneD4);
            else if (c == 72)
                retVal += this.GeneratingTreasure("5000 gp gems", this.oneD8, "GEM", 5000, "Magic items (G)", "G", this.oneD4);
            else if (c <= 74)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items (H)", "H", this.oneD4);
            else if (c <= 76)
                retVal += this.GeneratingTreasure("2500 art objects", this.oneD10, "ART", 2500, "Magic items (H)", "H", this.oneD4);
            else if (c <= 78)
                retVal += this.GeneratingTreasure("7500 art objects", this.oneD4, "ART", 7500, "Magic items (H)", "H", this.oneD4);
            else if (c <= 80)
                retVal += this.GeneratingTreasure("5000 gp gems", this.oneD8, "GEM", 5000, "Magic items (H)", "H", this.oneD4);
            else if (c <= 85)
                retVal += this.GeneratingTreasure("1000 gp gems", this.threeD6, "GEM", 1000, "Magic items (I)", "I", this.oneD4);
            else if (c <= 90)
                retVal += this.GeneratingTreasure("2500 art objects", this.oneD10, "ART", 2500, "Magic items (I)", "I", this.oneD4);
            else if (c <= 95)
                retVal += this.GeneratingTreasure("7500 art objects", this.oneD4, "ART", 7500, "Magic items (I)", "I", this.oneD4);
            else if (c <= 100)
                retVal += this.GeneratingTreasure("5000 gp gems", this.oneD8, "GEM", 5000, "Magic items (I)", "I", this.oneD4);

            return retVal;
        }
        /// <explanation>
        /// The "GeneratingTreasure()" methodes has only one purpuse and it is to send back as many string the treasure 
        /// require to be generated. It use all the gemstones, artObjects and magicItemTableX objects and call their specific "item picker".
        /// Edit: Also it send back the total value of the gemstones or art objects generated.
        /// <explanation/>
        private string GeneratingTreasure(string descriptionGemOrArt, Dice gemOrArtDice, string gemOrArt, int worth)
        {
            int diceOutcome = gemOrArtDice.ThrowIt;
            string retVal = "";

            retVal += descriptionGemOrArt + " // Total worth: "+worth*diceOutcome +"GP"+":\n";
            for (int x = 0; x < descriptionGemOrArt.Length; x++)
                retVal += "-";
            retVal += "\n";

            if(gemOrArt.ToUpper() == "GEM")
            {
                if (worth == 10)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.gemstones10.PickGemstones() + "\n";
                else if (worth == 50)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.gemstones50.PickGemstones() + "\n";
                else if (worth == 100)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.gemstones100.PickGemstones() + "\n";
                else if (worth == 500)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.gemstones500.PickGemstones() + "\n";
                else if (worth == 1000)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.gemstones1000.PickGemstones() + "\n";
                else if (worth == 5000)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.gemstones5000.PickGemstones() + "\n";
            }
            else if (gemOrArt.ToUpper() == "ART")
            {
                if(worth == 25)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.artObject25.PickArtObjects() + "\n";
                else if (worth == 250)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.artObject250.PickArtObjects() + "\n";
                else if (worth == 750)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.artObject750.PickArtObjects() + "\n";
                else if (worth == 2500)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.artObject2500.PickArtObjects() + "\n";
                else if (worth == 7500)
                    for (int i = 1; i <= diceOutcome; i++)
                        retVal += this.artObject7500.PickArtObjects() + "\n";
            }
            return retVal;
        }
        private string GeneratingTreasure(string descriptionGemOrArt, Dice gemArtDice, string gemOrArt, int worth,string descriptionTable, string table, Dice tableDice)
        {
            string retVal = "";

            retVal += this.GeneratingTreasure(descriptionGemOrArt, gemArtDice, gemOrArt, worth);

            retVal += "\n" + descriptionTable + ":\n";
            for (int x = 0; x < descriptionTable.Length; x++)
                retVal += "-";
            retVal += "\n";

            if (table.ToUpper()=="A")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_A.PickMagicItem() + "\n";
            else if (table.ToUpper() == "B")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_B.PickMagicItem() + "\n";
            else if (table.ToUpper() == "C")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_C.PickMagicItem() + "\n";
            else if (table.ToUpper() == "D")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_D.PickMagicItem() + "\n";
            else if (table.ToUpper() == "E")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_E.PickMagicItem() + "\n";
            else if (table.ToUpper() == "F")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_F.PickMagicItem() + "\n";
            else if (table.ToUpper() == "E")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_E.PickMagicItem() + "\n";
            else if (table.ToUpper() == "F")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_F.PickMagicItem() + "\n";
            else if (table.ToUpper() == "G")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_G.PickMagicItem() + "\n";
            else if (table.ToUpper() == "H")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_H.PickMagicItem() + "\n";
            else if (table.ToUpper() == "I")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_I.PickMagicItem() + "\n";

            return retVal;
        }
        private string GeneratingTreasure(string descriptionTable, string table, Dice tableDice)
        {
            string retVal = "";

            retVal += "\n" + descriptionTable + ":\n";
            for (int x = 0; x < descriptionTable.Length; x++)
                retVal += "-";
            retVal += "\n";

            if (table.ToUpper() == "A")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_A.PickMagicItem() + "\n";
            else if (table.ToUpper() == "B")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_B.PickMagicItem() + "\n";
            else if (table.ToUpper() == "C")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_C.PickMagicItem() + "\n";
            else if (table.ToUpper() == "D")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_D.PickMagicItem() + "\n";
            else if (table.ToUpper() == "E")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_E.PickMagicItem() + "\n";
            else if (table.ToUpper() == "F")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_F.PickMagicItem() + "\n";
            else if (table.ToUpper() == "E")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_E.PickMagicItem() + "\n";
            else if (table.ToUpper() == "F")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_F.PickMagicItem() + "\n";
            else if (table.ToUpper() == "G")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_G.PickMagicItem() + "\n";
            else if (table.ToUpper() == "H")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_H.PickMagicItem() + "\n";
            else if (table.ToUpper() == "I")
                for (int diceOutcome = 1; diceOutcome <= tableDice.ThrowIt; diceOutcome++)
                    retVal += this.magicItemTable_I.PickMagicItem() + "\n";

            return retVal;
        }
    }
}
