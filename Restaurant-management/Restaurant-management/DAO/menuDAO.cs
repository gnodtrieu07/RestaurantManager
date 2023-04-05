using Restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.DAO
{
    public class menuDAO
    {
        private static menuDAO instance;

        public static menuDAO Instance
        {
            get { if (instance == null) instance = new menuDAO(); return menuDAO.instance; }
            private set { menuDAO.instance = value; }

        }

        private menuDAO() { }


        public List<menu> getListMenu(int id)
        {
            List<menu> getListMenu = new List<menu>();

            String strQuery = "select nameFood, count, priceFood, idCategory from BillInfo, Bill, Food where BillInfo.idBill = Bill.id and BillInfo.idFood = Food.id and Bill.statusBill = 0 and Bill.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(strQuery);

            foreach (DataRow item in data.Rows)
            {
                menu me = new menu(item);
                getListMenu.Add(me);
            }

            return getListMenu;
        }
    }
}
