namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }
        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial((int)number);
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
            lblSumResult.Text = $"Sum : {result}";

        }
        public int RecursiveFibonacci(int n)
        {
            
            if (n <= 0) return 0;
            if (n == 1) return 1;
            
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }   

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInpArray.Text);
            int result = RecursiveFibonacci(number);
            lblFibonacciResult.Text = $"Fibonacci: {result}";
        }
        public double RecursivePower(double x, int n)
        {
            
            if (n == 0) return 1;
            if (n < 0) return 1 / RecursivePower(x, -n);

            
            return x * RecursivePower(x, n - 1);
        }
        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            double baseValue = double.Parse(txtBaseInput.Text);
            int exponent = int.Parse(txtExponentInput.Text);

            double result = RecursivePower(baseValue, exponent);
            lblPowerResult.Text = $"{baseValue}^{exponent} = {result}";
        }

    }
}
