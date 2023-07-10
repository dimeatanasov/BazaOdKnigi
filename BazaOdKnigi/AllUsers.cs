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
    public partial class AllUsers : Form
    {
        public List<User> Users { get; set; }
        public AllUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            Users.ForEach(user =>
            {
                string userString = user.username + " - " + user.EMBG;
                listBox1.Items.Add(userString);
            });
        }
    }
}
