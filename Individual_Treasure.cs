using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Dnd5_TreasureGeneratorApp
{
    class Individual_Treasure
    {
        /// <summary>
        /// - The Individual_Treasure has one function:
        ///   To pick randomly a string (an idividual treasure, mainly money for now) from a string array whose entries 
        ///   come from a .txt file whose file path has been specified.
        ///   To, finally, send back a string, the money the individual has on him.
        /// </summary>

        #region STATIC ELEMENTS
        #endregion
        #region STATIC VARIABLES
        #endregion
        static private string filePath_CR0_4;
        static private string filePath_CR5_10;
        static private string filePath_CR11_16;
        static private string filePath_CR17plus;

        #region STATIC CONSTRUCTORS - PROPERTIES - METHODES
        #endregion
        static Individual_Treasure()
        {
            Individual_Treasure.filePath_CR0_4    = AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Individual_Treasure\Individual_Treasure_CR0-4.txt";
            Individual_Treasure.filePath_CR5_10   = AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Individual_Treasure\Individual_Treasure_CR5-10.txt";
            Individual_Treasure.filePath_CR11_16  = AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Individual_Treasure\Individual_Treasure_CR11-16.txt";
            Individual_Treasure.filePath_CR17plus = AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Individual_Treasure\Individual_Treasure_CR17+.txt";
        }

        //===========================================

        #region INSTANCE ELEMENTS
        #endregion
        #region INSTANCE VARIABLES
        #endregion
        private Random rndNbr;
        private string sourceFilePath;
        private short  challengeRating;

        #region INSTANCE CONSTRUCTORS - PROPERTIES - METHODES
        #endregion
        //===CONSTRUCTOR
        public Individual_Treasure(short challengeRating)
        {
            this.rndNbr          = new Random(DateTime.Now.Millisecond);
            this.ChallengeRating = challengeRating;               
            this.SourceFilePath        = this.challengeRating.ToString();           
                                                                 
        }

        //===METHODES
        //Check if the CR is correct.
        private short ChallengeRating
        {
            get { return this.challengeRating; }
            set
            {
                if (value < 0 || value > 30)
                    throw new Exception("The Challenge Rating can't be inferior to 0 or superior to 30.");
                this.challengeRating = value;
            }
        }
        //Pick the right file path according to the CR that was given to the instance constructor.
        public string SourceFilePath /* to a .txt file located in the ressources folder of that project. The .txt file contains a succession 
                                      * of individual treasure seperated by a ";".
                                      * (the ";" is will be useful in the GenerateTreasure() methode just below). */
        {
            get { return this.sourceFilePath; }
            private set
            {
                short temp = Convert.ToInt16(value);
                if (temp < 5)
                    this.sourceFilePath = Individual_Treasure.filePath_CR0_4;
                else
                {
                    if (temp < 11)
                        this.sourceFilePath = Individual_Treasure.filePath_CR5_10;
                    else
                    {
                        if (temp < 17)
                            this.sourceFilePath = Individual_Treasure.filePath_CR11_16;
                        else
                        {
                            this.sourceFilePath = Individual_Treasure.filePath_CR17plus;
                        }
                    }
                }
            }
        }
        public string GenerateTreasure()
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
