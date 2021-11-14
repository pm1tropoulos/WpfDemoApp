using BL.TaskDemo;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                TaskDemo.DoSearch();
                textBox.Text = "Done!!";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"A custom exception happened: {ex}");
                textBox.Text = "Fail!!";
                throw;
            }
        }

    }
}

