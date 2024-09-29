using System;
using System.Windows;

namespace Blinov_PZ2
{
    public partial class Task1Window : Window
    {
        public Task1Window()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputTextBox.Text, out int year) && year > 0)
            {
                int century = (year + 99) / 100; // Определение столетия
                ResultTextBox.Text = century.ToString();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите положительное целое число.");
            }
        }
    }
}
