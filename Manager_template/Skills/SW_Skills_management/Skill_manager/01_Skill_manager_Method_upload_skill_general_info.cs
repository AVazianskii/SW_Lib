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
                Skill.ID = Convert.ToInt32(Skill_desription[0][_Skills.IndexOf(Skill)]);
                for (int i = 0; i < _Skills.Capacity - 1; i++)
                {
                    if (i == Skill.ID)
                    {
                        Skill.Name          = Skill_desription[1][_Skills.IndexOf(Skill)];
                        Skill.Description   = Skill_desription[2][_Skills.IndexOf(Skill)];
                        Skill.Skill_base_1  = Skill_desription[3][_Skills.IndexOf(Skill)];
                        Skill.Skill_base_2  = Skill_desription[4][_Skills.IndexOf(Skill)];

                        if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Skills\\Images\\" + Skill.Name + ".jpg"))
                        {
                            Skill.Img_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Skills\Images\{Skill.Name}.jpg";
                        }
                        else
                        {
                            Skill.Img_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                        }

                        if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Skills\\Icons\\" + Skill.Name + ".jpg"))
                        {
                            Skill.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Skills\Icons\{Skill.Name}.jpg";
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
