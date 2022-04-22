using System;
using System.Collections.Generic;
using Skills_libs;

namespace SW_Character_creation
{
    public partial class Skill_manager
    {
        private void Upload_skill_types()
        {
            foreach(Skill_Class Skill in _Skills)
            {
                Skill.Skill_type = Skill_type[0][_Skills.IndexOf(Skill)];
                if (Skill.Skill_type == (int)enum_skills_type.combat_skill)
                {
                    _Combat_skills.Add(Skill);
                }
                if (Skill.Skill_type == (int)enum_skills_type.survivng_skill)
                {
                    _Survivng_skills.Add(Skill);
                }
                if (Skill.Skill_type == (int)enum_skills_type.charming_skill)
                {
                    _Charming_skills.Add(Skill);
                }
                if (Skill.Skill_type == (int)enum_skills_type.tech_skill)
                {
                    _Tech_skills.Add(Skill);
                }
                if (Skill.Skill_type == (int)enum_skills_type.specific_skill)
                {
                    _Specific_skills.Add(Skill);
                }
            }
        }
    }
}
