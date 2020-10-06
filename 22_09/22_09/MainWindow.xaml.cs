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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable phonesTable;

        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        }

        private void Tospec_Click(object sender, RoutedEventArgs e)
        {
            string connect = "data source=vc-stud-mssql1;initial catalog=user57_db;persist security info=True;user id=user57_db;password=user57;MultipleActiveResultSets=True;App=EntityFramework";
            string command = "Select * from Pacienti2 where num='" + card.Text + "' and num_2='" + y.Text + "' and pass='" + passw.Password + "'";
            SqlConnection myConnection = new SqlConnection(connect);
            SqlCommand myCommand = new SqlCommand(command, myConnection);
            myConnection.Open();
            SqlDataReader rd = myCommand.ExecuteReader();//чтение строк
            //Переменные для хранения данных, чтоб не ругался компилятор
            string carta = "null"; //или просто ""
            string num2 = "null";
            string password = "null";
            while (rd.Read())//Чтение данных
            {
                carta = rd.GetString(1);
                num2 = rd.GetString(2);
                password = rd.GetString(8);
            }
            myConnection.Close();
            if ((carta == "null") || (num2 == "null")|| (password == "null"))// если введены неправильные данные
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            else
            {
                zapis main = new zapis();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
        }

        private void Toexam_Click(object sender, RoutedEventArgs e)
        {
            string connect = "data source=vc-stud-mssql1;initial catalog=user57_db;persist security info=True;user id=user57_db;password=user57;MultipleActiveResultSets=True;App=EntityFramework";
            string command = "Select * from Pacienti2 where num='" + card.Text + "' and num_2='" + y.Text + "'";
            SqlConnection myConnection = new SqlConnection(connect);
            SqlCommand myCommand = new SqlCommand(command, myConnection);
            myConnection.Open();
            SqlDataReader rd = myCommand.ExecuteReader();//чтение строк
            //Переменные для хранения данных, чтоб не ругался компилятор
            string carta = "null"; //или просто ""
            string num2 = "null";
            while (rd.Read())//Чтение данных
            {
                carta = rd.GetString(2);
                num2 = rd.GetString(3);
            }
            myConnection.Close();
            if ((carta == "null") || (num2 == "null"))// если введены неправильные данные
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            else
            {
                zapis main = new zapis();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
