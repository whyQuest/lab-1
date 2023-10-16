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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace лаба_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            house a;
              int entrances1;
        int floors1;
            int apartmentsPerFloor1;
            double priceApart1;

            if (int.TryParse(podezd.Text, out entrances1) && int.TryParse(poverx.Text, out floors1) && int.TryParse(kva.Text, out apartmentsPerFloor1) && double.TryParse(cena.Text, out priceApart1))
            {
                a = new house(entrances1, entrances1, entrances1, priceApart1);
                int ApartmentsPerFloor1 = a.CountApInEnt();
                int CountApInHouse1 = a.CountApInHouse();
                double CostApInHouse1 = a.CostApInHouse();
                r1.Text = $"К-ть квартир у під'їзді {ApartmentsPerFloor1}";
                r2.Text = $"К-ть квартир у будинку {CountApInHouse1}";
                r3.Text = $"Ціна квартир у будинку {CostApInHouse1}";
            }
            else
            {
                r1.Text = "Помилка: Невірний формат введених даних.";
                r2.Text = "Помилка: Невірний формат введених даних.";
                r3.Text = "Помилка: Невірний формат введених даних.";
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
