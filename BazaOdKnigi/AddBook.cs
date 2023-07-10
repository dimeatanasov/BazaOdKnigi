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
    public partial class AddBook : Form
    {
        public Book Book { get; set; }
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                Book = new Book();
                Book.title = textBox1.Text;
                Book.numberOfBooks = Convert.ToInt16(textBox2.Text);
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
