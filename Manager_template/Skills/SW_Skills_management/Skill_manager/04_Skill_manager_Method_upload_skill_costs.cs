using System.Collections.Generic;

namespace SW_Character_creation
{
    public partial class Skill_manager
    {
        private void Upload_skill_costs()
        {
            foreach(Skill_Class Skill in _Skills)
            {
                Skill.Set_Non_force_user_cost(Skill_costs[0][_Skills.IndexOf(Skill)]);
                Skill.Set_Forceuser_cost     (Skill_costs[1][_Skills.IndexOf(Skill)]);
            }
        }
    }
}
