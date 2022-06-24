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
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
        }

        private void reviewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string healthDataFile = "Health-Declaration-Data.txt";
            List<string> healthList = new List<string>();
            healthList = File.ReadAllLines(healthDataFile).ToList();

            foreach (string line in healthList)
            {
                reviewListBox.Items.Add(line);
            }
            File.WriteAllLines(healthDataFile, healthList.ToArray());
        }
    }
}
