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
            string Gender = "";

            if(femaleRadioButton.Checked)
            {
                Gender = femaleRadioButton.Text;
            }

            if(maleRadioButton.Checked)
            {
                Gender = maleRadioButton.Text;
            }


            StreamWriter healthdeclarationformFile = new StreamWriter(@"C:\Users\kitka\Downloads\Health-Declaration-Form.txt");
            healthdeclarationformFile.WriteLine("Name: " + nameTextBox2.Text);
            healthdeclarationformFile.WriteLine("Sex: " + Gender);
            healthdeclarationformFile.Close();
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
    }
}
