using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegisterApp
{
    public static class Extention
    {

        public static bool IsRobotCode(this string robotCode)
        {

            if (robotCode.Length < 5 && robotCode.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
