using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_creation
{
    public partial class Age_status_manager
    {
        public static Age_status_manager GetInstance()
        {
            if (Age_status_manager_instance == null)
            {
                Age_status_manager_instance = new Age_status_manager();
            }
            return Age_status_manager_instance;
        }
        public static void DeleteInstance()
        {
            if (Age_status_manager_instance != null)
            {
                Age_status_manager_instance = null;
            }
        }
    }
}
