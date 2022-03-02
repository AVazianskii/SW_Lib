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

        List<string> Skill_general_info_coloumn_name;
        List<string> Skill_costs_coloumn_name;
        List<string> Skill_limits_due_age_coloumn_name;
        List<string> Skill_limits_due_range_coloumn_name;
        List<string> Skill_type_coloumn_name;
    }
}
