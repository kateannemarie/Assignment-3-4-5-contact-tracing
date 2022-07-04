using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace ContactTracingApp.Dalangin
{
    public partial class Health_Declaration_Form : Form
    {

        public static Health_Declaration_Form instance;
        public TextBox nameTxtBx;
        public TextBox ageTxtBx;
        public TextBox contactaddTxtBx;
        public TextBox contactnumTxtBx;
        public TextBox contactemTxtBx;
        public RadioButton radiobuttonF;
        public RadioButton radiobuttonM;
        public Health_Declaration_Form()
        {
            InitializeComponent();
            instance = this;
            nameTxtBx = nameTextBox2;
            ageTxtBx = ageTextBox;
            contactaddTxtBx = contactaddressTextBox;
            contactnumTxtBx = contactnumberTextBox2;
            contactemTxtBx = emailaddressTextBox;
            radiobuttonF = femaleRadioButton;
            radiobuttonM = maleRadioButton;
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

            if (femaleRadioButton.Checked)
            {
                Sex = femaleRadioButton.Text;
            }

            if (maleRadioButton.Checked)
            {
                Sex = maleRadioButton.Text;
            }

            string Symptoms = "";

            if (feverCheckBox.Checked)
            {
                Symptoms += "\"Fever\"";
            }

            if (headacheCheckBox.Checked)
            {
                Symptoms += "\"Headache\"";
            }

            if (sorethroatCheckBox.Checked)
            {
                Symptoms += "\"Sore Throat\"";
            }

            if (shortnessofbreathCheckBox.Checked)
            {
                Symptoms += "\"Difficulty or Shortness of Breath\"";
            }

            if (coughCheckBox.Checked)
            {
                Symptoms += "\"Cough\"";
            }

            if (fatigueCheckBox.Checked)
            {
                Symptoms += "\"Fatigue\"";
            }

            if (bodyachesCheckBox.Checked)
            {
                Symptoms += "\"Body Aches\"";
            }

            if (lossoftasteCheckBox.Checked)
            {
                Symptoms += "\"Loss of Taste/Smell\"";
            }

            if (diarrheaCheckBox.Checked)
            {
                Symptoms += "\"Diarrhea\"";
            }

            if (nauseaCheckBox.Checked)
            {
                Symptoms += "\"Nausea\"";
            }

            if (bodyweaknessCheckBox.Checked)
            {
                Symptoms += "\"Body Weakness\"";
            }

            if (runnynoseCheckBox.Checked)
            {
                Symptoms += "\"Runny Nose\"";
            }

            string numberOne = "";
            if (yesOne.Checked)
            {
                numberOne = " did visit any health worker, hospital, or clinic during the past 14 days.";
            }
            if (noOne.Checked)
            {
                numberOne = " did not visit any health worker, hospital, or clinic during the past 14 days.";
            }

            string numberTwo = "";
            if (yesTwo.Checked)
            {
                numberTwo = " was confined in a hospital or clinic during the past 14 days.";
            }
            if (noTwo.Checked)
            {
                numberTwo = " was not confined in a hospital or clinic during the past 14 days.";
            }

            string numberThree = "";
            if (yesTwo.Checked)
            {
                numberThree = " have anyone such as household member/s or close contact/s who are currently having fever, cough and/or respiratory problems.";
            }
            if (noTwo.Checked)
            {
                numberThree = " doesn't have anyone such as household member/s or close contact/s who are currently having fever, cough and/or respiratory problems.";
            }

            string numberFour = "";
            if (yesFour.Checked)
            {
                numberFour = " in the last 14 days, has been in close contact or exposed to any person suspected of COVID-19.";
            }
            if (noFour.Checked)
            {
                numberFour = " in the last 14 days, was not in close contact or exposed to any person suspected of COVID-19.";
            }

            string numberFive = "";
            if (yesFive.Checked)
            {
                numberFive = " has been in Face-to-face contact with a confirmed case within 1 meter and for more than 15 minutes.";
            }
            if (noFive.Checked)
            {
                numberFive = " has not been in Face-to-face contact with a confirmed case within 1 meter and for more than 15 minutes.";
            }

            string numberSix = "";
            if (yesSix.Checked)
            {
                numberSix = " in the last 14 days, has been in contact with a person confirmed with COVID-19.";
            }
            if (noSix.Checked)
            {
                numberSix = " in the last 14 days, was not in contact with a person confirmed with COVID-19.";
            }


            string[] data = { "Date: " + datePicker.Text, "Name: " + nameTextBox2.Text, "Sex: " + Sex, "Age: " + ageTextBox.Text + " years old", "Contact Address: " + contactaddressTextBox.Text, "Mobile No./Telephone No.: " + contactnumberTextBox2.Text, "Email Address: " + emailaddressTextBox.Text, "Symptoms are: " + Symptoms, nameTextBox2.Text + numberOne, nameTextBox2.Text + numberTwo, nameTextBox2.Text + numberThree, nameTextBox2.Text + "," + numberFour, nameTextBox2.Text + numberFive, nameTextBox2.Text + "," + numberSix, " " };

            StreamWriter healthdeclarationformFile;
            healthdeclarationformFile = File.AppendText("Health-Declaration-Data-22.txt");
            foreach (string str in data)
            {
                healthdeclarationformFile.WriteLine(str);
            }
            healthdeclarationformFile.Close();


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

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            MessageBox.Show("All fields cleared");
        }

        public void reset()
        {
            datePicker.Text = "";
            nameTextBox2.Text = "";
            femaleRadioButton.Checked = false;
            maleRadioButton.Checked = false;
            ageTextBox.Text = "";
            contactaddressTextBox.Text = "";
            contactnumberTextBox2.Text = "";
            emailaddressTextBox.Text = "";
            feverCheckBox.Checked = false;
            headacheCheckBox.Checked = false;
            sorethroatCheckBox.Checked = false;
            shortnessofbreathCheckBox.Checked = false;
            coughCheckBox.Checked = false;
            fatigueCheckBox.Checked = false;
            bodyachesCheckBox.Checked = false;
            lossoftasteCheckBox.Checked = false;
            diarrheaCheckBox.Checked = false;
            nauseaCheckBox.Checked = false;
            bodyachesCheckBox.Checked = false;
            bodyweaknessCheckBox.Checked = false;
            runnynoseCheckBox.Checked = false;
            yesOne.Checked = false;
            noOne.Checked = false;
            yesTwo.Checked = false;
            noTwo.Checked = false;
            yesThree.Checked = false;
            yesFour.Checked = false;
            noThree.Checked = false;
            noFour.Checked = false;
            yesFive.Checked = false;
            noFive.Checked = false;
            yesSix.Checked = false;
            noSix.Checked = false;
        }


        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void qrcodeButton_Click(object sender, EventArgs e)
        {
            Scanner_Form scannerForm = new Scanner_Form();
            scannerForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string Sex = "";

            if (femaleRadioButton.Checked)
            {
                Sex = femaleRadioButton.Text;
            }

            if (maleRadioButton.Checked)
            {
                Sex = maleRadioButton.Text;
            }



            var fulldata = nameTextBox2.Text + "\n"
                + Sex + "\n"
                + ageTextBox.Text + "\n"
                + contactaddressTextBox.Text + "\n"
                + contactnumberTextBox2.Text + "\n"
                + emailaddressTextBox.Text;

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData datainfo = qr.CreateQrCode(fulldata, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(datainfo);
            showQRPictureBox.Image = code.GetGraphic(7);
        }

    }
}
