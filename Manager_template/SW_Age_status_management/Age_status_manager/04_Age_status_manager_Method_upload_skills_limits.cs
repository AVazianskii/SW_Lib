using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Age_status_libs;

namespace SW_Character_creation
{
    public partial class Age_status_manager
    {
        private void Upload_skills_limits()
        {
            foreach (Age_status_class age_status in Age_statuses)
            {
                int index = Age_statuses.IndexOf(age_status);
                age_status.Skill_limit       = Age_status_skills_limits      [0][index];
                age_status.Force_skill_limit = Age_status_force_skills_limits[0][index];
            }
        }
    }
}
