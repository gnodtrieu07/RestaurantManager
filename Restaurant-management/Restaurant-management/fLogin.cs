using Restaurant_management.DAO;
using Restaurant_management.DTO;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = textboxUsername.Text;
                string passWord = textBoxPassword.Text;
                if (Login(userName, passWord))
                {
                    Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    frmMain f = new frmMain(loginAccount);
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
