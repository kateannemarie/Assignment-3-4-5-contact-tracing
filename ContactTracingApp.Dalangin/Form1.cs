namespace ContactTracingApp.Dalangin
{
    public partial class contacttracingForm : Form
    {
        public contacttracingForm()
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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void savedataButton_Click(object sender, EventArgs e)
        {
            StreamWriter firstFormFile = File.AppendText(@"C:\Users\kitka\Downloads\First-Form.txt");
            firstFormFile.WriteLine("Date : " + dateandtimePicker.Text);
            firstFormFile.WriteLine("Name : " + nameTextBox.Text);
            firstFormFile.WriteLine("Address: " + addressTextBox.Text);
            firstFormFile.WriteLine("Contact Number: " + contactnumberTextBox.Text);
            firstFormFile.WriteLine("");
            firstFormFile.Close();
        }
    }
}