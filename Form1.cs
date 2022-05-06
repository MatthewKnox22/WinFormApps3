namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string shift;
            if (day1.Checked)
            {
                shift = "1";
            }
            else
            {
                shift = "2";
            }
            richTextBox1.Text = ("Employee Name:" + textBox1.Text + "\nEmployee Number:" + textBox2.Text + "\nShift: " + shift + "\nHourly Pay Rate: $" + textBox3.Text + ".00");
        }
    }
}