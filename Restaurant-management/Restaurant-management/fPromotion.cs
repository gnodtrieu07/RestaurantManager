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
    public partial class fPromotion : Form
    {
        BindingSource promotionList = new BindingSource();
        public fPromotion()
        {
            InitializeComponent();
            dataPro.DataSource = promotionList;
            loadListPromotion();
            addPromotionBinding();
            loadCategory(comboBoxCategoryPro);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadListPromotion()
        {
            promotionList.DataSource = PromotionDAO.Instance.ListPromotion();
        }

        private void btnWatchPro_Click(object sender, EventArgs e)
        {
            loadListPromotion();
        }

        void addPromotionBinding()
        {
            textboxProID.DataBindings.Add(new Binding("Text", dataPro.DataSource, "Id", true, DataSourceUpdateMode.Never));
            comboBoxCategoryPro.DataBindings.Add(new Binding("Text", dataPro.DataSource, "Name", true, DataSourceUpdateMode.Never));
            numericUpDownPer.DataBindings.Add(new Binding("Value", dataPro.DataSource, "Per", true, DataSourceUpdateMode.Never));
            numericUpDownAmount.DataBindings.Add(new Binding("Value", dataPro.DataSource, "Amount", true, DataSourceUpdateMode.Never));
        }

        void loadCategory(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.getCategory();
            cb.DisplayMember = "Name";
        }

        private void textboxProID_TextChanged(object sender, EventArgs e)
        {
            if (dataPro.SelectedCells.Count > 0)
            {
                int id = (int)dataPro.SelectedCells[0].OwningRow.Cells["IDCategory"].Value | 1;
                Category category = CategoryDAO.Instance.GetCategorybyID(id);
                comboBoxCategoryPro.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (Category item in comboBoxCategoryPro.Items)
                {
                    if (item.Id == category.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                comboBoxCategoryPro.SelectedIndex = index;
            }
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            try
            {
                int categoryID = (comboBoxCategoryPro.SelectedItem as Category).Id;
                int amount = (int)numericUpDownAmount.Value;
                int per = (int)numericUpDownPer.Value;

                if (PromotionDAO.Instance.insertPromotion(categoryID, amount, per))
                {
                    MessageBox.Show("Thêm khuyến mãi thành công");
                    loadListPromotion();
                    if (insertPromotion != null)
                    {
                        insertPromotion(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Thêm khuyến mãi thất bại");
                }
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        private void btnEditPro_Click(object sender, EventArgs e)
        {
            try
            {
                int categoryID = (comboBoxCategoryPro.SelectedItem as Category).Id;
                int amount = (int)numericUpDownAmount.Value;
                int per = (int)numericUpDownPer.Value;
                int id = Convert.ToInt32(textboxProID.Text);

                if (PromotionDAO.Instance.updatePromotion(id,categoryID, amount, per))
                {
                    MessageBox.Show("Sửa khuyến mãi thành công");
                    loadListPromotion();
                    if (updatePromotion != null)
                    {
                        updatePromotion(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Sửa khuyến mãi thất bại");
                }
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textboxProID.Text);

                if (PromotionDAO.Instance.deletePromotion(id))
                {
                    MessageBox.Show("Xóa khuyến mãi thành công");
                    loadListPromotion();
                    if (deletePromotion != null)
                    {
                        deletePromotion(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Xóa khuyến mãi thất bại");
                }
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        private event EventHandler insertPromotion;
        public event EventHandler InsertPromotion
        {
            add { insertPromotion += value; }
            remove { insertPromotion -= value; }
        }

        private event EventHandler deletePromotion;
        public event EventHandler DeletePromotion
        {
            add { deletePromotion += value; }
            remove { deletePromotion -= value; }
        }

        private event EventHandler updatePromotion;
        public event EventHandler UpdatePromotion
        {
            add { updatePromotion += value; }
            remove { updatePromotion -= value; }
        }

        private void comboBoxCategoryPro_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCategoryPro.Text=="Nước uống")
            {
                numericUpDownPer.Value=0;
                panelPer.Visible = false;
                panelAmount.Visible = true;
            }
            else
            {
                numericUpDownAmount.Value=1;
                panelPer.Visible = true;
                panelAmount.Visible = false;
            }
        }
    }
}
