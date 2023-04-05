using System.Data;
using Restaurant_management.DTO;

namespace Restaurant_management.DecoratorFood
{
    public abstract class FoodDecorator : Food
    {
        protected FoodDecorator(int id, string name, int iDCategory, float price) : base(id, name, iDCategory, price)
        {
        }

        protected FoodDecorator(DataRow row) : base(row)
        {
        }

    }
}