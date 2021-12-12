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
        BizRulesDelegate AddDel = (x, y) => x + y;
        BizRulesDelegate SubDel = (x, y) => x - y;
        BizRulesDelegate MultDel = (x, y) => x * y;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var data = new ProcessData();
            data.Process(2, 3, AddDel);

            try
            {
                var customers = TaskDemo.DoSearch();
                //TODO This should be fixed
                dataGrid.ItemsSource = customers.Result;
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

