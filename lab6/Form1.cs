using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorId { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public int AuthorId { get; set; }
            public virtual Author Author { get; set; }
        }

        private async Task<List<string>> GetBooksAsync()
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author)
                                        .Select(b => $"{b.BookId} - {b.Title} by {b.Author.Name}")
                                        .ToListAsync();
                return books;
            }
        }

        private async Task SaveBookAsync(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateBookAsync()
        {
            using (var context = new BookstoreContext())
            {
                if (int.TryParse(txtBookId.Text, out int bookId))
                {
                    var book = await context.Books
                                            .Include(b => b.Author)
                                            .FirstOrDefaultAsync(b => b.BookId == bookId);

                    if (book != null)
                    {
                        book.Title = txtBookTitle.Text;

                        if (book.Author != null)
                        {
                            book.Author.Name = txtAuthorName.Text;
                        }

                        await context.SaveChangesAsync();
                        MessageBox.Show("Book updated successfully!");
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("Book not found in the database.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Book ID. Please enter a valid number.");
                }
            }
        }

        private async Task DeleteBookAsync()
        {
            using (var context = new BookstoreContext())
            {
                if (int.TryParse(txtBookId.Text, out int bookId))
                {
                    var book = await context.Books.FindAsync(bookId);
                    if (book != null)
                    {
                        context.Books.Remove(book);
                        await context.SaveChangesAsync();
                        MessageBox.Show("Book deleted successfully!");
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("Book not found in the database.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Book ID. Please enter a valid number.");
                }
            }
        }

        public async void LoadList()
        {
            var booksWithAuthors = await GetBooksAsync();
            listBoxBooks.DataSource = booksWithAuthors;
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            string bookName = txtBookTitle.Text;
            string authorName = txtAuthorName.Text;

            btnAddBook.Enabled = false;

            await SaveBookAsync(authorName, bookName);
            MessageBox.Show("Book and Author added successfully!");
            LoadList();

            btnAddBook.Enabled = true;
        }

        private void btnFetchBooks_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            await UpdateBookAsync();
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            await DeleteBookAsync();
        }

        private void lstboxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem != null)
            {
                string selectedItem = listBoxBooks.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new string[] { " - ", " by " }, StringSplitOptions.None);

                if (parts.Length >= 1)
                {
                    txtBookId.Text = parts[0];
                }
                if (parts.Length >= 2)
                {
                    txtBookTitle.Text = parts[1];
                }
                if (parts.Length >= 3)
                {
                    txtAuthorName.Text = parts[2];
                }
            }
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}