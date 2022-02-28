using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Skills_libs
{
    public partial class Skill_manager
    {
        public Skill_manager()
        {
            SQLite_connection_string = @"Data Source=D:\STAR WARS Saga\Character_creation\Atributes_Libs\Attributes.db;Version=3;";
            SQLite_connection = new SQLiteConnection(SQLite_connection_string);
        }
    }
}
