using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.DTO
{
    public class Bill
    {

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount=0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }


        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOutTmp = row["dateCheckOut"];
            if (dateCheckOutTmp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)dateCheckOutTmp;
            }
            this.Status = (int)row["statusBill"];
            if(row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
        }

        private int discount;

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Discount { get => discount; set => discount = value; }
    }
}
