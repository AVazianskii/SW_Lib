using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Age_status_libs;

namespace SW_Character_creation
{
    public partial class Age_status_manager
    {
        private void Upload_attributes_bonus()
        {
            foreach (Age_status_class age_status in Age_statuses)
            {
                int index = Age_statuses.IndexOf(age_status);   
                age_status.Set_age_status_strength_bonus    (Age_status_attributes_bonus[0][index]);
                age_status.Set_age_status_agility_bonus     (Age_status_attributes_bonus[1][index]);
                age_status.Set_age_status_stamina_bonus     (Age_status_attributes_bonus[2][index]);
                age_status.Set_age_status_perception_bonus  (Age_status_attributes_bonus[3][index]);
                age_status.Set_age_status_quickness_bonus   (Age_status_attributes_bonus[4][index]);
                age_status.Set_age_status_intelligence_bonus(Age_status_attributes_bonus[5][index]);
                age_status.Set_age_status_charm_bonus       (Age_status_attributes_bonus[6][index]);
                age_status.Set_age_status_willpower_bonus   (Age_status_attributes_bonus[7][index]);
            }
        }
    }
}
