using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Dnd5_TreasureGeneratorApp
{
    class Magic_Item_Tables
    {
        /// <summary>
        /// - The Magic_Item_Tables has one function:
        ///   To pick randomly a string (a magic item name) from a string array whose entries 
        ///   come from a .txt file whose file path has been specified.
        ///   To, finally, send back a string, the name of a magic item.
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
        private Random rndNbr;
        private string sourceFilePath;
        private string tableLetter;

        #region INSTANCE CONSTRUCTORS - PROPERTIES - METHODES
        #endregion
        //==CONSTRUCTOR
        public Magic_Item_Tables(string tableLetter)
        {
            this.rndNbr            = new Random(DateTime.Now.Millisecond);
            this.TableLetter       = tableLetter;                         
            this.SourceFilePath    = this.tableLetter;                                                                              
        }

        //==METHODES
        //Check if the letter of the magic item table is correct.
        public string TableLetter
        {
            get { return this.tableLetter; }
            private set
            {
                value = value.ToUpper().Trim();
                if (!Regex.Match(value, "^[A-I]{1}$").Success)
                    throw new Exception("The letter of the table is incorrect.");
                this.tableLetter = value;
            }
        }
        //Pick the right file path according to the letter that was given to the instance constructor.
        public string SourceFilePath /* to a .txt file located in the ressources folder of that project. The .txt file contains a succession 
                                      * of magic item names seperated by a ";".
                                      * (the ";" is will be useful in the PickMagicItem() methode just below). */
        {
            get { return this.sourceFilePath; }
            private set
            {
                this.sourceFilePath = AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Magic_Item_Tables\Table_" + this.TableLetter + ".txt";
            }
        }

        //==METHODES
        public string PickMagicItem()
        {
            int nbr;

            // 1] Get the "sourceFilePath" and put it in the string variable: "tableContentTxt".
            string tableContentTxt = File.ReadAllText(this.sourceFilePath);
            // 2] Divide the string variable "tableContentTxt" every ";" using .Split and store every division in a string array, here "tableContentArray".
            string[] tableContentArray = tableContentTxt.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            // 3] Generate a random number between 0 and the total number of entries of "tableContentArray".
            nbr = this.rndNbr.Next(0, tableContentArray.Length);
            // 4]Use the random number (nbr) that we've just generated to pick an entry from "tableContentArray" and return it as a string.
            return tableContentArray[nbr];
        }
    }
}
