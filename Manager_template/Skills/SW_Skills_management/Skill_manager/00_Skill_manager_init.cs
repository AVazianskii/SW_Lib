using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SW_Character_creation
{
    public partial class Skill_manager : Abstract_manager
    {
        //private static Skill_manager Skill_manager_instance;

        #region переменные для обращения к базе SQLite
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;
        #endregion

        public List<Skill_Class> _Skills;
        public List<Skill_Class> _Combat_skills;
        public List<Skill_Class> _Survivng_skills;
        public List<Skill_Class> _Charming_skills;
        public List<Skill_Class> _Tech_skills;
        public List<Skill_Class> _Specific_skills;

        private List<List<string>> Skill_desription;
        private List<string> Skill_general_description;
        private List<string> Skill_atr_base_1;
        private List<string> Skill_atr_base_2;
        private List<string> Skill_ID;
        private List<string> Skill_names;

        private List<List<int>> Skill_limits_due_age;
        private List<int> Skill_limits_unknown_age;
        private List<int> Skill_limits_child;
        private List<int> Skill_limits_teen;
        private List<int> Skill_limits_adult;
        private List<int> Skill_limits_middle;
        private List<int> Skill_limits_old;
        private List<int> Skill_limits_eldery;

        private List<List<int>> Skill_limits_due_range;
        private List<int> Skill_limits_private;
        private List<int> Skill_limits_veteran;
        private List<int> Skill_limits_hero;
        private List<int> Skill_limits_epic;
        private List<int> Skill_limits_immortal;

        private List<List<int>> Skill_costs;
        private List<int> Non_forceuser_costs;
        private List<int> Forceuser_costs;

        private List<List<int>> Skill_type;
        private List<int> Combat_skill;

        private List<string> Skill_general_info_coloumn_name;
        private List<string> Skill_costs_coloumn_name;
        private List<string> Skill_limits_due_age_coloumn_name;
        private List<string> Skill_limits_due_range_coloumn_name;
        private List<string> Skill_type_coloumn_name;

        public enum enum_Skills // перечисляем порядок навыков в последовательности, начиная с 0
        {
            Acrobatic_skill,
            Astronavigation_skill,
            Bombing_skill,
            Change_looking_skill,
            Climbing_skill,
            Craft_skill,
            Dancing_skill,
            Deception_skill,
            Diplomacy_skill,
            Driving_skill,
            Drug_production_skill,
            Engineering_skill,
            Evasion_skill,
            Fortitude_skill,
            Hand_combat_skill,
            Heavy_athletics_skill,
            Heavy_gun_skill,
            Insight_skill,
            Interrogation_skill,
            Knowledge_skill,
            Language_skill,
            Leadership_skill,
            Light_gun_skill,
            Light_saber_crafting,
            Light_saber_skill,
            Medicine_skill,
            Music_skill,
            Observation_skill,
            Old_weapon_skill,
            Pilot_skill,
            Programming_skill,
            Repair_skill,
            Resistance_skill,
            Riding_skill,
            Saber_skill,
            Science_skill,
            Swcurity_skill,
            Seduction_skill,
            Singing_skill,
            Sniper_gun_skill,
            Starbattle_tactics_skill,
            Stealth_class,
            Survivng_skill,
            Swimming_skill,
            Throw_skill,
            Trading_skill,
            Training_pet_skill
        }
        internal enum enum_skills_type
        {
            combat_skill = 1,
            survivng_skill,
            charming_skill,
            tech_skill,
            specific_skill
        }
    }
}
