﻿using Skills_libs;
using System;

namespace SW_Character_creation
{
    public partial class Skill_manager
    {
        private void Upload_skill_general_info()
        {
            foreach (Skill_Class Skill in _Skills)
            {
                Skill.Set_skill_code(Convert.ToInt32(Skill_desription[0][_Skills.IndexOf(Skill)]));
                for (int i = 0; i < _Skills.Capacity - 1; i++)
                {
                    if (i == Skill.Get_skill_code())
                    {

                        Skill.Set_skill_description (Skill_desription[1][_Skills.IndexOf(Skill)]);
                        Skill.Set_skill_base_1      (Skill_desription[2][_Skills.IndexOf(Skill)]);
                        Skill.Set_skill_base_2      (Skill_desription[3][_Skills.IndexOf(Skill)]);
                        break;
                    }
                }
            }
        }
    }
}
