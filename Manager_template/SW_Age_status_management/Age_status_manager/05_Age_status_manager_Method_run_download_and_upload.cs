using System.Data.SQLite;
using Attribute_libs;

namespace SW_Character_creation
{
    public partial class Age_status_manager
    {
        public override void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            Run_download_general_from_SQLite("SELECT * FROM Age_statuses_general_info ORDER BY ID",
                                     SQLite_connection,
                                     Age_status_general_coloumn_name,
                                     Age_status_general_description);

            Run_download_from_SQLite_v2("SELECT * FROM Age_statuses_attributes_bonus ORDER BY ID",
                                     SQLite_connection,
                                     Age_status_bonus_coloumn_name,
                                     Age_status_attributes_bonus,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite_v2("SELECT * FROM Age_statuses_attributes_limits ORDER BY ID",
                                     SQLite_connection,
                                     Age_status_attributes_limits_coloumn_name,
                                     Age_status_attributes_limits,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite_v2("SELECT * FROM Age_statuses_skills_limits ORDER BY ID",
                                     SQLite_connection,
                                     Age_status_skills_limits_coloumn_name,
                                     Age_status_skills_limits,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite_v2("SELECT * FROM Age_statuses_force_skills_limits ORDER BY ID",
                                        SQLite_connection,
                                        Age_status_force_skills_limits_coloumn_name,
                                        Age_status_force_skills_limits,
                                        (int)Type_of_var.int_type);

            SQLite_connection.Close();

            Upload_general_info();
            Upload_attributes_bonus();
            Upload_attributes_limits();
            Upload_skills_limits();
        }
    }
}
