using System.Data.SQLite;
using System.Collections.Generic;
using Age_status_libs;

namespace SW_Character_creation
{
    public partial class Age_status_manager
    {
        private Age_status_manager()
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

            SQLite_connection_string = @"Data Source=C:\Users\avazi\Source\Repos\SW_Lib\Manager_template\SW_Age_status_management\Database\Age_statuses.db;Version=3;";
            SQLite_connection = new SQLiteConnection(SQLite_connection_string);
        }
    }
}
