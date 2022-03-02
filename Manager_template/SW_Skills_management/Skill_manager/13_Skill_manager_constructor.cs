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

            Skill_general_info_coloumn_name = new List<string>();
            Skill_costs_coloumn_name = new List<string>();
            Skill_limits_due_age_coloumn_name = new List<string>();
            Skill_limits_due_range_coloumn_name = new List<string>();
            Skill_type_coloumn_name = new List<string>();
        }
    }
}
