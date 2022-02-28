using Races_libs;

namespace SW_Character_creation
{
    public partial class Race_manager
    {
        public void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            Run_download_from_SQLite("SELECT * FROM Race_general ORDER BY ID",
                                      SQLite_connection,
                                      Race_general_info_coloumn_name,
                                      Race_description,
                                      (int)Type_of_var.string_type);

            Run_download_from_SQLite("SELECT * FROM Race_languages ORDER BY ID",
                                     SQLite_connection,
                                     Race_languages_coloumn_name,
                                     Languages,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite("SELECT * FROM Race_skills_bonus ORDER BY ID",
                                     SQLite_connection,
                                     Race_skill_bonus_coloumn_name,
                                     Race_skills_bonus,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite("SELECT * FROM Race_attributes_bonus ORDER BY ID",
                                     SQLite_connection,
                                     Race_attributes_bonus_coloumn_name,
                                     Race_attributes_bonus,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite("SELECT * FROM Race_age_statuses ORDER BY ID",
                                     SQLite_connection,
                                     Race_age_statuses_coloumn_name,
                                     Race_age_statuses,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite("SELECT * FROM Race_combat_parameters ORDER BY ID",
                                     SQLite_connection,
                                     Race_combat_parameters_coloumn_name,
                                     Race_combat_parameters,
                                     (int)Type_of_var.int_type);

            SQLite_connection.Close();

            Upload_general_info();       // Перекладываем считанные данные в конфигурационные поля объектов рас 
            Upload_languages_info();
            Upload_race_skill_bonus();
            Upload_race_attributes_bonus();
            Upload_race_age_statuses();
            Upload_combat_parameters();
        }
    }
}
