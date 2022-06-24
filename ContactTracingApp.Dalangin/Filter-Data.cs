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
        List<DateOnly> dateofForm = new List<DateOnly>();
        List<ListViewItem> items = new List<ListViewItem>();

        public Filter_Data()
        {
            InitializeComponent();
        }

        private void Filter_Data_Load(object sender, EventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            DateOnly chooseDate = DateOnly.FromDateTime(datefilterPicker.Value);
            showfilteredListView.Items.Clear();
            for (int i = 0; i < dateofForm.Count; i++)
            {
                if (chooseDate.CompareTo(dateofForm[i]) == 0)
                {
                    showfilteredListView.Items.Add(items[i]);
                }
            }

            //string healthDataFile = "Health-Declaration-Data.txt";
            //List<string> healthList = new List<string>();
            //healthList = File.ReadAllLines(healthDataFile).ToList();

            //foreach (string line in healthList)
            //{
            //    showfilteredListView.Items.Add(line);
            //}
            //File.WriteAllLines(healthDataFile, healthList.ToArray());
        }

        private void showfilteredListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

