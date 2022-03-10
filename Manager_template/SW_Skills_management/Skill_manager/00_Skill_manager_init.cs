using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Skills_libs;

namespace SW_Character_creation
{
    public partial class Skill_manager : Abstract_manager
    {
        private static Skill_manager Skill_manager_instance;

        #region переменные для обращения к базе SQLite
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;
        #endregion



        private List<List<string>> Skill_desription;
        private List<string> Skill_general_description;
        private List<string> Skill_atr_base_1;
        private List<string> Skill_atr_base_2;

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

        private List<List<bool>> Skill_type;
        private List<bool> Combat_skill;

        private List<string> Skill_general_info_coloumn_name;
        private List<string> Skill_costs_coloumn_name;
        private List<string> Skill_limits_due_age_coloumn_name;
        private List<string> Skill_limits_due_range_coloumn_name;
        private List<string> Skill_type_coloumn_name;
    }
}
