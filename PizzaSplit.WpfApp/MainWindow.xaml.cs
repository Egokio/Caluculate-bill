using PizzaSplit.Core;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PizzaSplit.WpfApp
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

        private void count_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(total.Text, out int summa))
            {
                MessageBox.Show("Sisesta korrektne summa");
                return;
            }

            if (!int.TryParse(people.Text, out int people1))
            {
                MessageBox.Show("Sisesta korrektne sööjate arv");
                return;
            }
            double result = BillCalculator.Bill(summa, people1,TipsCheck.IsChecked ?? false);
            Result.Content = result.ToString();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void total_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}