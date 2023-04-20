using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txtNumber1.Text);
            double a = double.Parse(txtNumber2.Text);
            double sum = 1;
            double term = 1;
            for (int i = 1; i <= n; i++)
            {
                term *= a;
                sum += term;
            }
            lblResult.Content = $"Сумма={sum}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
