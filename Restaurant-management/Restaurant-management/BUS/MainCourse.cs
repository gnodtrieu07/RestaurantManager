using System.Data;
using Restaurant_management.DTO;

namespace Restaurant_management.DecoratorFood
{
    public class MainCourse:Food
    {
        public MainCourse(int id, string name, int iDCategory, float price) : base(id, name, iDCategory, price)
        {
        }


        public override float GetPrice()
        {
            return this.price;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override int GetDCategory()
        {
            return this.iDCategory;
        }

        public override int GetID()
        {
            return this.id;
        }

        public MainCourse(DataRow row) : base(row)
        {
        }
    }
}