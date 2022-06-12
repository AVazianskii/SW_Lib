﻿using Skills_libs;
using System;
using System.IO;

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
                        Skill.Name          = Skill_desription[1][_Skills.IndexOf(Skill)];
                        Skill.Description   = Skill_desription[2][_Skills.IndexOf(Skill)];
                        Skill.Skill_base_1  = Skill_desription[3][_Skills.IndexOf(Skill)];
                        Skill.Skill_base_2  = Skill_desription[4][_Skills.IndexOf(Skill)];

                        if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Skills\\Images\\" + Skill.Name))
                        {
                            Skill.Img_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Skills\Images\{Skill.Name}";
                        }
                        else
                        {
                            Skill.Img_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                        }

                        if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Skills\\Icons\\" + Skill.Name))
                        {
                            Skill.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Skills\Icons\{Skill.Name}";
                        }
                        else
                        {
                            Skill.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                        }
                        break;
                    }
                }
            }
        }
    }
}
