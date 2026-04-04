namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }

        private void btnFactorialCalculate_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial: {result}";
        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }
        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }

        public long RecursiveFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInputFibo.Text, out int n))
            {
                long result = RecursiveFibonacci(n);
                lblResultFibo.Text = $"Fibonacci number {n}: {result}";
            }
        }

        public double RecursivePower(double nbase, int npower)
        {
            if (npower == 0) return 1;
            //if (nbase == 0) return 0;

            return nbase * RecursivePower(nbase, npower - 1);
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBaseNum.Text, out double mybase) &&
          int.TryParse(txtExponentNum.Text, out int mypower))
            {
                double result = RecursivePower(mybase, mypower);
                lblResultPower.Text = $"{mybase}^{mypower} = {result}";
            }
        }
    }
}
