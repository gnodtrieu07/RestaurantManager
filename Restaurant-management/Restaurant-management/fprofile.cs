using Restaurant_management.BUS;
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
    public partial class fprofile : Form
    {
        CommandBase command;
        private Account loginAccount;
        public Account LoginAccount
        {
            get => loginAccount;
            set
            {
                loginAccount = value;
                changeAccount(LoginAccount);
            }
        }
        public fprofile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            command = new updateAccount(btnAgree, btnExit);
        }

        void changeAccount(Account acc)
        {
            username.Text = LoginAccount.UserName;
            displayName.Text = loginAccount.DisplayName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private event EventHandler<AccountEvent> UpdateAccount;
        public event EventHandler<AccountEvent> updateAccount1
        {
            add { UpdateAccount += value; }
            remove { UpdateAccount -= value; }
        }
        
        
        private void btnAgree_Click(object sender, EventArgs e)
        {
            try
            {
               command.updateAccountt(displayName,textboxOldPassword,textboxNewPassword,textboxReNewPassword,username);
            }catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class AccountEvent:EventArgs
    {
        private Account acc;
        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
