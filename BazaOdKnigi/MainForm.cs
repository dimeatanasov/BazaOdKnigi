namespace BazaOdKnigi
{
    public partial class MainForm : Form
    {
        List<Book> Books = new List<Book>();
        List<User> Users = new List<User>();
        List<RentedBook> RentedBooks = new List<RentedBook>();

        int numberOfBooks = 0;
        int numberOfRentedBooks = 0;
        int numberOfCurentRentedBooks = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();

            if (addBook.ShowDialog() == DialogResult.OK)
            {
                Books.Add(addBook.Book);
                string itemToBeAdded = addBook.Book.title + " - " + addBook.Book.numberOfBooks;
                listBox1.Items.Add(itemToBeAdded);
                numberOfBooks++;
                label5.Text = numberOfBooks.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();

            if (addUser.ShowDialog() == DialogResult.OK)
            {
                Users.Add(addUser.User);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListOfRentedBooks listOfRentedBooks = new ListOfRentedBooks();

            listOfRentedBooks.RentedBooks = RentedBooks;

            if (listOfRentedBooks.ShowDialog() == DialogResult.OK)
            {
                Books.Find(book => book.title == listOfRentedBooks.RentedBook.bookTitle).numberOfBooks++;

                RentedBooks = RentedBooks.FindAll(item => item.bookTitle != listOfRentedBooks.RentedBook.bookTitle || item.userEMBG != listOfRentedBooks.RentedBook.userEMBG);

                numberOfCurentRentedBooks--;
                label3.Text = numberOfCurentRentedBooks.ToString();

                listBox1.Items.Clear();

                foreach (Book book in Books)
                {
                    string itemToBeAdded = book.title + " - " + book.numberOfBooks;
                    listBox1.Items.Add(itemToBeAdded);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RentBook rentBook = new RentBook();
            if (rentBook.ShowDialog() == DialogResult.OK)
            {
                if (!Books.Exists(book => book.title == rentBook.RentedBook.bookTitle) || !Users.Exists(user => user.EMBG == rentBook.RentedBook.userEMBG))
                {
                    MessageBox.Show("There is not any book with that title or user with that EMBG!");
                    return;
                }

                if (Books.Find(book => book.title == rentBook.RentedBook.bookTitle).numberOfBooks == 0)
                {
                    MessageBox.Show("There is no more books left with that title!");
                    return;
                }

                rentBook.RentedBook.userUsername = Users.Find(user => user.EMBG == rentBook.RentedBook.userEMBG).username;

                RentedBooks.Add(rentBook.RentedBook);

                Books.Find(book => book.title == rentBook.RentedBook.bookTitle).numberOfBooks--;

                listBox1.Items.Clear();

                foreach (Book book in Books)
                {
                    string itemToBeAdded = book.title + " - " + book.numberOfBooks;
                    listBox1.Items.Add(itemToBeAdded);
                }

                numberOfCurentRentedBooks++;
                numberOfRentedBooks++;
                label3.Text = numberOfCurentRentedBooks.ToString();
                label2.Text = numberOfRentedBooks.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AllUsers allUsers = new AllUsers();
            
            allUsers.Users = Users;

            allUsers.ShowDialog();
        }
    }
}
