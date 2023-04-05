using Restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Documents;
using Restaurant_management.DAO;
using System.Drawing;
using System.IO;
using static System.Windows.Forms.ListViewItem;
using System.Globalization;
using System.Threading;
using Table = Restaurant_management.DTO.Table;

namespace Restaurant_management
{
    public partial class fPay : Form
    {
        public fPay()
        {
            InitializeComponent();
            loadTable();
            loadCategory();
            loadCBTable(cbChangeTable);
            loadTableList();
        }

        void loadTableList()
        {
            fFood food = new fFood();
            food.InsertFood += Food_InsertFood; ;
            food.UpdateFood += Food_UpdateFood; ;
            food.DeleteFood += Food_DeleteFood; ;
        }

        private void Food_DeleteFood(object sender, EventArgs e)
        {
            loadFood((cbCategory.SelectedItem as Category).Id);
            if (listViewBill.Tag != null)
                ShowBill((listViewBill.Tag as Table).ID);
            loadTable();
        }

        private void Food_UpdateFood(object sender, EventArgs e)
        {
            loadFood((cbCategory.SelectedItem as Category).Id);
            if (listViewBill.Tag != null)
                ShowBill((listViewBill.Tag as Table).ID);
        }

        private void Food_InsertFood(object sender, EventArgs e)
        {
            loadFood((cbCategory.SelectedItem as Category).Id);
            if (listViewBill.Tag != null)
                ShowBill((listViewBill.Tag as Table).ID);
        }

        void loadFood(int id)
        {
            List<Food> listFood = FoodDAO.Instance.getFood(id);
            cbfood.DataSource = listFood;
            cbfood.DisplayMember = "Name";
        }

        void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.getCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        public void loadTable()
        {
            
            flowLayoutPanelTable.Controls.Clear();
            List<DTO.Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (DTO.Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth + 10, Height = TableDAO.TableHeight +10 };
                Panel panel = new Panel() { Width = TableDAO.TableWidth +10, Height = TableDAO.TableHeight };
                TextBox tb = new TextBox() { Width = TableDAO.TableWidth +10, Height = TableDAO.TableHeight +10 };
                tb.Text = item.Name + ": " + item.Status;
                tb.ReadOnly = true;
                tb.TextAlign = HorizontalAlignment.Center;
                panel.Controls.Add(tb);
                btn.ForeColor = Color.White;
                btn.BackgroundImage = new Bitmap("..\\..\\Images\\tableware_80px.png");
                btn.BackgroundImageLayout = ImageLayout.Center;
                panel.Controls.Add(btn);
                flowLayoutPanelTable.Controls.Add(panel);

                btn.Click += btn_Click;
                btn.Tag = item;
                switch(item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightGreen;
                        btn.ForeColor = Color.Black;
                        break;
                    default:
                        btn.BackgroundImage = new Bitmap("..\\..\\Images\\restaurant_menu_50px.png");
                        btn.BackgroundImageLayout = ImageLayout.Center;
                        btn.BackColor = Color.LightCoral;
                        btn.ForeColor = Color.Black;
                        break;
                }
            }
        }

        void ShowBill(int id)
        {
            listViewBill.Items.Clear();
            List<menu> listBillInfo = menuDAO.Instance.getListMenu(id);
            float totalPrice = 0;
            foreach (menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.NameFood.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.PriceFood.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                listViewBill.Items.Add(lsvItem);
            }
            textBoxTotalPrice.BackColor = textBoxTotalPrice.BackColor;
            textBoxTotalPrice.ForeColor = Color.Red;
            CultureInfo culture = new CultureInfo("vi-VN");
            textBoxTotalPrice.Text = totalPrice.ToString("c", culture);


        }

        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                int tableID = ((sender as Button).Tag as Table).ID;
                listViewBill.Tag = (sender as Button).Tag;
                ShowBill(tableID);
            }
            catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;

            loadFood(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = listViewBill.Tag as Table;

                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn");
                    return;
                }

                int idBill = BillDAO.Instance.getUncheckBillID(table.ID);
                int FoodID = (cbfood.SelectedItem as Food).Id;
                int count = (int)countAddFood.Value;

                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), FoodID, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, FoodID, count);
                }

                ShowBill(table.ID);
                loadTable();
            }catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }

        }

        private void cbfood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = listViewBill.Tag as Table;
                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn cần thanh toán");
                    return;
                    
                }
                int idBill = BillDAO.Instance.getUncheckBillID(table.ID);
                int discount = (int)numericUpDownDisscoutPercent.Value;

                double totalPrice = Convert.ToDouble(textBoxTotalPrice.Text.Split(',')[0].Replace(".", ""));
                double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
                if (idBill != -1)
                {
                    if (MessageBox.Show(string.Format("Bạn muốn thanh toán hóa đơn cho {0}\n Tổng tiền = {1}\n Giảm giá = {2}%\n Tổng chi phí phải thanh toán = {3}", table.Name, totalPrice.ToString("c", new CultureInfo("vi-VN")).Split(',')[0], discount, finalTotalPrice.ToString("c", new CultureInfo("vi-VN")).Split(',')[0]), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.checkOut(idBill, discount, (float)finalTotalPrice);
                        ShowBill(table.ID);
                        loadTable();
                    }
                }
            }catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        void loadCBTable (ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            try
            {
                int id1 = (listViewBill.Tag as Table).ID;
                int id2 = (cbChangeTable.SelectedItem as Table).ID;
                if (MessageBox.Show(string.Format("Bạn muốn chuyển bàn {0} qua bàn {1}", (listViewBill.Tag as Table).Name, (cbChangeTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TableDAO.Instance.swapTable(id1, id2);

                    loadTable();
                }
            }
            catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Chuyển bàn thất bại");
            }

        }
    }
}
