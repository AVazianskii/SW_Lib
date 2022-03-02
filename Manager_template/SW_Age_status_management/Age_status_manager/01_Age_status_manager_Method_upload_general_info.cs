using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Age_status_libs;

namespace SW_Character_creation
{
    public partial class Age_status_manager
    {
        private void Upload_general_info()
        {
            foreach(Age_status_class age_status in Age_statuses)
            {
                int index = Age_statuses.IndexOf(age_status);
                age_status.Get_age_status_descr(Age_status_general_description[Age_status_general_description.IndexOf()][index]);
            }
        }
    }
}
