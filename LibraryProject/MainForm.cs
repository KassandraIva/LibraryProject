using LibraryProject.classes;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        List<Author> authorList = new List<Author>();
        List<Book> bookList = new List<Book>();

        public MainForm()
        {
            InitializeComponent();

            authorList = Author.LoadFromFile();
            bookList = Book.LoadFromFile(authorList);

            dgvAllAuthors.DataSource = authorList;
            dgvAllBooks.DataSource = bookList;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
