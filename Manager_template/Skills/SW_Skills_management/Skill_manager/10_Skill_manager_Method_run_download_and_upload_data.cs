using Skills_libs;

namespace SW_Character_creation
{
    public partial class Skill_manager
    {
        public override void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            Run_download_general_from_SQLite("SELECT * FROM Skills_general ORDER BY ID",
                                             SQLite_connection,
                                             Skill_general_info_coloumn_name,
                                             Skill_desription);

            
            Run_download_from_SQLite("SELECT * FROM Skills_limits_due_age_status ORDER BY ID",
                                     SQLite_connection,
                                     Skill_limits_due_age_coloumn_name,
                                     Skill_limits_due_age,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite("SELECT * FROM Skills_limits_due_range ORDER BY ID",
                                     SQLite_connection,
                                     Skill_limits_due_range_coloumn_name,
                                     Skill_limits_due_range,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite("SELECT * FROM Skills_costs ORDER BY ID",
                                     SQLite_connection,
                                     Skill_costs_coloumn_name,
                                     Skill_costs,
                                     (int)Type_of_var.int_type);
            

            Run_download_from_SQLite("SELECT * FROM Skills_type ORDER BY ID",
                                     SQLite_connection,
                                     Skill_type_coloumn_name,
                                     Skill_type,
                                     (int)Type_of_var.int_type);

            
            SQLite_connection.Close();

            // создаем итоговую коллекцию, количество элементов в которой определяется количеством строк в таблице 
            // ориентируемся на столбец ID в таблице основного описания навыка. 
            foreach (var count in Skill_desription[0]) 
            {
                _Skills.Add(new Skill_Class());
            }

            Upload_skill_general_info();
            Upload_skill_types();
            Upload_skill_limits_due_range();
            Upload_skill_limits_due_age();
            Upload_skill_costs();


            // Обнуляем коллекции, в которые считываем из базы
            ClearList(Skill_general_info_coloumn_name);
            ClearList(Skill_limits_due_age_coloumn_name);
            ClearList(Skill_limits_due_range_coloumn_name);
            ClearList(Skill_costs_coloumn_name);
            ClearList(Skill_type_coloumn_name);

            ClearDoubleLists(Skill_desription);
            ClearDoubleLists(Skill_limits_due_age);
            ClearDoubleLists(Skill_limits_due_range);
            ClearDoubleLists(Skill_costs);
            ClearDoubleLists(Skill_type);
        }
    }
}
