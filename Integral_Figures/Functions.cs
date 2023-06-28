namespace Integral_Figures
{
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Hide();
                oneFunction form2 = new oneFunction();
                form2.Show();
            }
            if (radioButton2.Checked)
            {
                this.Hide();
                twoFunctions form3 = new twoFunctions();
                form3.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form3 = new Menu();
            form3.Show();
        }
    }
}