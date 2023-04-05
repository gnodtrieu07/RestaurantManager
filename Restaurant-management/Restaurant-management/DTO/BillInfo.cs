using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.DTO
{
    public class BillInfo
    {

        public BillInfo(int id, int idBill, int idFood, int countFood)
        {
            this.ID = id;
            this.IdBill = idBill;
            this.IdFood = idFood;
            this.CountFood = countFood;
        }


        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdBill = (int)row["idBill"];
            this.IdFood = (int)row["idFood"];
            this.CountFood = (int)row["count"];
        }


        private int countFood;

        public int CountFood
        {
            get { return countFood; }
            set { countFood = value; }
        }


        private int idFood;

        public int IdFood
        {
            get { return idFood; }
            set { idFood = value; }
        }


        private int idBill;

        public int IdBill
        {
            get { return idBill; }
            set { idBill = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
