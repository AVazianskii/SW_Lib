using System.Collections.Generic;
using System.Data.SQLite;
using Age_status_libs;

namespace SW_Character_creation
{
    public partial class Age_status_manager : Abstract_manager
    {
        //private static Age_status_manager Age_status_manager_instance;
        public Age_status_class Unknown_age; //private Unknown_age_status
        public Age_status_class Child;//private Child_age
        public Age_status_class Teen;//private Teen_age
        public Age_status_class Adult;//private Adult_age
        public Age_status_class Middle;//private Middle_age
        public Age_status_class Old;//private Old_age
        public Age_status_class Eldery;//private Eldery_age

        private List<Age_status_class> Age_statuses;

        #region переменные для обращения к базе SQLite
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;

        private List<string> Age_status_general_coloumn_name;
        private List<string> Age_status_bonus_coloumn_name;
        private List<string> Age_status_attributes_limits_coloumn_name;
        private List<string> Age_status_skills_limits_coloumn_name;
        private List<string> Age_status_force_skills_limits_coloumn_name;

        private List<List<string>> Age_status_general_description;
        private List<List<int>> Age_status_attributes_bonus;
        private List<List<int>> Age_status_attributes_limits;
        private List<List<int>> Age_status_skills_limits;
        private List<List<int>> Age_status_force_skills_limits;

        private List<string> Age_status_description;
        private List<string> Age_status_feature;
        private List<string> Age_status_ID;
        private List<string> Age_status_name;
        #endregion
    }
}
