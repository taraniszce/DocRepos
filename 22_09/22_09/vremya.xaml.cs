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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace _22_09
{
    /// <summary>
    /// Interaction logic for vremya.xaml
    /// </summary>
    public partial class vremya : Window
    {
        //string connectionString;
        //SqlDataAdapter adapter;
        //DataTable phonesTable;
        public vremya()
        {
            InitializeComponent();
            //connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string connect = "data source=vc-stud-mssql1;initial catalog=user57_db;persist security info=True;user id=user57_db;password=user57;MultipleActiveResultSets=True;App=EntityFramework";

        }
    }
}
