using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Blinov_PZ2
{
    public partial class Task4Window : Window
    {
        public Task4Window()
        {
            InitializeComponent();
        }

        private void CountMonotonicButton_Click(object sender, RoutedEventArgs e)
        {
            List<int> numbers = InputTextBox.Text.Split(',').Select(int.Parse).ToList();
            int count = 0;
            bool increasing = false;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    if (!increasing)
                    {
                        count++;
                        increasing = true;
                    }
                }
                else if (numbers[i] < numbers[i - 1])
                {
                    if (increasing)
                    {
                        count++;
                        increasing = false;
                    }
                }
            }

            ResultTextBox.Text = count.ToString();
        }
    }
}
