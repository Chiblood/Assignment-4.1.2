namespace Assignment_4._1._2
{


    public partial class Form1 : Form
    {
        double firstNumber;
        double secondNumber;
        String? operation;

        public Form1()
        {
            InitializeComponent();
        }
        // Append the corresponding digit to the AnswerGroupBox1 TextBox
        private void numberButtonClicked(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            AnswerGroupBox1.Text += clickedButton.Text;
        }

        // Store the first number and the selected operator, then clear the display for the second number
        private void operatorButtonClicked(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            operation = clickedButton.Text;
            firstNumber = double.Parse(AnswerGroupBox1.Text);
            AnswerGroupBox1.Text= string.Empty;
        }
        // Perform the calculation based on the selected operator and display the result
        private void EqualsButtonClicked(object sender, EventArgs e) 
        {
            secondNumber = double.Parse(AnswerGroupBox1.Text);
            Calculator calculator = new Calculator();
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = calculator.Add(firstNumber, secondNumber);
                    break;
                case "-":
                    result = calculator.Subtract(firstNumber, secondNumber);
                    break;
                case "*":
                    result = calculator.Multiply(firstNumber, secondNumber);
                    break;
                case "/":
                    result = calculator.Divide(firstNumber, secondNumber);
                    break;
            }

            AnswerGroupBox1.Text = result.ToString();
        }
    }
}
