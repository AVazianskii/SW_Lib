﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;
using Range_libs;

namespace SW_Character_creation
{
    public class Range_manager : Abstract_manager
    {
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;

        private static Range_manager Range_manager_instance;

        private List<string> Range_general_info_coloumn_name;
        private List<string> Ranges_attributes_limits_coloumn_name;
        private List<string> Range_ID;
        private List<string> Range_name;
        private List<string> Range_description;

        private List<List<string>> Range_general_info;
        private List<List<int>> Ranges_attributes_limits;
        //private List<int> Strength_limit;
        //private List<int> Agility_limit;
        //private List<int> Stamina_limit;
        //private List<int> Quickness_limit;
        //private List<int> Perception_limit;
        //private List<int> Intelligence_limit;
        //private List<int> Charm_limit;
        //private List<int> Willpower_limit;

        private List<Range_Class> _Ranges;



        public List<Range_Class> Ranges ()
        {
            return _Ranges;
        }
        public static Range_manager GetInstance()
        {
            if (Range_manager_instance == null)
            {
                Range_manager_instance = new Range_manager();
            }
            return Range_manager_instance;
        }
        public override void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            Run_download_general_from_SQLite("SELECT * FROM Ranges_general_info ORDER BY ID",
                                             SQLite_connection,
                                             Range_general_info_coloumn_name,
                                             Range_general_info);

            Run_download_from_SQLite_v2("SELECT * FROM Ranges_attributes_limits ORDER BY ID",
                                        SQLite_connection,
                                        Ranges_attributes_limits_coloumn_name,
                                        Ranges_attributes_limits,
                                        (int)Type_of_var.int_type);

            SQLite_connection.Clone();

            // создаем итоговую коллекцию, количество элементов в которой определяется количеством строк в таблице 
            // ориентируемся на столбец ID в таблице основного описания навыка. 
            foreach (var count in Range_general_info[0])
            {
                _Ranges.Add(new Range_Class());

                int index = Range_general_info[0].IndexOf(count);
                _Ranges[index].Set_range_code(Convert.ToInt32(  Range_general_info[00][index]));
                _Ranges[index].Set_range_name(                  Range_general_info[01][index]);
                _Ranges[index].Set_range_descr(                 Range_general_info[02][index]);
            }
        }



        private Range_manager()
        {
            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Ranges.db;Version=3;";
            SQLite_connection = new SQLiteConnection(SQLite_connection_string);

            _Ranges = new List<Range_Class>();

            Range_general_info_coloumn_name = new List<string>();
            Ranges_attributes_limits_coloumn_name = new List<string>();
            Range_general_info = new List<List<string>>();
            Range_ID = new List<string>();
            Range_name = new List<string>();
            Range_description = new List<string>();
            Range_general_info.Add(Range_ID);
            Range_general_info.Add(Range_name);
            Range_general_info.Add(Range_description);
        }

    }
}
