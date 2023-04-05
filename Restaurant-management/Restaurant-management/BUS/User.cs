using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.DTO
{
    public interface User
    {
        bool showBtnDoanhThu();

        bool showBtnQLNV();

        bool showBtnThucDon();
        bool showBtnKM();
    }


    public class Manager : User
    {
        public bool showBtnDoanhThu()
        {
            return true;
        }

        public bool showBtnKM()
        {
            return true;
        }

        public bool showBtnQLNV()
        {
            return true;
        }

        public bool showBtnThucDon()
        {
            return true;
        }
    }

    public class Staff : User
    {
        public bool showBtnDoanhThu()
        {
            return false;
        }

        public bool showBtnKM()
        {
            return false;
        }

        public bool showBtnQLNV()
        {
            return false;
        }

        public bool showBtnThucDon()
        {
            return false;
        }
    }
}
