using Restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.DAO
{
    class PromotionDAO
    {
        private static PromotionDAO instance;

        public static PromotionDAO Instance
        {
            get { if (instance == null) instance = new PromotionDAO(); return PromotionDAO.instance; }
            private set { PromotionDAO.instance = value; }

        }

        private PromotionDAO() { }


        public List<Promotion> ListPromotion()
        {
            List<Promotion> listPromotion = new List<Promotion>();

            string query = "select Promotion.id, FoodCategory.nameCategory, Promotion.idCategory, Promotion.amount, Promotion.per from Promotion join FoodCategory on FoodCategory.id=Promotion.idCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Promotion promotion = new Promotion(item);
                listPromotion.Add(promotion);
            }

            return listPromotion;
        }

        public Promotion GetPromotionbyIDCategory(int id)
        {
            Promotion promotion = null;
            string query = "select * from Promotion join FoodCategory on FoodCategory.id=Promotion.idCategory where idCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                promotion = new Promotion(item);
                return promotion;
            }
            return promotion;
        }

        public bool insertPromotion(int idCategory, int amount, int per)
        {
            string query = string.Format("insert Promotion (idCategory, amount, per) values ({0}, {1}, {2})", idCategory, amount, per);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool updatePromotion(int id,int idCategory, int amount, int per)
        {
            string query = string.Format("update Promotion set idCategory = {0}, amount = {1}, per={2} where id = {3}", idCategory, amount, per, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool deletePromotion(int id)
        {
            string query = string.Format("delete Promotion where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
