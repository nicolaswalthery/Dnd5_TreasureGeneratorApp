using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dnd5_TreasureGeneratorApp
{
    class Table_Manager
    {
        /// <summary>
        /// The Table_Manage class has 3 functionnalities:
        /// 1] Adding lines to the text file using the methode "AddLine".
        /// 2] Deleting all the text that is in the .txt file with the "Delete" methode.
        /// 3] The CodeCreator methode will write the lines of codes (exemple: individualTreasureCR0_4.AddLine("3d6 (10) CP ;", 30); 
        ///    that will add lines to a text file (AddLine methode). 
        ///    Then i'll paste from the .txt file where all the lines are and paste it in the Program class.
        ///    Then those lines (AddLine) will create the .txt fill that its file path will be use by other classes (Individual_Treasures, Magic_Item_Tables,
        ///    Gemstones_Tables, Art_Objects_Tables) to randomly pick an magic item, a gemstone, etc
        /// The Table_Manager class will update the text file where all the data of the tables will be stock.
        /// The class gives the possibility to add lines to a text file or delete all line of a text file.
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
        //filePath will store the location of a file in which we want to write in.
        private string destinationFilePath;

        #region INSTANCE CONSTRUCTORS - PROPERTIES - METHODES
        #endregion
        //==Constructor
        //Table_Manager is the constructor and it instanciates only the path of the file that we want to add text to it.
        public Table_Manager(string destinationFilePath)
        {
            this.destinationFilePath = destinationFilePath;
        }

        //==Methodes
        //The methode "AddLine" allows us to add lines to the text file.
        public void AddLine(string txt, short howManyTimes)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(this.destinationFilePath, true))
        
                for (int cpt = 0; cpt < howManyTimes; cpt++)
                    file.Write(txt);
        }
        //Delete all the text that is in the source file.
        public void DeleteAll()
        {
            string text = string.Empty;
            System.IO.File.WriteAllText(this.destinationFilePath, text);
        }

        // The next methode must split the words of a string variable and count them. 
        // In order to send the word an how many times it appears in the AddLine methode.
        public void CodeCreator(string tableName)
        {
            // 1 ] Get the "destinationFilePath" and put it in the string variable: "text".
            string text = File.ReadAllText(this.destinationFilePath); /*Here, the term "destination" might be used incorrectly, this is the file path of the .txt containing the content of the tables.*/
            // 2 ] Divide the string variable 'text" every ";" using .Split and store every division in a string array, here "lines".
            // 2']We use .Split (spliting the words of a string variable) because we need to know how many occurences there are of them. 
            string[] lines = text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            // 3 ]Deleting here to be sure that the file doesn't already exist.
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Code_Writer.txt");

            //4 ] The lines of codes to be paste are created here.
            int alternance = 0; //Only here to switch between the two File.AppendAllText, one after the other. In order to write the code. :)
            foreach (string line in lines)
            {
                if (alternance == 0)/*Write the first part of the code to be copy/paste in Program.cs.*/
                {
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Code_Writer.txt", tableName+".AddLine(\"" + line+";\",");
                    alternance = 1;
                }
                else               /*Write the second part of the code to be copy/paste in Program.cs.*/
                {

                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Ressources\Default_Content\Code_Writer.txt", line + ");\n");
                    alternance = 0;
                }
                    
            }
        }
        public void CodeCreator(string destinationFolderPath, string fileName, string tableName)
        {
            // 1 ] Get the "destinationFilePath" and put it in the string variable: "text".
            string text = File.ReadAllText(this.destinationFilePath); /*Here, the term "destination" might be used incorrectly, this is the file path of the .txt containing the content of the tables.*/
            // 2 ] Divide the string variable 'text" every ";" using .Split and store every division in a string array, here "lines".
            // 2']We use .Split (spliting the words of a string variable) because we need to know how many occurences there are of them.
            string[] lines = text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            // 3 ]Deleting here to be sure that the file doesn't already exist.
            File.Delete(destinationFolderPath + fileName);

            //4 ] The lines of codes to be paste are created here.
            int alternance = 0; //Only here to switch between the two File.AppendAllText, one after the other. In order to write the code. :)
            foreach (string line in lines)
            {
                if (alternance == 0)/*Write the first part of the code to be copy/paste in Program.cs.*/
                {
                    File.AppendAllText(destinationFolderPath+fileName, tableName + ".AddLine(\"" + line + ";\",");
                    alternance = 1;
                }
                else               /*Write the second part of the code to be copy/paste in Program.cs.*/
                {
                    File.AppendAllText(destinationFolderPath+fileName, line + ");\n");
                    alternance = 0;
                }
            }
        }
    }
}
