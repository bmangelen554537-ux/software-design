namespace lab6
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxBooks = new ListBox();
            groupBox1 = new GroupBox();
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            btnFetchBooks = new Button();
            btnAddBook = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBookId = new TextBox();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(22, 30);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(362, 379);
            listBoxBooks.TabIndex = 0;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteBook);
            groupBox1.Controls.Add(btnUpdateBook);
            groupBox1.Controls.Add(btnFetchBooks);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBookId);
            groupBox1.Controls.Add(txtBookTitle);
            groupBox1.Controls.Add(txtAuthorName);
            groupBox1.Location = new Point(411, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 379);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.Red;
            btnDeleteBook.Location = new Point(191, 257);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(99, 23);
            btnDeleteBook.TabIndex = 9;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.BackColor = Color.SteelBlue;
            btnUpdateBook.Location = new Point(18, 257);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(89, 23);
            btnUpdateBook.TabIndex = 8;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = false;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.BackColor = Color.Gold;
            btnFetchBooks.Location = new Point(191, 213);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(99, 23);
            btnFetchBooks.TabIndex = 7;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = false;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.YellowGreen;
            btnAddBook.Location = new Point(18, 213);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(89, 23);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 151);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Book ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 105);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Book:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 59);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Author:";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(105, 148);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(222, 23);
            txtBookId.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(105, 102);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(222, 23);
            txtBookTitle.TabIndex = 1;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(105, 56);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(222, 23);
            txtAuthorName.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxBooks;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtBookId;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnFetchBooks;
        private Button btnAddBook;
        private Label label3;
    }
}
