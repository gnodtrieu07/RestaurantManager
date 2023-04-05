using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.DTO
{
    public abstract class Food
    {

        protected Food(int id, string name, int iDCategory, float price)
        {
            this.Id = id;
            this.Name = name;
            this.IDCategory = iDCategory;
            this.Price = price;
        }

        protected Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["nameFood"].ToString();
            this.IDCategory = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["priceFood"].ToString());
        }


        protected int id;
        protected string name;
        protected int iDCategory;
        protected float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IDCategory { get => iDCategory; set => iDCategory = value; }
        public float Price { get => price; set => price = value; }
        public abstract float GetPrice();
        public abstract string GetName();
        public abstract int GetDCategory();
        public abstract int GetID();


    }
}
