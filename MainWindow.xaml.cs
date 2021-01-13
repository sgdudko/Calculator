using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            CalculatorLogic calcLog = (CalculatorLogic)this.Resources["calcLog"];
            Button selectedButton = (Button)e.Source;
            if (calcLog.IsButtonEqualsPressed == true)
            {
                calcLog.Expression = "0";
                calcLog.IsButtonEqualsPressed = false;
            }
            if (calcLog.Expression == "0"
                && (string)selectedButton.Content != ","
                && (string)selectedButton.Content != "+"
                && (string)selectedButton.Content != "-"
                && (string)selectedButton.Content != "*"
                && (string)selectedButton.Content != "/")
            {
                calcLog.Expression = $"{selectedButton.Content}";
            }
            else
            {
                calcLog.Expression += $"{selectedButton.Content}";
            }
        }
        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            CalculatorLogic calcLog = (CalculatorLogic)this.Resources["calcLog"];
            calcLog.Expression = "0";
        }
        private void buttonBackspace_Click(object sender, RoutedEventArgs e)
        {
            CalculatorLogic calcLog = (CalculatorLogic)this.Resources["calcLog"];
            if (calcLog.IsButtonEqualsPressed == true)
            {
                calcLog.Expression = "0";
                calcLog.IsButtonEqualsPressed = false;
            }
            else
            {
                calcLog.Expression = calcLog.Expression.Substring(0, calcLog.Expression.Length - 1);
            }
        }
        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            CalculatorLogic calcLog = (CalculatorLogic)this.Resources["calcLog"];
            textBox.Text = calcLog.Equate();
        }
    }
}
