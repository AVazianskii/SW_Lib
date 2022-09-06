using System;
using Attribute_libs;

namespace SW_Character_creation
{
    public partial class Attribute_manager
    {
        public override void Run_download_and_upload_process()
        {
            SQLite_connection.Open();


            Run_download_general_from_SQLite("SELECT * FROM Attributes_general ORDER BY ID",
                                      SQLite_connection,
                                      Attribute_general_coloumn_name,
                                      Attributes_description);

            Run_download_from_SQLite("SELECT * FROM Attributes_cost ORDER BY ID",
                                     SQLite_connection,
                                     Attributes_cost_coloumn_name,
                                     Attribute_costs,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite("SELECT * FROM Attributes_limits_due_range ORDER BY ID",
                                     SQLite_connection,
                                     Attributes_limits_due_range_coloumn_name,
                                     Attribute_range_limits,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite("SELECT * FROM Attributes_limits_due_age_status ORDER BY ID",
                                     SQLite_connection,
                                     Attributes_limits_due_age_status_coloumn_name,
                                     Attribute_age_status_limits,
                                     (int)Type_of_var.int_type);

            SQLite_connection.Close();

            Upload_general_attribute_info();
            Upload_attribute_costs_info();
            Upload_attribute_age_status_limits();
            Upload_attribute_range_limits();

            // Обнуляем коллекции, в которые считываем из базы
            Attribute_general_coloumn_name.Clear();
            Attributes_cost_coloumn_name.Clear();
            Attributes_limits_due_range_coloumn_name.Clear();
            Attributes_limits_due_age_status_coloumn_name.Clear();

            Attributes_description.Clear();
            Attribute_ID.Clear();
            Attribute_name.Clear();
            Attribute_general_description.Clear();

            Attribute_costs.Clear();
            Attribute_cost_atr.Clear();
            Attribute_cost_exp.Clear();

            Attribute_range_limits.Clear();
            Attribute_private_limit.Clear();
            Attribute_veteran_limit.Clear();
            Attribute_hero_limit.Clear();
            Attribute_epic_limit.Clear();
            Attribute_immortal_limit.Clear();

            Attribute_age_status_limits.Clear();
            Attribute_unknown_age_limit.Clear();
            Attribute_child_limit.Clear();
            Attribute_teen_limit.Clear();
            Attribute_adult_limit.Clear();
            Attribute_middle_limit.Clear();
            Attribute_old_limit.Clear();
            Attribute_eldery_limit.Clear();
        }
    }
}
