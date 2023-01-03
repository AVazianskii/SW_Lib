using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SW_Character_creation
{
    public class Abstract_manager : IManager
    {
        private List<List<int>> temp_int_list;
        private List<List<string>> temp_string_list;
        private List<List<bool>> temp_bool_list;
        private List<List<byte>> temp_byte_list;
        private List<List<sbyte>> temp_sbyte_list;



        internal enum Type_of_var
        {
            string_type,
            int_type,
            bool_type,
            byte_type,
            sbyte_type
        }
        public void Run_download_from_SQLite(string SQLite_Command_text,
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
            List<List<bool>> temp_bool_list;

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
                    else if (reading_data_type == (int)Type_of_var.int_type)
                    {
                        temp_int_list = (List<List<int>>)List_for_reading_data;
                        if (!(temp_object is DBNull)) { temp_int_list[index].Add(Convert.ToInt32(temp_object)); } else { temp_int_list[index].Add(0); }
                    }
                    else if (reading_data_type == (int)Type_of_var.bool_type)
                    {
                        temp_bool_list = (List<List<bool>>)List_for_reading_data;
                        if (!(temp_object is DBNull)) { temp_bool_list[index].Add(Convert.ToBoolean(temp_object)); } else { temp_bool_list[index].Add(false); }
                    }
                }
            }
        }
        public void Run_download_general_from_SQLite(string SQLite_Command_text,
                                                     SQLiteConnection SQLite_connection,
                                                     List<string> Names_of_coloumns,
                                                     object List_for_reading_data)
        {
            string SQLite_command_text;
            SQLiteConnection SQLite_conn;
            SQLiteDataReader SQLite_reader;
            bool first_run;
            List<List<string>> temp_string_list;

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
                    //Names_of_coloumns.RemoveAt(1); // удаояем название столбца Название расы
                    first_run = false;
                }
                int index;
                object temp_object;

                foreach (string coloumn_name in Names_of_coloumns)
                {
                    temp_object = SQLite_reader[coloumn_name];
                    index = Names_of_coloumns.IndexOf(coloumn_name);

                    temp_string_list = (List<List<string>>)List_for_reading_data;
                    if (!(temp_object is DBNull)) { temp_string_list[index].Add(Convert.ToString(temp_object)); } else { temp_string_list[index].Add(""); }
                }
            }
        }
        public void Run_download_from_SQLite_v2(string SQLite_Command_text,
                                   SQLiteConnection SQLite_connection,
                                   List<string> Names_of_coloumns,
                                   object List_for_reading_data,
                                   int reading_data_type)
        {
            string SQLite_command_text;
            SQLiteConnection SQLite_conn;
            SQLiteDataReader SQLite_reader;
            bool first_run;
            SQLite_command_text = SQLite_Command_text;
            SQLite_conn = SQLite_connection;
            SQLiteCommand SQLite_command = new SQLiteCommand(SQLite_command_text, SQLite_conn);
            SQLite_reader = SQLite_command.ExecuteReader();

            first_run = true;

            while (SQLite_reader.Read())
            {
                if (first_run)
                {
                    if (reading_data_type == (int)Type_of_var.string_type)
                    {
                        temp_string_list = (List<List<string>>)List_for_reading_data;
                    }
                    else if (reading_data_type == (int)Type_of_var.int_type)
                    {
                        temp_int_list = (List<List<int>>)List_for_reading_data;
                    }
                    else if (reading_data_type == (int)Type_of_var.bool_type)
                    {
                        temp_bool_list = (List<List<bool>>)List_for_reading_data;
                    }
                    else if (reading_data_type == (int)Type_of_var.byte_type)
                    {
                        temp_byte_list = (List<List<byte>>)List_for_reading_data;
                    }
                    else if (reading_data_type == (int)Type_of_var.sbyte_type)
                    {
                        temp_sbyte_list = (List<List<sbyte>>)List_for_reading_data;
                    }

                    for (int i = 2; i < SQLite_reader.FieldCount; i++)
                    {
                        Names_of_coloumns.Add(SQLite_reader.GetName(i));
                        if (reading_data_type == (int)Type_of_var.string_type)
                        {
                            temp_string_list.Add(new List<string>());
                        }
                        else if (reading_data_type == (int)Type_of_var.int_type)
                        {
                            temp_int_list.Add(new List<int>());
                        }
                        else if (reading_data_type == (int)Type_of_var.bool_type)
                        {
                            temp_bool_list.Add(new List<bool>());
                        }
                        else if (reading_data_type == (int)Type_of_var.byte_type)
                        {
                            temp_byte_list.Add(new List<byte>()); 
                        }
                        else if (reading_data_type == (int)Type_of_var.sbyte_type)
                        {
                            temp_sbyte_list.Add(new List<sbyte>());
                        }
                    }
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
                        if (!(temp_object is DBNull))
                        {
                            temp_string_list[index].Add(Convert.ToString(temp_object));
                        }
                        else { temp_string_list[index].Add(""); }
                    }
                    else if (reading_data_type == (int)Type_of_var.int_type)
                    {
                        if (!(temp_object is DBNull))
                        {
                            temp_int_list[index].Add(Convert.ToInt32(temp_object));
                        }
                        else { temp_int_list[index].Add(0); }
                    }
                    else if (reading_data_type == (int)Type_of_var.bool_type)
                    {
                        if (!(temp_object is DBNull))
                        {
                            temp_bool_list[index].Add(Convert.ToBoolean(temp_object));
                        }
                        else { temp_bool_list[index].Add(false); }
                    }
                    else if (reading_data_type == (int)Type_of_var.byte_type)
                    {
                        if (!(temp_object is DBNull))
                        {
                            temp_byte_list[index].Add(Convert.ToByte(temp_object));
                        }
                        else { temp_byte_list[index].Add(0); }
                    }
                    else if (reading_data_type == (int)Type_of_var.sbyte_type)
                    {
                        if (!(temp_object is DBNull))
                        {
                            temp_sbyte_list[index].Add(Convert.ToSByte(temp_object));
                        }
                        else { temp_sbyte_list[index].Add(0); }
                    }
                }
            }
        }
        public virtual void Run_download_and_upload_process() { }
        public void ClearDoubleLists (List<List<int>> DoubleList)
        {
            if (DoubleList.Count > 0)
            {
                foreach(List<int> list in DoubleList)
                {
                    list.Clear();
                    list.TrimExcess();
                }
                DoubleList.Clear();
                DoubleList.TrimExcess();
            }
        }
        public void ClearDoubleLists(List<List<string>> DoubleList)
        {
            if (DoubleList.Count > 0)
            {
                foreach (List<string> list in DoubleList)
                {
                    list.Clear();
                    list.TrimExcess();
                }
                DoubleList.Clear();
                DoubleList.TrimExcess();
            }
        }
        public void ClearDoubleLists(List<List<bool>> DoubleList)
        {
            if (DoubleList.Count > 0)
            {
                foreach (List<bool> list in DoubleList)
                {
                    list.Clear();
                    list.TrimExcess();
                }
                DoubleList.Clear();
                DoubleList.TrimExcess();
            }
        }
        public void ClearList(List<string> list)
        {
            if (list.Count > 0)
            {
                list.Clear();
                list.TrimExcess();
            }
        }
    }
}
