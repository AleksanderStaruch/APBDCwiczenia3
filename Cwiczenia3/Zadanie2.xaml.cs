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
using System.Windows.Shapes;

namespace Cwiczenia3
{
    public partial class Zadanie2 : Window
    {
        public Zadanie2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string zaznaczone = Combobox.Text;
            if(Text != null)
            {
                Text.Text = zaznaczone;
            }
        }
    }
}
