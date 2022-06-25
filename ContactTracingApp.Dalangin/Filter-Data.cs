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
    public partial class Filter_Data : Form
    {


        public Filter_Data()
        {
            InitializeComponent();
        }


        private void Filter_Data_Load(object sender, EventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            
        }

        private void showfilteredListView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void datefilterPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ReviewForm reviewForm = new ReviewForm();
            reviewForm.Show();
            this.Hide();
        }

        private void Filter_Data_Load_1(object sender, EventArgs e)
        {

        }

        private void filterLabel_Click(object sender, EventArgs e)
        {

        }

        private void twentyButton_Click(object sender, EventArgs e)
        {
            datalistBox.Items.Clear();

            string healthDataFile = "Health-Declaration-Data.txt";
            List<string> healthList = new List<string>();
            healthList = File.ReadAllLines(healthDataFile).ToList();

            foreach (string line in healthList)
            {
                datalistBox.Items.Add(line);
            }
            File.WriteAllLines(healthDataFile, healthList.ToArray());
        }

        private void twentyoneButton_Click(object sender, EventArgs e)
        {
            datalistBox.Items.Clear();

            string healthDataFile = "Health-Declaration-Data-21.txt";
            List<string> healthList = new List<string>();
            healthList = File.ReadAllLines(healthDataFile).ToList();

            foreach (string line in healthList)
            {
                datalistBox.Items.Add(line);
            }
            File.WriteAllLines(healthDataFile, healthList.ToArray());
        }

        private void twentytwoButton_Click(object sender, EventArgs e)
        {
            datalistBox.Items.Clear();

            string healthDataFile = "Health-Declaration-Data-22.txt";
            List<string> healthList = new List<string>();
            healthList = File.ReadAllLines(healthDataFile).ToList();

            foreach (string line in healthList)
            {
                datalistBox.Items.Add(line);
            }
            File.WriteAllLines(healthDataFile, healthList.ToArray());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

