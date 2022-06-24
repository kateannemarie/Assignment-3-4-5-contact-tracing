using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracingApp.Dalangin
{
    public partial class Health_Declaration_Form : Form
    {
        public Health_Declaration_Form()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void namelLabel2_Click(object sender, EventArgs e)
        {
         
        }

        private void yesTwo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void yesOne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void thirdQuestion_Click(object sender, EventArgs e)
        {

        }

        private void savedataButton2_Click(object sender, EventArgs e)
        {
            string Sex = "";

            if(femaleRadioButton.Checked)
            {
                Sex = femaleRadioButton.Text;
            }

            if(maleRadioButton.Checked)
            {
                Sex = maleRadioButton.Text;
            }

            string Symptoms = "";

            if(feverCheckBox.Checked)
            {
                Symptoms += "\"Fever\"";
            }

            if(headacheCheckBox.Checked)
            {
                Symptoms += "\"Headache\"";
            }

            if(sorethroatCheckBox.Checked)
            {
                Symptoms += "\"Sore Throat\"";
            }

            if(shortnessofbreathCheckBox.Checked)
            {
                Symptoms += "\"Difficulty or Shortness of Breath\"";
            }

            if(coughCheckBox.Checked)
            {
                Symptoms += "\"Cough\"";
            }

            if(fatigueCheckBox.Checked)
            {
                Symptoms += "\"Fatigue\"";
            }

            if(bodyachesCheckBox.Checked)
            {
                Symptoms += "\"Body Aches\"";
            }

            if (lossoftasteCheckBox.Checked)
            {
                Symptoms += "\"Loss of Taste/Smell\"";
            }

            if(diarrheaCheckBox.Checked)
            {
                Symptoms += "\"Diarrhea\"";
            }

            if(nauseaCheckBox.Checked)
            {
                Symptoms += "\"Nausea\"";
            }

            if(bodyweaknessCheckBox.Checked)
            {
                Symptoms += "\"Body Weakness\"";
            }

            if(runnynoseCheckBox.Checked)
            {
                Symptoms += "\"Runny Nose\"";
            }

            string numberOne = "";
            if(yesOne.Checked)
            {
                numberOne = " did visit any health worker, hospital, or clinic during the past 14 days.";
            }
            if(noOne.Checked)
            {
                numberOne = " did not visit any health worker, hospital, or clinic during the past 14 days.";
            }

            string numberTwo = "";
            if(yesTwo.Checked)
            {
                numberTwo = " was confined in a hospital or clinic during the past 14 days.";
            }
            if(noTwo.Checked)
            {
                numberTwo = " was not confined in a hospital or clinic during the past 14 days.";
            }

            string numberThree = "";
            if(yesTwo.Checked)
            {
                numberThree = " have anyone such as household member/s or close contact/s who are currently having fever, cough and/or respiratory problems.";
            }
            if(noTwo.Checked)
            {
                numberThree = " doesn't have anyone such as household member/s or close contact/s who are currently having fever, cough and/or respiratory problems.";
            }

            string numberFour = "";
            if(yesFour.Checked)
            {
                numberFour = " in the last 14 days, has been in close contact or exposed to any person suspected of COVID-19.";
            }
            if(noFour.Checked)
            {
                numberFour = " in the last 14 days, was not in close contact or exposed to any person suspected of COVID-19.";
            }

            string numberFive = "";
            if(yesFive.Checked)
            {
                numberFive = " has been in Face-to-face contact with a confirmed case within 1 meter and for more than 15 minutes.";
            }
            if(noFive.Checked)
            {
                numberFive = " has not been in Face-to-face contact with a confirmed case within 1 meter and for more than 15 minutes.";
            }

            string numberSix = "";
            if(yesSix.Checked)
            {
                numberSix = " in the last 14 days, has been in contact with a person confirmed with COVID-19.";
            }
            if(noSix.Checked)
            {
                numberSix = " in the last 14 days, was not in contact with a person confirmed with COVID-19.";
            }

            //for da try ang ferson
            string[] data = { "Date: " + datePicker.Text, "Name: " + nameTextBox2.Text, "Sex: " + Sex, "Age: " + ageTextBox.Text + " years old", "Contact Address: " + contactaddressTextBox.Text, "Mobile No./Telephone No.: " + contactnumberTextBox2.Text, "Email Address: " + emailaddressTextBox.Text, "Symptoms are: " + Symptoms, nameTextBox2.Text + numberOne, nameTextBox2.Text + numberTwo, nameTextBox2.Text + numberThree, nameTextBox2.Text + "," + numberFour, nameTextBox2.Text + numberFive, nameTextBox2.Text + "," + numberSix };

            StreamWriter healthdeclarationformFile;
            healthdeclarationformFile = File.CreateText("Health-Declaration-Data.txt");
            foreach (string str in data)
            {
                healthdeclarationformFile.WriteLine(str);
            }
            healthdeclarationformFile.Close();
            this.Close();

            ReviewForm reviewForm = new ReviewForm();
            reviewForm.Show();
            this.Hide();


        }

        private void sexGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Health_Declaration_Form_Load(object sender, EventArgs e)
        {

        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void feverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void yesornoGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void yesSix_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
