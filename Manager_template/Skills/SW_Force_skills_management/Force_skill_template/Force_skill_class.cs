using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_creation
{
    public class Force_skill_class : All_skill_template
    {
        private string description,
                       name,
                       img_path,
                       icon_path;

        private int score,
                    code,
                    cost,
                    type;



        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value;}
        }
        public int Type
        {
            get { return type; }
            set { type = value;  }
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



        public void Increase_score() { Score = Score + 1; }
        public void Decrease_score() { Score = Score - 1; }



        public Force_skill_class ()
        {
            Score = 0;
        }



    }
}
