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

        private List<string> Age_status_general_coloumn_name;
        private List<string> Age_status_bonus_coloumn_name;
        private List<string> Age_status_attributes_limits_coloumn_name;
        private List<string> Age_status_skills_limits_coloumn_name;

        private List<List<string>> Age_status_general_description;
        private List<List<int>> Age_status_attributes_bonus;
        private List<List<int>> Age_status_attributes_limits;
        private List<List<int>> Age_status_skills_limits;

        private List<int> Age_status_description;
        private List<int> Age_status_feature;
        #endregion
    }
}
