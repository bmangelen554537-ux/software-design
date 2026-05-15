using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace lab7

{
    public partial class Form1 : Form
    {

        private int currentPage = 1;
        private const int pageSize = 10;

        public Form1()
        {
            InitializeComponent();
            this.Load += async (s, e) => await LoadBooksAsync();

            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
            }
        }
        private async Task LoadBooksAsync()
        {
            using (var context = new AppDbContext())
            {
                var books = await context.Books
                    .OrderBy(b => b.Id)
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                lbxBooks.DataSource = null;
                lbxBooks.DataSource = books;

                lbxBooks.DisplayMember = "DisplayText";

                lblPageNumber.Text = $"Page: {currentPage}";
                btnPreviousPage.Enabled = (currentPage > 1);
            }
        }


        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            await LoadBooksAsync();
        }

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            await LoadBooksAsync();
        }

        private async void btnSaveBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text)) return;

            try
            {
                using (var context = new AppDbContext())
                {
                    var newBook = new Book
                    {
                        Title = txtBookTitle.Text,
                        Author = txtBookAuthor.Text
                    };
                    context.Books.Add(newBook);
                    await context.SaveChangesAsync();
                }
                txtBookTitle.Clear();
                txtBookAuthor.Clear();
                await LoadBooksAsync(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Text File|*.txt" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var context = new AppDbContext())
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        var books = await context.Books.ToListAsync();
                        foreach (var b in books)
                        {
                            await writer.WriteLineAsync($"{b.Title} - {b.Author}");
                        }
                    }
                    MessageBox.Show("Export Successful!");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"File error: {ex.Message}");
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string term = txtSearchTitle.Text.ToLower();
            using (var context = new AppDbContext())
            {
                var results = await context.Books
                    .Where(b => b.Title.ToLower().Contains(term))
                    .ToListAsync();

                lbxBooks.DataSource = results;
                lbxBooks.DisplayMember = "DisplayText";
            }
        }

        private async void btnImportBooks_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Text File|*.txt" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var context = new AppDbContext())
                    using (StreamReader reader = new StreamReader(ofd.FileName))
                    {
                        string line;
                        while ((line = await reader.ReadLineAsync()) != null)
                        {
                            var parts = line.Split('-');
                            if (parts.Length >= 2)
                                context.Books.Add(new Book { Title = parts[0].Trim(), Author = parts[1].Trim() });
                        }
                        await context.SaveChangesAsync();
                    }
                    currentPage = 1;
                    await LoadBooksAsync();
                    MessageBox.Show("Import Successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Import Error: {ex.Message}");
                }
            }
        }
    }
}
