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
    public partial class fFood : Form
    {
        BindingSource foodList = new BindingSource();
        public fFood()
        {
            InitializeComponent();
            dataFood.DataSource = foodList;
            loadListFood();
            addFoodBinding();
            loadCategory(comboBoxCategoryFood);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.ListFood();
        }
        private void btnWatchFood_Click(object sender, EventArgs e)
        {
            loadListFood();
        }

        void addFoodBinding()
        {
            textboxFoodName.DataBindings.Add(new Binding("Text", dataFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            textboxFoodID.DataBindings.Add(new Binding("Text", dataFood.DataSource, "Id", true, DataSourceUpdateMode.Never));
            numericUpDownPriceFood.DataBindings.Add(new Binding("Value", dataFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
            comboBoxCategoryFood.DataBindings.Add(new Binding("Text", dataFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        void loadCategory(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.getCategory();
            cb.DisplayMember = "Name";
        }
        private void dataFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textboxFoodID_TextChanged(object sender, EventArgs e)
        {
            if (dataFood.SelectedCells.Count > 0)
            {
                int id = (int)dataFood.SelectedCells[0].OwningRow.Cells["IDCategory"].Value | 1;
                Category category = CategoryDAO.Instance.GetCategorybyID(id);
                comboBoxCategoryFood.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach(Category item in comboBoxCategoryFood.Items)
                {
                    if (item.Id == category.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                comboBoxCategoryFood.SelectedIndex = index;
            }
            
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textboxFoodName.Text;
                int categoryID = (comboBoxCategoryFood.SelectedItem as Category).Id;
                float price = (float)numericUpDownPriceFood.Value;

                if (FoodDAO.Instance.insertFood(name, categoryID, price))
                {
                    MessageBox.Show("Thêm món ăn thành công");
                    loadListFood();
                    if (insertFood != null)
                    {
                        insertFood(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Thêm món ăn thất bại");
                }
            }catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textboxFoodName.Text;
                int categoryID = (comboBoxCategoryFood.SelectedItem as Category).Id;
                float price = (float)numericUpDownPriceFood.Value;
                int id = Convert.ToInt32(textboxFoodID.Text);

                if (FoodDAO.Instance.updateFood(id, name, categoryID, price))
                {
                    MessageBox.Show("Sửa món ăn thành công");
                    loadListFood();
                    if (updateFood != null)
                    {
                        updateFood(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Sửa món ăn thất bại");
                }
            }catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textboxFoodID.Text);

                if (FoodDAO.Instance.deleteFood(id))
                {
                    MessageBox.Show("Xóa món ăn thành công");
                    loadListFood();
                    if (deleteFood != null)
                    {
                        deleteFood(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Xóa món ăn thất bại");
                }
            }catch(Exception msg)
            {
                Console.WriteLine(msg);
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
    } 
}
