namespace Task5._1
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
            btnSort = new Button();
            listBoxResults = new ListBox();
            btnOrder = new Button();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(114, 113);
            btnSort.Margin = new Padding(3, 4, 3, 4);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(102, 55);
            btnSort.TabIndex = 0;
            btnSort.Text = "Bubble Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(283, 60);
            listBoxResults.Margin = new Padding(3, 4, 3, 4);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(507, 384);
            listBoxResults.TabIndex = 1;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(114, 235);
            btnOrder.Margin = new Padding(3, 4, 3, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(102, 55);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Descending Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnOrder);
            Controls.Add(listBoxResults);
            Controls.Add(btnSort);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSort;
        private ListBox listBoxResults;
        private Button btnOrder;
    }
}
