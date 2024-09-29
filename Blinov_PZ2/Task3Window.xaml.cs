using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Blinov_PZ2
{
    public partial class Task3Window : Window
    {
        public Task3Window()
        {
            InitializeComponent();
        }

        private void MaxProductButton_Click(object sender, RoutedEventArgs e)
        {
            List<int> numbers = InputTextBox.Text.Split(',').Select(int.Parse).ToList();
            if (numbers.Count < 3)
            {
                MessageBox.Show("Введите не менее трех чисел.");
                return;
            }

            numbers.Sort();
            int maxProduct = Math.Max(numbers[0] * numbers[1] * numbers[numbers.Count - 1],
                                       numbers[numbers.Count - 1] * numbers[numbers.Count - 2] * numbers[numbers.Count - 3]);
            ResultTextBox.Text = maxProduct.ToString();
        }
    }
}
