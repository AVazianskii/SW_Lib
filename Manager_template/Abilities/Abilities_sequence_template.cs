using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_creation
{
    public class Abilities_sequence_template
    {
        private All_abilities_template base_ability_lvl;
        private All_abilities_template adept_ability_lvl;
        private All_abilities_template master_ability_lvl;
        private All_abilities_template enable_condition_base;
        private All_abilities_template enable_condition_adept;
        private All_abilities_template enable_condition_master;

        private string name; // 
        private string icon_path;

        private bool is_enabled;



        public All_abilities_template Base_ability_lvl
        {
            get { return base_ability_lvl; }
            set { base_ability_lvl = value; }
        }
        public All_abilities_template Adept_ability_lvl
        {
            get { return adept_ability_lvl; }
            set { adept_ability_lvl = value; }
        }
        public All_abilities_template Master_ability_lvl
        {
            get { return master_ability_lvl; }
            set { master_ability_lvl = value; }
        }
        public All_abilities_template Enable_condition_base
        {
            get { return enable_condition_base; }
            set { enable_condition_base = value; }
        }
        public All_abilities_template Enable_condition_adept
        {
            get { return enable_condition_adept; }
            set { enable_condition_adept = value; }
        }
        public All_abilities_template Enable_condition_master
        {
            get { return enable_condition_master; }
            set { enable_condition_master = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool Is_enabled
        {
            get { return is_enabled; }
            set { is_enabled = value; }
        }
        public string Icon_path
        {
            get { return icon_path; }
            set { icon_path = value; }
        }



        public void Check_enable_state()
        {
            if (Base_ability_lvl != null)
            {
                if ((Enable_condition_base == null) || (Enable_condition_base.Is_chosen))
                {
                    Base_ability_lvl.Is_enable = true;
                }
                else { Base_ability_lvl.Is_enable = false; }
            }

            if (Adept_ability_lvl != null)
            {
                if ((Enable_condition_adept == null) || (Enable_condition_adept.Is_chosen)) //  || (Base_ability_lvl == null)
                {
                    Adept_ability_lvl.Is_enable = true;
                }
                else { Adept_ability_lvl.Is_enable = false; }
            }

            if (Master_ability_lvl != null)
            {
                if ((Enable_condition_master == null) || (Enable_condition_master.Is_chosen)) // || (Adept_ability_lvl == null)
                {
                    Master_ability_lvl.Is_enable = true;
                }
                else { Master_ability_lvl.Is_enable = false; }
            }
        }



        public Abilities_sequence_template()
        {

        }
    }
}
