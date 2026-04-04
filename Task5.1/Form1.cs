namespace Task5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] bubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] arr = { 19, 32, 94, 5, 21, 40, 89 };
            int[] sortedBubble = bubbleSort(arr);
            listBoxResults.DataSource = sortedBubble;
        }


        public int[] DescendingOrder(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
            return numbers;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 34, 71, 66, 87, 59, 40, 98 };
            int[] sortedOrder = DescendingOrder(numbers);
            listBoxResults.DataSource = sortedOrder;
        }
    }
}
