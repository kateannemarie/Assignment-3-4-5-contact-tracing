namespace ContactTracingApp.Dalangin
{
    public partial class logbookForm : Form
    {
        public logbookForm()
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
            StreamWriter firstFormFile = File.CreateText("User's-Credentials.txt");
            firstFormFile.WriteLine("Username : " + usernameTextBox.Text);
            firstFormFile.WriteLine("Password: " + passwordTextBox.Text);
            firstFormFile.WriteLine("");
            firstFormFile.Close();

            Health_Declaration_Form hdf = new Health_Declaration_Form();
            hdf.Show();
            this.Hide();
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


        }
    }
}