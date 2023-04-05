using Restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }

        }


        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password });
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data =  DataProvider.Instance.ExecuteQuery("select * from Account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool updateAccount(string username, string displayname, string password, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec UpdateAccount @username , @displayname , @password , @newpassword", new object[] { username, displayname, password, newPass });
            return result > 0;
        }

        public DataTable getlistAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select UserName, DisplayName, WorkHour, TypeAccount from Account");
        }

        public bool insertAccount(Account account)
        {
            string query = string.Format("insert Account (UserName, DisplayName, PassWord, WorkHour, TypeAccount) values (N'{0}', N'{1}', N'{2}' ,'{3}',{4})", account.UserName, account.DisplayName,1, account.WorkHour , account.Type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool updateAccount(Account account)
        {
            string query = string.Format("update Account set DisplayName = N'{1}', WorkHour = '{2}', TypeAccount = {3} where UserName = N'{0}'", account.UserName, account.DisplayName, account.WorkHour, account.Type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool deleteAccount(string name)
        {
            string query = string.Format("delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
