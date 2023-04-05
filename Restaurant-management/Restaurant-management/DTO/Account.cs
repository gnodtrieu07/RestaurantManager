using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.BUS;

namespace Restaurant_management.DTO
{
    public class Account
    {
        public Account() { }

        public Account(string userName, string displayName, int type, string workHour, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.WorkHour = workHour;
            this.PassWord = password;
        }


        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["TypeAccount"];
            this.PassWord = row["password"].ToString();
            this.WorkHour = row["workHour"].ToString();
        }

        private string userName;
        private string displayName;
        private string passWord;
        private int type;
        private string workHour;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Type { get => type; set => type = value; }

        public string WorkHour { get => workHour; set => workHour = value; }
    }
}
