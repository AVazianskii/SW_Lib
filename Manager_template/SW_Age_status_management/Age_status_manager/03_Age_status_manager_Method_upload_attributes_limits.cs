using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Age_status_libs;

namespace SW_Character_creation
{
    public partial class Age_status_manager
    {
        private void Upload_attributes_limits()
        {
            foreach (Age_status_class age_status in Age_statuses)
            {
                int index = Age_statuses.IndexOf(age_status);
                age_status.Age_status_strength_limit        = Age_status_attributes_limits[0][index];
                age_status.Age_status_agility_limit         = Age_status_attributes_limits[1][index];
                age_status.Age_status_stamina_limit         = Age_status_attributes_limits[2][index];
                age_status.Age_status_perception_limit      = Age_status_attributes_limits[3][index];
                age_status.Age_status_quickness_limit       = Age_status_attributes_limits[4][index];
                age_status.Age_status_intelligence_limit    = Age_status_attributes_limits[5][index];
                age_status.Age_status_charm_limit           = Age_status_attributes_limits[6][index];
                age_status.Age_status_willpower_limit       = Age_status_attributes_limits[7][index];
            }
        }
    }
}
