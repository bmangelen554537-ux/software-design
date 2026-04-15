namespace lab3
{
    partial class Task2_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxShow = new ListBox();
            btnShowItems = new Button();
            SuspendLayout();
            // 
            // listBoxShow
            // 
            listBoxShow.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxShow.FormattingEnabled = true;
            listBoxShow.ItemHeight = 30;
            listBoxShow.Location = new Point(34, 26);
            listBoxShow.Name = "listBoxShow";
            listBoxShow.Size = new Size(725, 304);
            listBoxShow.TabIndex = 0;
            // 
            // btnShowItems
            // 
            btnShowItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowItems.Location = new Point(277, 367);
            btnShowItems.Name = "btnShowItems";
            btnShowItems.Size = new Size(211, 52);
            btnShowItems.TabIndex = 1;
            btnShowItems.Text = "Show Items";
            btnShowItems.UseVisualStyleBackColor = true;
            btnShowItems.Click += btnShowItems_Click;
            // 
            // Task2_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowItems);
            Controls.Add(listBoxShow);
            Name = "Task2_3";
            Text = "Task2";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxShow;
        private Button btnShowItems;
    }
}