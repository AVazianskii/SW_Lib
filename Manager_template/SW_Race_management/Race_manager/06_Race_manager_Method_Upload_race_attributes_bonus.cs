using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public partial class Race_manager
    {
        private void Upload_race_attributes_bonus()
        {
            foreach(Race_class Race in _Races)
            {
                int index = _Races.IndexOf(Race);// Race.Get_race_code()
                Race.Set_race_bonus_strength    (Race_attributes_bonus[Race_attributes_bonus.IndexOf(Strength_bonus)][index]);
                Race.Set_race_bonus_agility     (Race_attributes_bonus[Race_attributes_bonus.IndexOf(Agility_bonus)][index]);
                Race.Set_race_bonus_stamina     (Race_attributes_bonus[Race_attributes_bonus.IndexOf(Stamina_bonus)][index]);
                Race.Set_race_bonus_perception  (Race_attributes_bonus[Race_attributes_bonus.IndexOf(Perception_bonus)][index]);
                Race.Set_race_bonus_quickness   (Race_attributes_bonus[Race_attributes_bonus.IndexOf(Quickness_bonus)][index]);
                Race.Set_race_bonus_intelligence(Race_attributes_bonus[Race_attributes_bonus.IndexOf(Intelligence_bonus)][index]);
                Race.Set_race_bonus_charm       (Race_attributes_bonus[Race_attributes_bonus.IndexOf(Charm_bonus)][index]);
                Race.Set_race_bonus_willpower   (Race_attributes_bonus[Race_attributes_bonus.IndexOf(Willpower_bonus)][index]);
            }
        }
    }
}
