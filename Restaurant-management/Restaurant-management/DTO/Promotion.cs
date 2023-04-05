using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.DTO
{
    public class Promotion
    {

        public Promotion(int id, string name, int idCategory, int amount, int per)
        {
            this.ID = id;
            this.Name = name;
            this.IDCategory = idCategory;
            this.Amount = amount;
            this.Per = per;
        }



        public Promotion(DataRow row)
        {
            this.id = (int)row["id"];
            this.Name = row["nameCategory"].ToString();
            this.IDCategory = (int)row["idCategory"];
            this.amount = (int)row["amount"];
            this.per = (int)row["per"];
        }

        private int id;
        private string name;
        private int idCategory;
        private int amount;
        private int per;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IDCategory { get => idCategory; set => idCategory = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Per { get => per; set => per = value; }
    }
}
