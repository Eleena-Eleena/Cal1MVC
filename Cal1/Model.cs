using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Cal1
{
    public static class Model
    {
        public static List<String> datalist = new List<string> { "Сложение", "Вычитание", "Деление", "Умножение" };
        public static TextBlock tb;
        public static ComboBox comboBox;

        public static double Add(double x1, double x2)
        {
            return x1 + x2;
        }
        public static double Rem(double x1, double x2)
        {
            return x1 - x2;
        }
        public static double Mul(double x1, double x2)
        {
            return x1 * x2;
        }
        public static double Dev(double x1, double x2)
        {
            if (x2 !=0)
            {
                return x1 / x2;
            }
            else
            {
                MessageBox.Show("На 0 делить нельзя");
                return 0;
            }
        }
        public static int Combo
        {
            set
            {
                comboBox.Text = datalist[value];
            }
        }


    }
}
