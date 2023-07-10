using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaOdKnigi
{
    public partial class AddUser : Form
    {
        public User User { get; set; }
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                User = new User();
                User.username = textBox1.Text;
                User.EMBG = textBox2.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Insert values!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
