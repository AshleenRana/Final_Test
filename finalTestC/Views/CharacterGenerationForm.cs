using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
