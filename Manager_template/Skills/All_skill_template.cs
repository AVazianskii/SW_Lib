using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_creation
{
    public class All_skill_template
    {
        private string skill_base_1,
                       skill_base_2,
                       description,
                       name,
                       img_path,
                       icon_path;


        public string Skill_base_1
        {
            get { return skill_base_1; }
            set { skill_base_1 = value; }
        }
        public string Skill_base_2
        {
            get { return skill_base_2; }
            set { skill_base_2 = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Img_path
        {
            get { return img_path; }
            set { img_path = value; }
        }
        public string Icon_path
        {
            get { return icon_path; }
            set { icon_path = value; }
        }
    }
}
