using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Skills_libs;

namespace SW_Character_creation
{
    public partial class Skill_manager : Abstract_manager
    {
        #region переменные для обращения к базе SQLite
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;
        #endregion

    }
}
