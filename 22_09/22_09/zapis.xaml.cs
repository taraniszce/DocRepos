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

namespace _22_09
{
    /// <summary>
    /// Interaction logic for zapis.xaml
    /// </summary>
    public partial class zapis : Window
    {
        public zapis()
        {
            InitializeComponent();
        }

        private void b_urolog_Click(object sender, RoutedEventArgs e)
        {

        }

        private void B_okulist_Click(object sender, RoutedEventArgs e)
        {

        }

        private void B_terapevt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void B_stomot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void B_ginekolog_Click(object sender, RoutedEventArgs e)
        {

        }

        private void B_vihod_Click(object sender, RoutedEventArgs e)
        {



            Application.Current.Shutdown();
        }
    }
}
