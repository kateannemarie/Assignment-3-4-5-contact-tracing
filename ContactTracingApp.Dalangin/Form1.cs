namespace ContactTracingApp.Dalangin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contactnumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void healthdeclarationButton_Click(object sender, EventArgs e)
        {
            Health_Declaration_Form hdf = new Health_Declaration_Form();
            hdf.Show();
        }
    }
}