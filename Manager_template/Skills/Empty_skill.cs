using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_creation
{
    public class Empty_skill : All_skill_template
    {
        public Empty_skill()
        {
            Skill_base_1 = "";
            Skill_base_2 = "";
            Name = "";
            Description = "";
            Img_path = "";
            Icon_path = "";
            Skill_type = 0;
            Skill_max_score = 0;
            ID = 0;
        }
    }
}
