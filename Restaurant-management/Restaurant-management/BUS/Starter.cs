using System.Data;
using Restaurant_management.DTO;

namespace Restaurant_management.DecoratorFood
{
    public class Starter : Food
    {
        public Starter(int id, string name, int iDCategory, float price) : base(id, name, iDCategory, price)
        {
        }

        public Starter(DataRow row) : base(row)
        {
        }

        public override float GetPrice()
        {
            return this.price;
        }


        public override string GetName()
        {
            throw new System.NotImplementedException();
        }

        public override int GetDCategory()
        {
            return this.iDCategory;
        }

        public override int GetID()
        {
            return this.id;
        }
    }
}