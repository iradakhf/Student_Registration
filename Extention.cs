using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegisterApp
{
    public static class Extention
    {
        
        
        public static bool IsRobotCode(this string robotCode, string notRobotCode)
        {

            if (notRobotCode.Length==4)
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
