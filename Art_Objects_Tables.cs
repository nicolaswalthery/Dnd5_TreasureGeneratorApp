using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dnd5_TreasureGeneratorApp
{
    class Art_Objects_Tables
    {
        /// <summary>
        /// - The Art_Objects_Tables has one function:
        ///   To pick randomly a string (an art object description) from a string array whose entries 
        ///   come from a .txt file whose file path has been specified.
        ///   To, finally, send back a string, the description of an art object.
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
        private int worth;

        #region INSTANCE CONSTRUCTORS - PROPERTIES - METHODES
        #endregion
        //==CONSTRUCTOR
        public Art_Objects_Tables(int worth)
        {
            this.rndNbr         = new Random(DateTime.Now.Millisecond);
            this.Worth          = worth;                         
            this.SourceFilePath = this.worth.ToString();
        }

        //==PROPERTIES
        //Check if the value of the art object table is correct.
        public int Worth
        {
            get { return this.worth; }
            private set
            {
                if (value != 25 && value != 250 && value != 750 && value != 2500 && value != 7500)
                    throw new Exception("The worth is incorrect. It must be 25, 250, 750, 2500 or 7500.");
                this.worth = value;
            }
        }
        //Pick the right file path according to the worth value that was given to the instance constructor.
        public string SourceFilePath /* to a .txt file located in the ressources folder of that project. The .txt file contains a succession 
                                      * of art objects descriptions seperated by a";".
                                      * (The ";" is will be useful in the PickArtObjects() methode just below). */
        {
            get { return this.sourceFilePath; }
            private set
            {
                this.sourceFilePath = AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Art_Objects_Tables\Art_Objects_" + this.worth+"GP.txt";
            }
        }

        //==METHODES
        public string PickArtObjects()
        {
            int nbr;

            // 1] Get the "sourceFilePath" and put it in a string variable.
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
