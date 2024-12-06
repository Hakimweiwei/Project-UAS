using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS___Sewa_Iphone
{
    public partial class Form1Login : Form
    {
        Form2 form2 = new Form2();
        public Form1Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
