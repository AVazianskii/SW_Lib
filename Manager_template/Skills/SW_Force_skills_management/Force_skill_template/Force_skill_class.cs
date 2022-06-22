using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_creation
{
    public class Force_skill_class : All_skill_template
    {
        private int score,
                    cost,
                    type;



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




        public void Increase_score() { Score = Score + 1; }
        public void Decrease_score() { Score = Score - 1; }



        public Force_skill_class ()
        {
            Score = 0;
        }



    }
}
