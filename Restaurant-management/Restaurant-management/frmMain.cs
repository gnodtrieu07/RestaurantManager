using Restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management
{
    public partial class frmMain : Form
    {
        private Account loginAccount;
        private Creator creator;
        public Account LoginAccount
        {
            get => loginAccount;
            set
            {
                loginAccount = value;
                if(loginAccount.Type==1)//root
                {
                    this.creator = new ManagerUser();
                }
                else
                {
                    this.creator = new StaffUser();
                }    
                changeAccount(creator.createUser());
            }
        }

        public frmMain(Account acc)
        {
            InitializeComponent();
            
            this.LoginAccount = acc;
            hidePanel();
        }

        void changeAccount(User user)
        {
            btnDoanhThu.Enabled = user.showBtnDoanhThu();
            btnQLNV.Enabled = user.showBtnQLNV();
            btnThucDon.Enabled = user.showBtnThucDon();
            btnKM.Enabled = user.showBtnKM();
            profile.Text += LoginAccount.DisplayName;
        }

        private void hidePanel()
        {
            panelAdmin.Visible = false;
            panelHeThong.Visible = false;
            panelThucDon.Visible = false;
        }
        private void showPanel(Panel panel)
        {
            if (panel.Visible == false)
            {
                hidePanel();
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }

        private Form activeForm = null;

    private void openPanel(Form formChild)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            panel6.Controls.Add(formChild);
            panel6.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showPanel(panelAdmin);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showPanel(panelHeThong);
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            showPanel(panelThucDon);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            hidePanel();
            openPanel(new fSales());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            hidePanel();
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                fLogin frm = new fLogin();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            hidePanel();
            fFood food = new fFood();
            
            openPanel(food);
        }

        private void Food_DeleteFood(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Food_UpdateFood(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Food_InsertFood(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            hidePanel();
            openPanel(new fChangePassword());
        }

        private void btnBanAn_Click(object sender, EventArgs e)
        {
            hidePanel();
            openPanel(new fTable());
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            hidePanel();
            openPanel(new fPay());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            hidePanel();
            openPanel(new fPay());
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            hidePanel();
            openPanel(new frmStaff());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);

        

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            hidePanel();
            openPanel(new fPay());
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            hidePanel();
        }

        private void btnKhuVucAn_Click(object sender, EventArgs e)
        {
            hidePanel();
        }

        private void btnNhatKiHoatDong_Click(object sender, EventArgs e)
        {
            hidePanel();
            fprofile f = new fprofile(LoginAccount);
            f.updateAccount1 += F_UpdateAccount;
            openPanel(f);
        }

        void F_UpdateAccount(object sender, AccountEvent e)
        {
            profile.Text = e.Acc.DisplayName;
        }


        private void btnMaxSize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            hidePanel();
            openPanel(new fPromotion());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.ControlBox = true;
        }
    }
}
