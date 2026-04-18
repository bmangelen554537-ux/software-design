using static lab3.Task2_3;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                Book[] books =
                {
                    new Book { Title = "Clean Code", Author = "Robert C. Martin" },
                    new Magazine { Title = "Tech Weekly", IssueNum = 45 },
                    new EBook { Title = "C# in Depth", Author = "Jon Skeet", FileSizeMb = 5.2 },
                    new TextBook { Title = "Solving Integrals like a Pro", Subject = "Calculus" },
                    new AudioBook { Title = "The Lone Penguin", Narrator = "David Attenborough", Duration = 120 }
                };

                foreach (Book book in books)
                {
                    listBox1.Items.Add(book.GetInfo());
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
