using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integral_Figures
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Functions frm = new Functions();
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Rules form2 = new Rules();
            form2.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
