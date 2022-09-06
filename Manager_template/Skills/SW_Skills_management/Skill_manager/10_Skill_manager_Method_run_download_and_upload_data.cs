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
            Skill_general_info_coloumn_name.Clear();
            Skill_limits_due_age_coloumn_name.Clear();
            Skill_limits_due_range_coloumn_name.Clear();
            Skill_costs_coloumn_name.Clear();
            Skill_type_coloumn_name.Clear();

            Skill_desription.Clear();
            Skill_ID.Clear();
            Skill_names.Clear();
            Skill_general_description.Clear();
            Skill_atr_base_1.Clear();
            Skill_atr_base_2.Clear();

            Skill_limits_due_age.Clear();
            Skill_limits_unknown_age.Clear();
            Skill_limits_child.Clear();
            Skill_limits_teen.Clear();
            Skill_limits_adult.Clear();
            Skill_limits_middle.Clear();
            Skill_limits_old.Clear();
            Skill_limits_eldery.Clear();

            Skill_limits_due_range.Clear();
            Skill_limits_private.Clear();
            Skill_limits_veteran.Clear();
            Skill_limits_hero.Clear();
            Skill_limits_epic.Clear();
            Skill_limits_immortal.Clear();

            Skill_costs.Clear();
            Non_forceuser_costs.Clear();
            Forceuser_costs.Clear();

            Skill_type.Clear();
            Combat_skill.Clear();
        }
    }
}
