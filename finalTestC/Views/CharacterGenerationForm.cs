﻿using System;
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
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            //generating first name of character
            Random random = new Random();
            string[] FirstName = File.ReadAllLines("firstNames.txt");
            int FirstNameIndex = random.Next(FirstName.Length);
            FirstNameDataLabel.Text = FirstName[FirstNameIndex];

            //generating last name of character
            Random rand = new Random();
            string[] LastName = File.ReadAllLines("lastNames.txt");
            int LastNameIndex = rand.Next(LastName.Length);
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
            Random random = new Random();

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
    }
}
