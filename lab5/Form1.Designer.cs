namespace lab5
{
	partial class BookStore
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
            btnAddBook = new Button();
            btnShowBooks = new Button();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            txtBookId = new TextBox();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(38, 45);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(346, 319);
            listBoxBooks.TabIndex = 0;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = SystemColors.ActiveCaption;
            btnAddBook.Location = new Point(449, 207);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(93, 23);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(449, 248);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(93, 23);
            btnShowBooks.TabIndex = 2;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click_1;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.BackColor = Color.ForestGreen;
            btnUpdateBook.Location = new Point(637, 207);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(75, 23);
            btnUpdateBook.TabIndex = 3;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = false;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.Red;
            btnDeleteBook.Location = new Point(637, 248);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(75, 23);
            btnDeleteBook.TabIndex = 4;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // txtBookId
            // 
            txtBookId.Enabled = false;
            txtBookId.Location = new Point(449, 75);
            txtBookId.Name = "txtBookId";
            txtBookId.PlaceholderText = "Book ID";
            txtBookId.ReadOnly = true;
            txtBookId.Size = new Size(263, 23);
            txtBookId.TabIndex = 5;
            txtBookId.Enter += txtBookId_Enter;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(449, 115);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title";
            txtBookTitle.Size = new Size(263, 23);
            txtBookTitle.TabIndex = 6;
            txtBookTitle.Enter += txtBookTitle_Enter;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(449, 155);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Author Name";
            txtAuthorName.Size = new Size(263, 23);
            txtAuthorName.TabIndex = 7;
            txtAuthorName.Enter += txtAuthorName_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(449, 33);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 9;
            label2.Text = "Information:";
            // 
            // BookStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 387);
            Controls.Add(label2);
            Controls.Add(txtAuthorName);
            Controls.Add(txtBookTitle);
            Controls.Add(txtBookId);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnShowBooks);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Name = "BookStore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Button btnShowBooks;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private TextBox txtBookId;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Label label2;
    }
}
