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
        private void Upload_skill_limits_due_range()
        {
            foreach(Skill_Class Skill in _Skills)
            {
                Skill.Set_private_skill_limit   (Skill_limits_due_range[0][_Skills.IndexOf(Skill)]);
                Skill.Set_veteran_skill_limit   (Skill_limits_due_range[1][_Skills.IndexOf(Skill)]);
                Skill.Set_hero_skill_limit      (Skill_limits_due_range[2][_Skills.IndexOf(Skill)]);
                Skill.Set_epic_skill_limit      (Skill_limits_due_range[3][_Skills.IndexOf(Skill)]);
                Skill.Set_immortal_skill_limit  (Skill_limits_due_range[4][_Skills.IndexOf(Skill)]);
            }
        }
    }
}
