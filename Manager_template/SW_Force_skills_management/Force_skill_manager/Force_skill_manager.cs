using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SW_Character_creation
{
    public class Force_skill_manager : Abstract_manager
    {
        private static Force_skill_manager Race_manager_instance;

        private List<Force_skill_class> _Force_skills;

        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;

        private List<string> Force_skill_general_info_coloumn_name;
        private List<string> Force_skill_costs_coloumn_name;
        private List<string> Force_skill_types_coloumn_name;
        private List<string> Force_skill_ID;
        private List<string> Force_skill_name;
        private List<string> Force_skill_description;

        private List<List<string>> Force_skill_general_info;

        private List<List<int>> Force_skill_costs;
        private List<List<int>> Force_skill_types;



        public List<Force_skill_class> Force_Skills() { return _Force_skills; }
        public static Force_skill_manager GetInstance()
        {
            if (Race_manager_instance == null)
            {
                Race_manager_instance = new Force_skill_manager();
            }
            return Race_manager_instance;
        }
        public override void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            Run_download_general_from_SQLite("SELECT * FROM Force_skills_general_info ORDER BY ID",
                                             SQLite_connection,
                                             Force_skill_general_info_coloumn_name,
                                             Force_skill_general_info);

            Run_download_from_SQLite_v2("SELECT * FROM Force_skills_costs ORDER BY ID",
                                        SQLite_connection,
                                        Force_skill_costs_coloumn_name,
                                        Force_skill_costs,
                                        (int)Type_of_var.int_type);

            Run_download_from_SQLite_v2("SELECT * FROM Force_skills_types ORDER BY ID",
                                        SQLite_connection,
                                        Force_skill_types_coloumn_name,
                                        Force_skill_types,
                                        (int)Type_of_var.int_type);

            SQLite_connection.Close();

            int index = 0;

            foreach (var count in Force_skill_general_info[0])
            {
                // На каждую новую строку создаем новый инстанс
                _Force_skills.Add(new Force_skill_class());

                // Определяем порядковый нмоер текущего инстанса
                index = Force_skill_general_info[0].IndexOf(count);
            }

        }



        private Force_skill_manager()
        {
            _Force_skills = new List<Force_skill_class>();

            Force_skill_general_info_coloumn_name   = new List<string>();
            Force_skill_costs_coloumn_name          = new List<string>();
            Force_skill_types_coloumn_name          = new List<string>();
            Force_skill_ID                          = new List<string>();
            Force_skill_name                        = new List<string>();
            Force_skill_description                 = new List<string>();

            Force_skill_general_info = new List<List<string>>();

            Force_skill_costs = new List<List<int>>();
            Force_skill_types = new List<List<int>>();

            Force_skill_general_info.Add(Force_skill_ID);
            Force_skill_general_info.Add(Force_skill_name);
            Force_skill_general_info.Add(Force_skill_description);

            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Force_skills.db;Version=3;";

            SQLite_connection = new SQLiteConnection(SQLite_connection_string);
        }
    }
}
