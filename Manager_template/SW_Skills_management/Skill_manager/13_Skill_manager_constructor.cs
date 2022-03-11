using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Skills_libs;

namespace SW_Character_creation
{
    public partial class Skill_manager
    {
        private Skill_manager()
        {
            SQLite_connection_string = @"Data Source=D:\STAR WARS Saga\Character_creation\Manager_template\Manager_template\SW_Skills_management\Database\Skills.db;Version=3;";
            SQLite_connection = new SQLiteConnection(SQLite_connection_string);

            Skill_desription = new List<List<string>>();
            Skill_general_description = new List<string>();
            Skill_atr_base_1 = new List<string>();
            Skill_atr_base_2 = new List<string>();
            Skill_desription.Add(Skill_general_description);
            Skill_desription.Add(Skill_atr_base_1);
            Skill_desription.Add(Skill_atr_base_2);

            Skill_limits_due_age = new List<List<int>>();
            Skill_limits_unknown_age = new List<int>();
            Skill_limits_child = new List<int>();
            Skill_limits_teen = new List<int>();
            Skill_limits_adult = new List<int>();
            Skill_limits_middle = new List<int>();
            Skill_limits_old = new List<int>();
            Skill_limits_eldery = new List<int>();
            Skill_limits_due_age.Add(Skill_limits_unknown_age);
            Skill_limits_due_age.Add(Skill_limits_child);
            Skill_limits_due_age.Add(Skill_limits_teen);
            Skill_limits_due_age.Add(Skill_limits_adult);
            Skill_limits_due_age.Add(Skill_limits_middle);
            Skill_limits_due_age.Add(Skill_limits_old);
            Skill_limits_due_age.Add(Skill_limits_eldery);

            Skill_limits_due_range = new List<List<int>>();
            Skill_limits_private = new List<int>();
            Skill_limits_veteran = new List<int>();
            Skill_limits_hero = new List<int>();
            Skill_limits_epic = new List<int>();
            Skill_limits_immortal = new List<int>();
            Skill_limits_due_range.Add(Skill_limits_private);
            Skill_limits_due_range.Add(Skill_limits_veteran);
            Skill_limits_due_range.Add(Skill_limits_hero);
            Skill_limits_due_range.Add(Skill_limits_epic);
            Skill_limits_due_range.Add(Skill_limits_immortal);

            Skill_costs = new List<List<int>>();
            Non_forceuser_costs = new List<int>();
            Forceuser_costs = new List<int>();
            Skill_costs.Add(Non_forceuser_costs);
            Skill_costs.Add(Forceuser_costs);

            Skill_type = new List<List<bool>>();
            Combat_skill = new List<bool>();
            Skill_type.Add(Combat_skill);

            Skill_general_info_coloumn_name = new List<string>();
            Skill_costs_coloumn_name = new List<string>();
            Skill_limits_due_age_coloumn_name = new List<string>();
            Skill_limits_due_range_coloumn_name = new List<string>();
            Skill_type_coloumn_name = new List<string>();

            _Skills = new List<Skill_Class>();
            _Combat_skills = new List<Skill_Class>();
            _Survivng_skills = new List<Skill_Class>();
            _Charming_skills = new List<Skill_Class>();
            _Tech_skills = new List<Skill_Class>();
            _Specific_skills = new List<Skill_Class>();
            for(int i = 0; i < 50; i++)
            {
                _Skills.Add(new Skill_Class());
            }
            for (int i = 0; i < 6; i++)
            {
                _Combat_skills.Add(_Skills[i]);
            }
            for (int i = 6; i < 12; i++)
            {
                _Survivng_skills.Add(_Skills[i]);
            }
            for (int i = 12; i< 18; i++)
            {
                _Charming_skills.Add(_Skills[i]);
            }
            for (int i = 18; i < 24; i++)
            {
                _Tech_skills.Add(_Skills[i]);
            }
            for (int i = 24; i < 30; i++)
            {
                _Specific_skills.Add(_Skills[i]);
            }
        }
    }
}
