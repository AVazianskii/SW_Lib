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

        private int skill_type,
                    skill_max_score,
                    id,
                    score;

        private bool is_chosen;


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
        public int Skill_type
        {
            get { return skill_type; }
            set { skill_type = value; }
        }
        public int Skill_max_score
        {
            get { return skill_max_score; }
            set { skill_max_score = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public bool Is_chosen
        {
            get { return is_chosen; }
            set { is_chosen = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
