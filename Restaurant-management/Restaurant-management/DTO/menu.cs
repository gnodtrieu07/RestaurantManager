using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.BUS;
using Restaurant_management.DAO;
using Restaurant_management.DTO;

namespace Restaurant_management.DTO
{
    public class menu
    {

        public menu(String nameFood, int count, float priceFood)
        {
            this.NameFood = nameFood;
            this.Count = count;
            this.PriceFood = priceFood;
        }


        public menu(DataRow row)
        {
            this.NameFood = row["nameFood"].ToString();
            this.Count = (int)row["count"];
            this.IDCategory = (int)row["idCategory"];
            this.PriceFood = (float)Convert.ToDouble(row["priceFood"].ToString());

            Promotion promotion = PromotionDAO.Instance.GetPromotionbyIDCategory(idCategory);
            if (promotion != null)
            {
                if (promotion.Amount != 1 && promotion.Per == 0)
                {
                    this.Strategy = new PromotionByAmount(IDCategory, PriceFood, Count);
                }
                else
                {
                    this.Strategy = new PromotionByPer(IDCategory, PriceFood, Count);
                }

                this.TotalPrice = this.strategy.getTotalPrice();
            }
            else
            {
                this.TotalPrice = this.Count * this.PriceFood;
            }
        }

        private float totalPrice;

        private float priceFood;

        private int count;

        private int idCategory;

        private string nameFood;

        private PromotionStrategy strategy;

        public string NameFood { get => nameFood; set => nameFood = value; }
        public int Count { get => count; set => count = value; }
        public int IDCategory { get => idCategory; set => idCategory = value; }
        public float PriceFood { get => priceFood; set => priceFood = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public PromotionStrategy Strategy { get => strategy; set => strategy = value; }
    }
}
