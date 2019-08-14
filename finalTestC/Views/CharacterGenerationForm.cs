using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
/*
 *STUDENT NAME:ASHLEEN RANA
 * STUDENT ID:301044914
 * DESCRIPTION:THIS IS main form
 * */
namespace finalTestC.Views
{

    public partial class CharacterGenerationForm : finalTestC.Views.MasterForm
    {
        Random random = new Random();

        public CharacterGenerationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is event handler for the back button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex!=0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        /// This is event handler for the next button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count-1)
            {
                MainTabControl.SelectedIndex++;
            }
            if(MainTabControl.SelectedIndex==3)
            {
                
            }
        }

        public static void generateCharacterSheet(object sender,EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("FinalData.txt"))
            {
                FirstNameFinalLabel.Text = Program.characterForm.FirstNameDataLabel;
                LastNameFinalLabel.Text = Program.characterForm.LastNameDataLabel;
            }
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }
        
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            //generating first name of character
            
            string[] FirstName = File.ReadAllLines("firstNames.txt");
            int FirstNameIndex = random.Next(FirstName.Length);
            FirstNameDataLabel.Text = FirstName[FirstNameIndex];

            //generating last name of character
            
            string[] LastName = File.ReadAllLines("lastNames.txt");
            int LastNameIndex = random.Next(LastName.Length);
            LastNameDataLabel.Text = LastName[LastNameIndex];
        }
        /// <summary>
        /// This is event handler for ability generation event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            //generating random numbers for abilities
            
            int Strengthnumber = random.Next(15);
            StrengthDataLabel.Text = Strengthnumber.ToString();

            
            int Dexteritynumber = random.Next(15);
            DexterityDataLabel.Text = Dexteritynumber.ToString();

            
            int Endurancenumber = random.Next(15);
            EnduranceDataLabel.Text = Endurancenumber.ToString();

            
            int Intellectnumber = random.Next(15);
            IntellectDataLabel.Text = Intellectnumber.ToString();

            
            int Edunumber = random.Next(15);
            EducationDataLabel.Text = Edunumber.ToString();

            
            int Socialnumber = random.Next(15);
            SocialDataLabel.Text = Socialnumber.ToString();
        }
        //list created
        public static List<string> SkillsList = new List<string>();
        //loadskill event
        public static void LoadSkills()
        {
           
            using(StreamReader reader= new StreamReader("Skills.txt"))
            {
                string skill = reader.ReadLine();
                while (skill!=null)
                {
                    Console.WriteLine(skill);
                }
            }
        }

        //skills generation 
        private void GenerateSkillsButton_Click(object sender, EventArgs e)
        {
            int skill1Index = random.Next(SkillsList.Count);
            FirstSkillDataLabel.Text = SkillsList[skill1Index];

            int skill2Index = random.Next(SkillsList.Count);
            SecondSkillDataLabel.Text = SkillsList[skill2Index];

            int skill3Index = random.Next(SkillsList.Count);
            ThirdSkillDataLabel.Text = SkillsList[skill3Index];

            int skill4Index = random.Next(SkillsList.Count);
            FourthSkillDataLabel.Text = SkillsList[skill4Index];
        }
        /// <summary>
        /// This is event handler for Character generation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharacterGenerationForm_Load(object sender, EventArgs e)
        {
            LoadSkills();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog();
        }

        private void saveFileDialog()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// This is event handler for exit event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
