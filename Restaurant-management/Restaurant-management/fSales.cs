using Restaurant_management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management
{
    public partial class fSales : Form
    {
        public fSales()
        {
            InitializeComponent();
            LoadDateTimeView();
            LoadListBill(datetimeFromDate.Value, datetimeToDate.Value);
        }

        void LoadListBill(DateTime checkIn, DateTime checkOut)
        {
            dataBill.DataSource = BillDAO.Instance.showBill(checkIn, checkOut);
        }

        void LoadDateTimeView()
        {
            DateTime today = DateTime.Now;
            datetimeFromDate.Value = new DateTime(today.Year, today.Month, 1);
            datetimeToDate.Value = datetimeFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void btnWatchView_Click(object sender, EventArgs e)
        {
            LoadListBill(datetimeFromDate.Value, datetimeToDate.Value);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
