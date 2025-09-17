using System.Data;

namespace Assignment_4._1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Append the corresponding digit to the AnswerLabel1 Text
        private void numberButtonClicked(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            AnswerLabel1.Text += clickedButton.Text;
        }

        // Append the operator to the AnswerLabel1 Text
        private void operatorButtonClicked(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            string op = clickedButton.Text;

            // Convert 'x' to '*' for evaluation
            if (op == "x") op = "*";
            AnswerLabel1.Text += op;
        }

        // Evaluate the expression and display the result
        private void EqualsButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string expression = AnswerLabel1.Text;
                var result = new DataTable().Compute(expression, null);
                FinalAnswer.Text = result.ToString();
            }
            catch
            {
                FinalAnswer.Text = "Error";
            }
        }

        private void ClearButtonClicked(object sender, EventArgs e)
        {
            AnswerLabel1.Text = string.Empty;
            FinalAnswer.Text = string.Empty;
        }
    }
}
