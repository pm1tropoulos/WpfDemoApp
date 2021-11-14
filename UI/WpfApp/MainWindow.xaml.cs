using BL.TaskDemo;
using DL.Customer;
using System.Collections.Generic;
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
                var customers = TaskDemo.DoSearch();
                dataGrid.ItemsSource = customers;
                textBox.Text = "Done!!";
            }
            catch (System.Exception ex)
            {
                textBox.Text = ex.Message;
                throw;
            }
        }

    }
}

