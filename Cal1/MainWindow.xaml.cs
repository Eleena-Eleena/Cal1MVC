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

namespace Cal1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double a;
        public double b;
        public MainWindow()
        {
            InitializeComponent();
            Model.comboBox = ComboB;
            ComboB.ItemsSource = Model.datalist;
            
        }

        private void ComboB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.Combo = ComboB.SelectedIndex;
            switch (ComboB.SelectedIndex)
            {
                case 0:
                    TBSign.Text = "+";
                    break;
                case 1:
                    TBSign.Text = "-";
                    break;
                case 2:
                    TBSign.Text = "/";
                    break;
                case 3:
                    TBSign.Text = "*";
                    break;

                default:
                    break;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               a = double.Parse(TBa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверное А");
                return;
            }

            try
            {
                b = double.Parse(TBb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверное В");
                return;
            }
            switch (ComboB.SelectedIndex) 
            {
                case 0:
                    TBoxRes.Text = Model.Add(a,b).ToString();
                    break;
                case 1:
                    TBoxRes.Text = Model.Rem(a, b).ToString();
                    break;
                case 2:
                    TBoxRes.Text = Model.Dev(a, b).ToString();
                    break;
                case 3:
                    TBoxRes.Text = Model.Mul(a, b).ToString();
                    break;

                default:
                    break;

            }
        }
    }
}
