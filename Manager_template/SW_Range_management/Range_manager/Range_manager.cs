using System;
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
        private List<string> Ranges_skills_limits_coloumn_name;
        private List<string> Range_ID;
        private List<string> Range_name;
        private List<string> Range_description;

        private List<List<string>> Range_general_info;
        private List<List<int>> Ranges_attributes_limits;
        private List<List<int>> Ranges_skills_limits;


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
        public static void OverWriteInstance()
        {
            if (Range_manager_instance != null)
            {
                Range_manager_instance.SQLite_connection = null;
                Range_manager_instance = new Range_manager();
            }
        }
        public override void Run_download_and_upload_process()
        {
            using (SQLite_connection = new SQLiteConnection(SQLite_connection_string))
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

                Run_download_from_SQLite_v2("SELECT * FROM Ranges_skills_limits ORDER BY ID",
                                            SQLite_connection,
                                            Ranges_skills_limits_coloumn_name,
                                            Ranges_skills_limits,
                                            (int)Type_of_var.int_type);

                SQLite_connection.Close();
            }

            int index = 0;

            // создаем итоговую коллекцию, количество элементов в которой определяется количеством строк в таблице 
            // ориентируемся на столбец ID в таблице основного описания навыка. 
            foreach (var count in Range_general_info[0])
            {
                _Ranges.Add(new Range_Class());

                index = Range_general_info[0].IndexOf(count);
                _Ranges[index].Set_range_code(Convert.ToInt32(  Range_general_info[00][index]));
                _Ranges[index].Set_range_name(                  Range_general_info[01][index]);
                _Ranges[index].Set_range_descr(                 Range_general_info[02][index]);

                _Ranges[index].Strength_limit       = Ranges_attributes_limits[0][index];
                _Ranges[index].Agility_limit        = Ranges_attributes_limits[1][index];
                _Ranges[index].Stamina_limit        = Ranges_attributes_limits[2][index];
                _Ranges[index].Quickness_limit      = Ranges_attributes_limits[3][index];
                _Ranges[index].Perception_limit     = Ranges_attributes_limits[4][index];
                _Ranges[index].Intelligence_limit   = Ranges_attributes_limits[5][index];
                _Ranges[index].Charm_limit          = Ranges_attributes_limits[6][index];
                _Ranges[index].Willpower_limit      = Ranges_attributes_limits[7][index];

                _Ranges[index].Combat_skill_limit    = Ranges_skills_limits[0][index];
                _Ranges[index].Surviving_skill_limit = Ranges_skills_limits[1][index];
                _Ranges[index].Charming_skill_limit  = Ranges_skills_limits[2][index];
                _Ranges[index].Tech_skill_limit      = Ranges_skills_limits[0][index];
                _Ranges[index].Specific_skill_limit  = Ranges_skills_limits[0][index];
            }

            // Обнуляем коллекции, в которые считываем из базы
            ClearList(Range_general_info_coloumn_name);
            ClearList(Ranges_attributes_limits_coloumn_name);
            ClearList(Ranges_skills_limits_coloumn_name);

            ClearDoubleLists(Range_general_info);
            ClearDoubleLists(Ranges_attributes_limits);

        }



        private Range_manager()
        {
            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Ranges.db;Version=3;";
            //SQLite_connection = new SQLiteConnection(SQLite_connection_string);

            _Ranges = new List<Range_Class>();

            Range_general_info_coloumn_name = new List<string>();
            Ranges_attributes_limits_coloumn_name = new List<string>();
            Ranges_skills_limits_coloumn_name = new List<string>();

            Range_general_info = new List<List<string>>();
            Ranges_attributes_limits = new List<List<int>>();
            Ranges_skills_limits = new List<List<int>>();

            Range_ID = new List<string>();
            Range_name = new List<string>();
            Range_description = new List<string>();
            Range_general_info.Add(Range_ID);
            Range_general_info.Add(Range_name);
            Range_general_info.Add(Range_description);
        }

    }
}
