using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skills_libs;

namespace SW_Character_creation
{
    public partial class Skill_manager
    {
        private void Upload_skill_limits_due_age ()
        {
            foreach (Skill_Class Skill in _Skills)
            {
                Skill.Set_unknown_age_status_skill_limit(Skill_limits_due_age[0][_Skills.IndexOf(Skill)]);
                Skill.Set_child_skill_limit             (Skill_limits_due_age[1][_Skills.IndexOf(Skill)]);
                Skill.Set_teen_skill_limit              (Skill_limits_due_age[2][_Skills.IndexOf(Skill)]);
                Skill.Set_adult_skill_limit             (Skill_limits_due_age[3][_Skills.IndexOf(Skill)]);
                Skill.Set_middle_skill_limit            (Skill_limits_due_age[4][_Skills.IndexOf(Skill)]);
                Skill.Set_old_skill_limit               (Skill_limits_due_age[5][_Skills.IndexOf(Skill)]);
                Skill.Set_eldery_skill_limit            (Skill_limits_due_age[6][_Skills.IndexOf(Skill)]);
            }
        }
    }
}
