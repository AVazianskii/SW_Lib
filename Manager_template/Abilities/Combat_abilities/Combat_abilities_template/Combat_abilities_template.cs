using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_creation
{
    public class Combat_abilities_template : All_abilities_template
    {
        private int reaction_bonus,
                    armor_bonus,
                    force_resistance_bonus,
                    stealthness_bonus,
                    watchfullness_bonus,
                    concentration_bonus;

        public int Reaction_bonus
        {
            get { return reaction_bonus; }
            set { reaction_bonus = value; }
        }
        public int Armor_bonus
        {
            get { return armor_bonus; }
            set { armor_bonus = value; }
        }
        public int Force_resistance_bonus
        {
            get { return force_resistance_bonus; }
            set { force_resistance_bonus = value; }
        }
        public int Stealthness_bonus
        {
            get { return stealthness_bonus; }
            set { stealthness_bonus = value; }
        }
        public int Watchfullness_bonus
        {
            get { return watchfullness_bonus; }
            set { watchfullness_bonus = value; }
        }
        public int Concentration_bonus
        {
            get { return concentration_bonus; }
            set { concentration_bonus = value; }
        }
    }
}
