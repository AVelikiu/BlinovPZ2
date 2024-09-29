using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Blinov_PZ2
{
    public partial class Task5Window : Window
    {
        public Task5Window()
        {
            InitializeComponent();
        }

        private void GenerateAndSortButton_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int rows = 3; // Задайте размер M
            int cols = 4; // Задайте размер N
            int[,] array = new int[rows, cols];

            // Генерация массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(-10, 11);
                }
            }

            // Отображение массива
            List<int> flatArray = array.Cast<int>().ToList();
            DisplayArray(array);

            // Сортировка и вывод
            List<int> sortedAscending = new List<int>(flatArray);
            List<int> sortedDescending = new List<int>(flatArray);
            sortedAscending.Sort();
            sortedDescending.Sort();
            sortedDescending.Reverse();

            // Вывод результатов
            ResultTextBox.Text = $"По возрастанию: {string.Join(", ", sortedAscending)}\n" +
                                 $"По убыванию: {string.Join(", ", sortedDescending)}\n" +
                                 $"Максимум: {flatArray.Max()}\nМинимум: {flatArray.Min()}";
        }

        private void DisplayArray(int[,] array)
        {
            string displayString = "Сгенерированный массив:\n";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    displayString += array[i, j] + "\t";
                }
                displayString += "\n";
            }
            ResultTextBox.Text += displayString;
        }
    }
}
