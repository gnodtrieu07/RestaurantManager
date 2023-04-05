using Restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.DecoratorFood;

namespace Restaurant_management.DAO
{
    class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }

        }

        private FoodDAO() { }


        public List<Food> getFood(int id)
        {
            List<Food> listFood = new List<Food>();

            string query = "select * from Food where idCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string id1 = item["idCategory"].ToString();
                Food food = null;
                if (id1.Equals("1"))
                {
                    food = new MainCourse(item);

                }

                if (id1.Equals("2"))
                {
                    food = new Dessert(item);
                }
                if (id1.Equals("3"))
                {
                    food = new Starter(item);
                }
                if (id1.Equals("4"))
                {
                    food = new Rice(item, food);
                }
                if (id1.Equals("5"))
                {
                    food = new Rice(item, food);
                }
                if (id1.Equals("7"))
                {
                    food = new CheeseAndBiscuits(item, food);
                }
                if (id1.Equals("5"))
                {
                    food = new CheeseAndBiscuits(item, food);
                }

                listFood.Add(food);
            }

            return listFood;
        }

        public List<Food> ListFood()
        {
            List<Food> listFood = new List<Food>();

            string query = "select * from Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string id = item["idCategory"].ToString();
                Food food = null;
                if (id.Equals("1"))
                {
                    food = new MainCourse(item);

                }

                if (id.Equals("2"))
                {
                    food = new Dessert(item);
                }
                if (id.Equals("3"))
                {
                    food = new Starter(item);
                }
                if (id.Equals("4"))
                {
                    food = new Rice(item, food);
                }
                if (id.Equals("5"))
                {
                    food = new Rice(item, food);
                }
                if (id.Equals("6"))
                {
                    food = new CheeseAndBiscuits(item, food);
                }
                if (id.Equals("7"))
                {
                    food = new Drink(item, food);
                }

                listFood.Add(food);

            }

            return listFood;
        }

        public bool insertFood(string name, int id, float price)
        {
            string query = string.Format("insert Food (nameFood, idCategory, priceFood) values (N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool updateFood(int idFood, string name, int id, float price)
        {
            string query = string.Format("update Food set nameFood = N'{0}', idCategory = {1}, priceFood = {2} where id = {3}", name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool deleteFood(int idFood)
        {
            BillInfoDAO.Instance.deleteBillInfo(idFood);
            string query = string.Format("delete Food where id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
