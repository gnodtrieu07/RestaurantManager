using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.DTO
{
    public interface Creator
    {
        User createUser();
    }


    public class ManagerUser : Creator
    {
        public User createUser()
        {
            return new Manager();
        }
    }

    public class StaffUser : Creator
    {
        public User createUser()
        {
            return new Staff();
        }
    }
}
