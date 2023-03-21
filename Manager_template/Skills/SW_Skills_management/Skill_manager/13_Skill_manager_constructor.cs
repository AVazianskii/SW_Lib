using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SW_Character_creation
{
    public partial class Skill_manager
    {
        public Skill_manager()
        { 
            
            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Skills.db;Version=3;";
            //SQLite_connection = new SQLiteConnection(SQLite_connection_string);

            Skill_desription = new List<List<string>>();
            Skill_ID = new List<string>();
            Skill_names = new List<string>();
            Skill_general_description = new List<string>();
            Skill_atr_base_1 = new List<string>();
            Skill_atr_base_2 = new List<string>();
            Skill_desription.Add(Skill_ID);
            Skill_desription.Add(Skill_names);
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

            Skill_type = new List<List<int>>();
            Combat_skill = new List<int>();
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

        }
    }
}
