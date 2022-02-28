using System;
using System.Reflection;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Races_libs
{
    public partial class Race_manager
    {
        private void Run_download_from_SQLite(string SQLite_Command_text, 
                                              SQLiteConnection SQLite_connection,
                                              List<string> Names_of_coloumns,
                                              object List_for_reading_data,
                                              int reading_data_type)
        {
            string SQLite_command_text;
            SQLiteConnection SQLite_conn;
            SQLiteDataReader SQLite_reader;
            bool first_run;
            List<List<string>> temp_string_list;
            List<List<int>> temp_int_list;

            SQLite_command_text = SQLite_Command_text;
            SQLite_conn = SQLite_connection;
            SQLiteCommand SQLite_command = new SQLiteCommand(SQLite_command_text, SQLite_conn);
            SQLite_reader = SQLite_command.ExecuteReader();

            first_run = true;

            while (SQLite_reader.Read())
            {
                if (first_run)
                {
                    for (int i = 0; i < SQLite_reader.FieldCount; i++)
                    {
                        Names_of_coloumns.Add(SQLite_reader.GetName(i));
                    }
                    Names_of_coloumns.RemoveAt(0); // удаояем название столбца ID
                    Names_of_coloumns.RemoveAt(0); // удаояем название столбца Название расы
                    first_run = false;
                }
                int index;
                object temp_object;

                foreach (string coloumn_name in Names_of_coloumns)
                {
                    temp_object = SQLite_reader[coloumn_name];
                    index = Names_of_coloumns.IndexOf(coloumn_name);

                    if (reading_data_type == (int)Type_of_var.string_type)
                    {
                        temp_string_list = (List<List<string>>)List_for_reading_data;
                        if (!(temp_object is DBNull)) { temp_string_list[index].Add(Convert.ToString(temp_object)); } else { temp_string_list[index].Add(""); }
                    }
                    else if(reading_data_type == (int)Type_of_var.int_type)
                    {
                        temp_int_list = (List<List<int>>)List_for_reading_data;
                        if (!(temp_object is DBNull)) { temp_int_list[index].Add(Convert.ToInt32(temp_object)); } else { temp_int_list[index].Add(0); }
                    }
                }
            }
        }
    }
}
