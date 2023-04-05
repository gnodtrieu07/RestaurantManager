using Restaurant_management.DAO;
using Restaurant_management.DTO;
using Restaurant_management.BUS;
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
    public partial class frmStaff : Form
    {
        BindingSource accountList = new BindingSource();

        public frmStaff()
        {
            InitializeComponent();
            loadDataAccount();
            load();
        }

        void load()
        {
            dataStaff.DataSource = accountList;
            addAccount();
        }

        void addAccount()
        {
            textBoxUserNameStaff.DataBindings.Add(new Binding("Text", dataStaff.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            textBoxDisplayNameStaff.DataBindings.Add(new Binding("Text", dataStaff.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            numericUpDownWH.DataBindings.Add(new Binding("Value", dataStaff.DataSource, "WorkHour", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dataStaff.DataSource, "TypeAccount", true, DataSourceUpdateMode.Never));
        }
        void loadDataAccount()
        {
            accountList.DataSource = AccountDAO.Instance.getlistAccount();
            //string query = "Select UserName as N'Tài khoản', DisplayName as N'Tên hiển thị', PassWord as N'Mật khẩu', TypeAccount as N'Loại tài khoản'  from dbo.Account";
            //string query = "EXEC dbo.USP_GetDisplayNameByUserName @userName";
            //string query = "select * from Account";
            //dataStaff.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff" });

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnWatchStaff_Click(object sender, EventArgs e)
        {
            try
            {
                loadDataAccount();
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        void AddAccount(Account account)
        {
           if(AccountDAO.Instance.insertAccount(account))
           {
               MessageBox.Show("Thêm tài khoản thành công");
           }
           else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            loadDataAccount();
        }

        void EditAccount(Account account)
        {
            if (AccountDAO.Instance.updateAccount(account))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            loadDataAccount();
        }

        void DeleteAccount(string userName)
        {
            if (AccountDAO.Instance.deleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            loadDataAccount();
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                Account newAccount;
                string username = textBoxUserNameStaff.Text;
                string displayname = textBoxDisplayNameStaff.Text;
                int type = (int)numericUpDown1.Value;
                int workhour = (int)numericUpDownWH.Value;
                if (type == 1)//manager
                {
                    newAccount = new ConcreteBuilder().setUserName(username).setDisplayName(displayname).setTypeAccount(type)
                    .getAccount();
                }
                else//part time
                {
                    newAccount = new ConcreteBuilder().setUserName(username).setDisplayName(displayname).setTypeAccount(type)
                    .setWorkHour(workhour.ToString()).getAccount();
                }
                AddAccount(newAccount);
            }
            catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            try
            {
                Account newAccount;
                string username = textBoxUserNameStaff.Text;
                string displayname = textBoxDisplayNameStaff.Text;
                int type = (int)numericUpDown1.Value;
                int workhour = (int)numericUpDownWH.Value;
                if (type == 1)//manager
                {
                    newAccount = new ConcreteBuilder().setUserName(username).setDisplayName(displayname).setTypeAccount(type)
                    .getAccount();
                }
                else//part time
                {
                    newAccount = new ConcreteBuilder().setUserName(username).setDisplayName(displayname).setTypeAccount(type)
                    .setWorkHour(workhour.ToString()).getAccount();
                }
                EditAccount(newAccount);
            }
            catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUserNameStaff.Text;
                DeleteAccount(username);
            }
            catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownWH.Enabled = (numericUpDown1.Value == 1) ? false : true;
        }
    }
}
