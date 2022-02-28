using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public partial class Race_manager
    {
        private void Upload_combat_parameters()
        {
            foreach (Race_class Race in _Races)
            {
                int index = _Races.IndexOf(Race);
                Race.Set_race_reaction_bonus(Race_combat_parameters[Race_combat_parameters.IndexOf(Reaction_bonus)][index]);
                Race.Set_race_armor_bonus(Race_combat_parameters[Race_combat_parameters.IndexOf(Armor_bonus)][index]);
                Race.Set_race_stealthiness_combat_bonus(Race_combat_parameters[Race_combat_parameters.IndexOf(Stealthiness_combat_bonus)][index]);
                Race.Set_race_watchfulness_combat_bonus(Race_combat_parameters[Race_combat_parameters.IndexOf(Watchfulness_combat_bonus)][index]);
                Race.Set_race_force_resist_bonus(Race_combat_parameters[Race_combat_parameters.IndexOf(Force_resist_bonus)][index]);
                Race.Set_race_flow_control_bonus(Race_combat_parameters[Race_combat_parameters.IndexOf(Flow_control_bonus)][index]);
            }
        }
    }
}
