using Restaurant_management.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management.BUS
{

    public abstract class CommandBase
    {
        public abstract void updateAccountt(TextBox textbox1, TextBox textbox2, TextBox textbox3, TextBox textbox4, TextBox textbox5);
    }

    public class updateAccount : CommandBase
    {
        List<Button> controls;
        public updateAccount(params Button[] controls)
        {
            this.controls = new List<Button>(controls);
        }
        public override void updateAccountt(TextBox displayName, TextBox textboxOldPassword, TextBox textboxNewPassword, TextBox textboxReNewPassword, TextBox username)
        {

            string displayname = displayName.Text;
            string password = textboxOldPassword.Text;
            string newpassword = textboxNewPassword.Text;
            string repassword = textboxReNewPassword.Text;
            string userName = username.Text;
            if (!newpassword.Equals(repassword))
            {
                MessageBox.Show("Nhập lại mật khẩu mới không khớp!");
            }
            else
            {
                if (AccountDAO.Instance.updateAccount(userName, displayname, password, newpassword))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    if (UpdateAccount != null)
                    {
                        UpdateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại thông tin");
                }
            }
        }
        private event EventHandler<AccountEvent> UpdateAccount;
        public event EventHandler<AccountEvent> updateAccount1
        {
            add { UpdateAccount += value; }
            remove { UpdateAccount -= value; }
        }
    }
}
