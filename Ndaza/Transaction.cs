using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ndaza
{
    class Transaction
    {
        // include connection class
        readonly Connection con = new Connection();
        // load transactions
        public void LoadTransactions(DataGridView datagrid)
        {
            string queryTransactions = "SELECT ID, Name, Week1, Week2, Week3, Week4, NetIncome, Date FROM Branch";
            con.LoadData(queryTransactions, datagrid);
            datagrid.Columns[0].Visible = false;
        }
    }
}
