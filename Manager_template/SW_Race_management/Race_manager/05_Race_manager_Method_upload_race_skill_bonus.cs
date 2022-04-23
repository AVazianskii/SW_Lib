using System.Collections.Generic;
using Races_libs;

namespace SW_Character_creation
{
    public partial class Race_manager
    {
        private void Upload_race_skill_bonus()
        {
            foreach(Race_class Race in _Races)
            {
                int index = _Races.IndexOf(Race);
                foreach (List<int> list in Race_skills_bonus)
                {
                    Race.Race_skill_bonus.Add(list[index]);
                }
            }
        }
    }
}
