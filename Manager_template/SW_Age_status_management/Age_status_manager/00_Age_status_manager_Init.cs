using System.Collections.Generic;
using System.Data.SQLite;
using Age_status_libs;

namespace SW_Character_creation
{
    public partial class Age_status_manager : Abstract_manager
    {
        private static Age_status_manager Age_status_manager_instance;
        private Unknown_age_status Unknown_age;
        private Child_age Child;
        private Teen_age Teen;
        private Adult_age Adult;
        private Middle_age Middle;
        private Old_age Old;
        private Eldery_age Eldery;

        private List<Age_status_class> Age_statuses;

        #region переменные для обращения к базе SQLite
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;
        #endregion
    }
}
