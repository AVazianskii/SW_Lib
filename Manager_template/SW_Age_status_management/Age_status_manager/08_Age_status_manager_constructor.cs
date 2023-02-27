using System.Data.SQLite;
using System.Collections.Generic;
using Age_status_libs;
using System.IO;

namespace SW_Character_creation
{
    public partial class Age_status_manager
    {
        public Age_status_manager()
        {
            Unknown_age = new Unknown_age_status();
            Child = new Child_age();
            Teen = new Teen_age(); 
            Adult = new Adult_age(); 
            Middle = new Middle_age();
            Old = new Old_age();
            Eldery = new Eldery_age();
            Age_statuses = new List<Age_status_class>();
            Age_statuses.Add(Unknown_age);
            Age_statuses.Add(Child);
            Age_statuses.Add(Teen);
            Age_statuses.Add(Adult);
            Age_statuses.Add(Middle);
            Age_statuses.Add(Old);
            Age_statuses.Add(Eldery);

            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Age_statuses.db;Version=3;";
            //SQLite_connection = new SQLiteConnection(SQLite_connection_string);

            Age_status_general_coloumn_name = new List<string>();
            Age_status_bonus_coloumn_name = new List<string>();
            Age_status_attributes_limits_coloumn_name = new List<string>();
            Age_status_skills_limits_coloumn_name = new List<string>();
            Age_status_force_skills_limits_coloumn_name = new List<string>();

            Age_status_general_description = new List<List<string>>();
            Age_status_description = new List<string>();
            Age_status_feature = new List<string>();
            Age_status_ID = new List<string>();
            Age_status_name = new List<string>();
            Age_status_general_description.Add(Age_status_ID);
            Age_status_general_description.Add(Age_status_name);
            Age_status_general_description.Add(Age_status_description);
            Age_status_general_description.Add(Age_status_feature);

            Age_status_attributes_bonus = new List<List<int>>();
            Age_status_attributes_limits = new List<List<int>>();
            Age_status_skills_limits = new List<List<int>>();
            Age_status_force_skills_limits = new List<List<int>>();



        }
    }
}
