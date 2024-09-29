using System.Collections.Generic;
using System.Windows;

namespace Blinov_PZ2
{
    public partial class Task2Window : Window
    {
        public Task2Window()
        {
            InitializeComponent();
        }

        private void CheckBracketsButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        ResultTextBox.Text = (i + 1).ToString(); // 1-based index
                        return;
                    }
                    stack.Pop();
                }
            }

            ResultTextBox.Text = (stack.Count == 0) ? "0" : "-1"; // Если остались открывающие скобки
        }
    }
}
