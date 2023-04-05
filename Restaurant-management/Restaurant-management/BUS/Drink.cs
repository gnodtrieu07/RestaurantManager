using System.Data;
using Restaurant_management.DTO;

namespace Restaurant_management.DecoratorFood
{
    public class Drink:FoodDecorator
    {
        private Food food;

        public Drink(int id, string name, int iDCategory, float price, Food food) : base(id, name, iDCategory, price)
        {
            this.food = food;
        }

        public Drink(DataRow row, Food foods) : base(row)
        {
            this.food = foods;
        }


        public override float GetPrice()
        {
            return this.price + food.GetPrice();

        }

        public override string GetName()
        {
            return this.name + food.GetName();
        }

        public override int GetDCategory()
        {
            return this.iDCategory + food.IDCategory;
        }

        public override int GetID()
        {
            return this.id;

        }
    }
}