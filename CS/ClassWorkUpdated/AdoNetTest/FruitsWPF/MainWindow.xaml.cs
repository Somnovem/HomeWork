using System.Windows;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Media;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Configuration;
namespace FruitsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionStr = "";
        DbConnection conn;
        DbProviderFactory factory;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            if (IsServOpen())
            {
                try
                {
                    conn.Close();
                    btnConnect.Content = "Connect";
                    btnConnect.Foreground = Brushes.Green;
                }
                catch
                {
                    MessageBox.Show("Couldn't disconnect from db", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                try
                {
                    factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                    conn = factory.CreateConnection();
                    connectionStr = GetConnectionString("System.Data.SqlClient");
                    conn.ConnectionString = connectionStr;
                    conn.Open();
                    btnConnect.Content = "Disconnect";
                    btnConnect.Foreground = Brushes.Red;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Couldn't connect to db.{ex.Message}", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }
        private string GetConnectionString(string provider)
        {
            string result = null;
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings css in settings)
                {
                    if (css.ProviderName.Equals(provider))
                    {
                        result = css.ConnectionString;
                        break;
                    }
                }
            }
            return result;
        }

        private bool IsServOpen() => conn != null && conn.State == ConnectionState.Open ;
        private void ExecCmdToGrid(DbCommand cmd)
        {
            DataTable dt = new DataTable();
            DbDataAdapter a = factory.CreateDataAdapter();
            a.SelectCommand = cmd;
            a.SelectCommand.Connection = conn;
            a.Fill(dt);
            dg.ItemsSource = dt.DefaultView;
        }
        private void DoQueryWithoutParams(string sql)
        {
            if (!IsServOpen())
            {
                MessageBox.Show("Connection to db wasn't established", "Attention", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            ExecCmdToGrid(cmd);
        }

        private KeyValuePair<bool,string> RequestParam(string req)
        {
            Request window = new Request();
            window.txtReq.Content = req;
            return new KeyValuePair<bool, string>((bool)window.ShowDialog(),window.txtAnswer.Text);
        }
        private void btnAll_Click(object sender, RoutedEventArgs e)
        {
            DoQueryWithoutParams("select * from Stats");
        }
        private void btnNames_Click(object sender, RoutedEventArgs e)
        {
            DoQueryWithoutParams("select Name from Stats");
        }
        private void btnColors_Click(object sender, RoutedEventArgs e)
        {
            DoQueryWithoutParams("select distinct Color from Stats");
        }

        private void btnMaxCalories_Click(object sender, RoutedEventArgs e)
        {
            DoQueryWithoutParams("select max(Calories) as 'Maximum calories found' from Stats");
        }

        private void btnMinCalories_Click(object sender, RoutedEventArgs e)
        {
            DoQueryWithoutParams("select min(Calories) as 'Minimum calories found' from Stats");
        }

        private void btnAvgCalories_Click(object sender, RoutedEventArgs e)
        {
            DoQueryWithoutParams("select avg(Calories) as 'Average calories' from Stats");
        }

        private void btnNumVegies_Click(object sender, RoutedEventArgs e)
        {
            DoQueryWithoutParams("select count(*) as 'Number of vegetables' from Stats where Type = 'Vegetable'");
        }

        private void btnNumFruits_Click(object sender, RoutedEventArgs e)
        {
            DoQueryWithoutParams("select count(*) as 'Number of fruits' from Stats where Type = 'Fruit'");
        }

        private void btnProdsInColor_Click(object sender, RoutedEventArgs e)
        {
            if (!IsServOpen())
            {
                MessageBox.Show("Connection to db wasn't established", "Attention", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            KeyValuePair<bool,string> res = RequestParam("Enter color:");
            if (!res.Key)return;
            string color = res.Value;
            string sql = "select count(*) as 'Number of products in this color' from Stats where Color = @color";
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@color", color));
            ExecCmdToGrid(cmd);
        }

        private void btnProdsPerColor_Click(object sender, RoutedEventArgs e)
        {
            DoQueryWithoutParams("select Color,count(Name) as 'Num of prods' from Stats group by Color");
        }

        private void btnLessCalories_Click(object sender, RoutedEventArgs e)
        {
            if (!IsServOpen())
            {
                MessageBox.Show("Connection to db wasn't established", "Attention", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            KeyValuePair<bool, string> res = RequestParam("Enter calories:");
            if (!res.Key) return;
            int calories;
            if (!int.TryParse(res.Value, out calories))
            {
                MessageBox.Show("Invalid entry", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string sql = "select * from Stats where Calories < @calor";
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText= sql;
            cmd.Parameters.Add(new SqlParameter("@calor", calories));
            ExecCmdToGrid(cmd);
        }

        private void btnMoreCalories_Click(object sender, RoutedEventArgs e)
        {
            if (!IsServOpen())
            {
                MessageBox.Show("Connection to db wasn't established", "Attention", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            KeyValuePair<bool, string> res = RequestParam("Enter calories:");
            if (!res.Key) return;
            int calories;
            if (!(int.TryParse(res.Value, out calories)))
            {
                MessageBox.Show("Invalid entry", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string sql = "select *  from Stats where Calories > @calor";
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@calor", calories));
            ExecCmdToGrid(cmd);
        }

        private void btnCaloriesBetween_Click(object sender, RoutedEventArgs e)
        {
            if (!IsServOpen())
            {
                MessageBox.Show("Connection to db wasn't established", "Attention", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            KeyValuePair<bool, string> res = RequestParam("Enter start of range of calories:");
            if (!res.Key) return;
            int calStart, calEnd;
            if (!(int.TryParse(res.Value, out calStart)))
            {
                MessageBox.Show("Invalid entry", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            res = RequestParam("Enter start of range of calories:");
            if (!res.Key) return;
            if (!(int.TryParse(res.Value, out calEnd)))
            {
                MessageBox.Show("Invalid entry", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (calEnd < calStart)
            {
                MessageBox.Show("End of range must be bigger than the start", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string sql = "select *  from Stats where Calories between @calStart and @calEnd";
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@calStart", calStart));
            cmd.Parameters.Add(new SqlParameter("@calEnd", calEnd));
            ExecCmdToGrid(cmd);
        }

        private void btnYelOrRed_Click(object sender, RoutedEventArgs e)
        {
            DoQueryWithoutParams("select * from Stats where Color = 'Yellow' or Color = 'Red'");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsServOpen()) conn.Close();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = null;
        }
    }
}
