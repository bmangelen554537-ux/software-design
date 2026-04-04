namespace lab2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtInput = new TextBox();
            lblResult = new TextBox();
            txtArrayInput = new TextBox();
            lblSumResult = new TextBox();
            txtInputFibo = new TextBox();
            lblResultFibo = new TextBox();
            txtBaseNum = new TextBox();
            lblResultPower = new TextBox();
            txtExponentNum = new TextBox();
            btnFactorialCalculate = new Button();
            btnCalculateSum = new Button();
            btnCalculateFibonacci = new Button();
            btnCalculatePower = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 41);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Factorial Calculator:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 249);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 1;
            label2.Text = "Fibonacci Calculator:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 41);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Sum Calculator:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 249);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 3;
            label4.Text = "Power Calculator:";
            label4.Click += label4_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(68, 84);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(163, 27);
            txtInput.TabIndex = 4;
            txtInput.Text = "Input Here";
            txtInput.TextChanged += textBox1_TextChanged;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.MistyRose;
            lblResult.Location = new Point(68, 133);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(163, 27);
            lblResult.TabIndex = 5;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(483, 84);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(152, 27);
            txtArrayInput.TabIndex = 6;
            txtArrayInput.Text = "Input Here";
            txtArrayInput.TextChanged += textBox3_TextChanged;
            // 
            // lblSumResult
            // 
            lblSumResult.BackColor = Color.MistyRose;
            lblSumResult.Location = new Point(483, 133);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(152, 27);
            lblSumResult.TabIndex = 7;
            lblSumResult.TextChanged += textBox4_TextChanged;
            // 
            // txtInputFibo
            // 
            txtInputFibo.Location = new Point(68, 301);
            txtInputFibo.Name = "txtInputFibo";
            txtInputFibo.Size = new Size(163, 27);
            txtInputFibo.TabIndex = 8;
            txtInputFibo.Text = "Input Here";
            // 
            // lblResultFibo
            // 
            lblResultFibo.BackColor = Color.MistyRose;
            lblResultFibo.Location = new Point(68, 346);
            lblResultFibo.Name = "lblResultFibo";
            lblResultFibo.Size = new Size(163, 27);
            lblResultFibo.TabIndex = 9;
            // 
            // txtBaseNum
            // 
            txtBaseNum.Location = new Point(483, 301);
            txtBaseNum.Name = "txtBaseNum";
            txtBaseNum.Size = new Size(125, 27);
            txtBaseNum.TabIndex = 10;
            txtBaseNum.Text = "Input Base Here";
            // 
            // lblResultPower
            // 
            lblResultPower.BackColor = Color.MistyRose;
            lblResultPower.Location = new Point(540, 346);
            lblResultPower.Name = "lblResultPower";
            lblResultPower.Size = new Size(167, 27);
            lblResultPower.TabIndex = 11;
            // 
            // txtExponentNum
            // 
            txtExponentNum.Location = new Point(640, 301);
            txtExponentNum.Name = "txtExponentNum";
            txtExponentNum.Size = new Size(125, 27);
            txtExponentNum.TabIndex = 12;
            txtExponentNum.Text = "Input Power Here";
            // 
            // btnFactorialCalculate
            // 
            btnFactorialCalculate.Location = new Point(104, 185);
            btnFactorialCalculate.Name = "btnFactorialCalculate";
            btnFactorialCalculate.Size = new Size(94, 29);
            btnFactorialCalculate.TabIndex = 13;
            btnFactorialCalculate.Text = "Calculate";
            btnFactorialCalculate.UseVisualStyleBackColor = true;
            btnFactorialCalculate.Click += btnFactorialCalculate_Click;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(514, 185);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(94, 29);
            btnCalculateSum.TabIndex = 14;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(104, 400);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(94, 29);
            btnCalculateFibonacci.TabIndex = 15;
            btnCalculateFibonacci.Text = "Calculate";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(580, 388);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(94, 29);
            btnCalculatePower.TabIndex = 16;
            btnCalculatePower.Text = "Calculate";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculatePower);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(btnCalculateSum);
            Controls.Add(btnFactorialCalculate);
            Controls.Add(txtExponentNum);
            Controls.Add(lblResultPower);
            Controls.Add(txtBaseNum);
            Controls.Add(lblResultFibo);
            Controls.Add(txtInputFibo);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtInput;
        private TextBox lblResult;
        private TextBox txtArrayInput;
        private TextBox lblSumResult;
        private TextBox txtInputFibo;
        private TextBox lblResultFibo;
        private TextBox txtBaseNum;
        private TextBox lblResultPower;
        private TextBox txtExponentNum;
        private Button btnFactorialCalculate;
        private Button btnCalculateSum;
        private Button btnCalculateFibonacci;
        private Button btnCalculatePower;
    }
}
