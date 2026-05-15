namespace lab7
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
            groupBox1 = new GroupBox();
            lbxBooks = new ListBox();
            groupBox2 = new GroupBox();
            btnNextPage = new Button();
            lblPageNumber = new Label();
            btnPreviousPage = new Button();
            groupBox3 = new GroupBox();
            btnImportBooks = new Button();
            btnExportBooks = new Button();
            groupBox4 = new GroupBox();
            btnSaveBook = new Button();
            txtBookAuthor = new MaskedTextBox();
            label3 = new Label();
            txtBookTitle = new MaskedTextBox();
            label2 = new Label();
            txtSearchTitle = new MaskedTextBox();
            label1 = new Label();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(lbxBooks);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 347);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Inventory";
            // 
            // lbxBooks
            // 
            lbxBooks.FormattingEnabled = true;
            lbxBooks.ItemHeight = 15;
            lbxBooks.Location = new Point(6, 23);
            lbxBooks.Name = "lbxBooks";
            lbxBooks.Size = new Size(353, 319);
            lbxBooks.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MistyRose;
            groupBox2.Controls.Add(btnNextPage);
            groupBox2.Controls.Add(lblPageNumber);
            groupBox2.Controls.Add(btnPreviousPage);
            groupBox2.Location = new Point(210, 357);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(346, 65);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pagination";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(211, 34);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(125, 23);
            btnNextPage.TabIndex = 10;
            btnNextPage.Text = "Next Page ->";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(146, 38);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(39, 15);
            lblPageNumber.TabIndex = 9;
            lblPageNumber.Text = "Page: ";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(6, 34);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(125, 23);
            btnPreviousPage.TabIndex = 9;
            btnPreviousPage.Text = "<- Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.MistyRose;
            groupBox3.Controls.Add(btnImportBooks);
            groupBox3.Controls.Add(btnExportBooks);
            groupBox3.Location = new Point(408, 56);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(365, 118);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "File Operations";
            // 
            // btnImportBooks
            // 
            btnImportBooks.Location = new Point(60, 65);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(216, 37);
            btnImportBooks.TabIndex = 6;
            btnImportBooks.Text = "Import Books";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnImportBooks_Click;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(60, 22);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(216, 37);
            btnExportBooks.TabIndex = 4;
            btnExportBooks.Text = "Export Books";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.MistyRose;
            groupBox4.Controls.Add(btnSaveBook);
            groupBox4.Controls.Add(txtBookAuthor);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtBookTitle);
            groupBox4.Controls.Add(label2);
            groupBox4.Location = new Point(408, 180);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(365, 171);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Add New Book";
            // 
            // btnSaveBook
            // 
            btnSaveBook.Location = new Point(113, 116);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(125, 38);
            btnSaveBook.TabIndex = 7;
            btnSaveBook.Text = "Save Book";
            btnSaveBook.UseVisualStyleBackColor = true;
            btnSaveBook.Click += btnSaveBook_Click;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(60, 76);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(282, 23);
            txtBookAuthor.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 84);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "Author:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(60, 30);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(282, 23);
            txtBookTitle.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Title:";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(487, 21);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(214, 23);
            txtSearchTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 24);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "Search by Title:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(713, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 432);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtSearchTitle);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private MaskedTextBox txtSearchTitle;
        private Label label1;
        private Label lblPageNumber;
        private Button btnPreviousPage;
        private Button btnImportBooks;
        private Button btnExportBooks;
        private Button btnSaveBook;
        private MaskedTextBox txtBookAuthor;
        private Label label3;
        private MaskedTextBox txtBookTitle;
        private Label label2;
        private Button btnSearch;
        private ListBox lbxBooks;
        private Button btnNextPage;
    }
}
