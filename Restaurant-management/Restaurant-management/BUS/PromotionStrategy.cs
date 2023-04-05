using Restaurant_management.DAO;
using Restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.BUS
{
    public abstract class PromotionStrategy
    {
        public int idCategory;
        public float priceFood;
        public int count;
        public int amount;
        public float per;
        public float totalPrice;


        public PromotionStrategy(int idCategory, float priceFood, int count)
        {
            this.idCategory = idCategory;
            this.priceFood = priceFood;
            this.count = count;
        }

        public float getTotalPrice()
        {
            findPromotion();
            calculator();
            return this.totalPrice;
        }

        public void findPromotion()
        {
            Promotion promotion = PromotionDAO.Instance.GetPromotionbyIDCategory(idCategory);
            this.amount = (int)promotion.Amount;
            this.per = (float)promotion.Per/100;
        }

        public abstract void calculator();
    }

    public class PromotionByPer : PromotionStrategy
    {
        public PromotionByPer(int idCategory, float priceFood, int count) : base(idCategory, priceFood, count) { }

        public override void calculator()
        {
            this.totalPrice = (priceFood * count) * (1 - this.per);
        }
    }

    public class PromotionByAmount : PromotionStrategy
    {
        public PromotionByAmount(int idCategory, float priceFood, int count) : base(idCategory, priceFood, count) { }

        public override void calculator()
        {
            if (count >= amount)
                this.totalPrice = (priceFood * count) - 15000;
            else
                this.totalPrice = (priceFood * count);
        }
    }
}
