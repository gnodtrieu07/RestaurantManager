using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_management.DTO;

namespace Restaurant_management.BUS
{

    public interface Builder
    {
        void reset();
        Builder setUserName(string userName);
        Builder setDisplayName(string displayName);
        Builder setPassWord(string password);
        Builder setWorkHour(string workHour);
        Builder setTypeAccount(int type);
        Account getAccount();
    }

    public class ConcreteBuilder : Builder
    {
        private Account account;

        public ConcreteBuilder()
        {
            this.reset();
        }

        public void reset()
        {
            this.account = new Account();
        }

        public Account getAccount()
        {
            Account newAcc = this.account;
            this.reset();
            return newAcc;
        }

        public Builder setDisplayName(string displayName)
        {
            this.account.DisplayName = displayName;
            return this;
        }

        public Builder setPassWord(string password)
        {
            this.account.PassWord = password;
            return this;
        }

        public Builder setTypeAccount(int type)
        {
            this.account.Type = type;
            return this;
        }

        public Builder setUserName(string userName)
        {
            this.account.UserName = userName;
            return this;
        }

        public Builder setWorkHour(string workHour)
        {
            this.account.WorkHour = workHour;
            return this;
        }
    }
}
