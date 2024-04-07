using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ndaza
{
    public partial class Home : Form
    {
        // include transaction class
        readonly Transaction transaction = new Transaction();
        public Home()
        {
            InitializeComponent();
            transaction.LoadTransactions(data_transactions);
        }
    }
}
