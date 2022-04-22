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
                age_status.Set_age_status_code  (Convert.ToInt32(Age_status_general_description[Age_status_general_description.IndexOf(Age_status_ID)           ][index]));
                age_status.Set_age_status_name                  (Age_status_general_description[Age_status_general_description.IndexOf(Age_status_name)         ][index]);
                age_status.Set_age_status_descr                 (Age_status_general_description[Age_status_general_description.IndexOf(Age_status_description)  ][index]);
                age_status.Set_age_status_feature_descr         (Age_status_general_description[Age_status_general_description.IndexOf(Age_status_feature)      ][index]);
            }
        }
    }
}
