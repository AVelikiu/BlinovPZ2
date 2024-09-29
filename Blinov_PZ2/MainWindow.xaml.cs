using System.Windows;

namespace Blinov_PZ2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonTask1_Click(object sender, RoutedEventArgs e)
        {
            Task1Window task1Window = new Task1Window();
            task1Window.Show();
            this.Close();
        }

        private void ButtonTask2_Click(object sender, RoutedEventArgs e)
        {
            Task2Window task2Window = new Task2Window();
            task2Window.Show();
            this.Close();
        }

        private void ButtonTask3_Click(object sender, RoutedEventArgs e)
        {
            Task3Window task3Window = new Task3Window();
            task3Window.Show();
            this.Close();
        }

        private void ButtonTask4_Click(object sender, RoutedEventArgs e)
        {
            Task4Window task4Window = new Task4Window();
            task4Window.Show();
            this.Close();
        }

        private void ButtonTask5_Click(object sender, RoutedEventArgs e)
        {
            Task5Window task5Window = new Task5Window();
            task5Window.Show();
            this.Close();
        }
    }
}
