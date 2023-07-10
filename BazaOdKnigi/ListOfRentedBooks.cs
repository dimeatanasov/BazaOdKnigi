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
    public partial class ListOfRentedBooks : Form
    {
        public RentedBook RentedBook { get; set; }
        public List<RentedBook> RentedBooks { get; set; }
        public ListOfRentedBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RentedBook = new RentedBook();
            if (listBox1.SelectedItem != null)
            {
                String[] selectedItemArr = new String[2];

                RentedBook.userEMBG = RentedBooks.ToArray()[listBox1.SelectedIndex].userEMBG;
                RentedBook.bookTitle = RentedBooks.ToArray()[listBox1.SelectedIndex].bookTitle;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Select item!");
            }
        }

        private void ListOfRentedBooks_Load(object sender, EventArgs e)
        {
            RentedBooks.ForEach(rentedBook =>
            {
                string bookString = rentedBook.userUsername + " has " + rentedBook.bookTitle;
                listBox1.Items.Add(bookString);
            });
        }
    }
}
