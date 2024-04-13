using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Ndaza
{
    public partial class Home : Form
    {
        // include transaction class
        readonly Transaction transaction = new Transaction();
        // include connection class
        readonly Connection con = new Connection();
        readonly SQLiteConnection sqlcon = new SQLiteConnection();
        public Home()
        {
            InitializeComponent();
            transaction.LoadTransactions(data_transactions);
            LoadCharts();
        }
        // loads charts when called
        private void LoadCharts()
        {
            SQLiteConnection connection = con.GetConnection();
            // get income
            SQLiteCommand queryMoney = new SQLiteCommand("SELECT NetIncome FROM Branch WHERE strftime('%Y', 'now')", connection);
            SQLiteDataReader income = queryMoney.ExecuteReader();
            try
            {
                chart_income.Series[0].Points.Clear(); // first set of data income

                while (income.Read())
                {
                    chart_income.Series[0].Points.Add(income.GetInt32(0)); // first set of data income
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Charts unavailabe" + ex.ToString(), "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
