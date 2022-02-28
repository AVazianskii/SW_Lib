using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Skills_libs
{
    public partial class Skill_manager
    {
        #region переменные для обращения к базе SQLite
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;
        #endregion
        private enum Type_of_var
        {
            string_type,
            int_type
        }
    }
}
