using System;
namespace Attribute_libs
{
    public partial class Attribute_manager
    {
        public void Run_download_and_upload_data()
        {
            SQLite_connection.Open();


            Run_download_from_SQLite("SELECT * FROM Attributes_general ORDER BY ID",
                                      SQLite_connection,
                                      Attribute_general_coloumn_name,
                                      Attributes_description,
                                      (int)Type_of_var.string_type);

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
        }
    }
}
