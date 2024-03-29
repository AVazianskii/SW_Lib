﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SW_Character_creation
{
    public class Force_skill_manager : Abstract_manager
    {
        //private static Force_skill_manager Race_manager_instance;

        private List<Force_skill_class> _Force_skills;
        private List<Force_skill_class> _Neutral_force_skills;
        private List<Force_skill_class> _Jedi_force_skills;
        private List<Force_skill_class> _Sith_force_skills;

        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;

        private List<string> Force_skill_general_info_coloumn_name;
        private List<string> Force_skill_costs_coloumn_name;
        private List<string> Force_skill_types_coloumn_name;
        private List<string> Force_skill_ID;
        private List<string> Force_skill_name;
        private List<string> Force_skill_description;
        private List<string> Force_skill_base;

        private List<List<string>> Force_skill_general_info;

        private List<List<int>> Force_skill_costs;
        private List<List<int>> Force_skill_types;



        public List<Force_skill_class> Get_Force_Skills() { return _Force_skills; }
        public List<Force_skill_class> Get_Neutral_force_skills() { return _Neutral_force_skills; }
        public List<Force_skill_class> Get_Jedi_force_skills() { return _Jedi_force_skills; }
        public List<Force_skill_class> Get_Sith_force_skills() { return _Sith_force_skills; }
        /*
        public static Force_skill_manager GetInstance()
        {
            if (Race_manager_instance == null)
            {
                Race_manager_instance = new Force_skill_manager();
            }
            return Race_manager_instance;
        }
        public static void OverWriteInstance()
        {
            if (Race_manager_instance != null)
            {
                Race_manager_instance.SQLite_connection = null;
                Race_manager_instance = new Force_skill_manager();
            }
        }*/
        public override void Run_download_and_upload_process()
        {
            using (SQLite_connection = new SQLiteConnection(SQLite_connection_string))
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
            }

            int index = 0;

            foreach (var count in Force_skill_general_info[0])
            {
                // На каждую новую строку создаем новый инстанс
                _Force_skills.Add(new Force_skill_class());

                // Определяем порядковый нмоер текущего инстанса
                index = Force_skill_general_info[0].IndexOf(count);

                _Force_skills[index].ID          = Convert.ToInt32(Force_skill_general_info[0][index]);
                _Force_skills[index].Name        =                 Force_skill_general_info[1][index];
                _Force_skills[index].Description =                 Force_skill_general_info[2][index];
                _Force_skills[index].Skill_base_1=                 Force_skill_general_info[3][index];

                _Force_skills[index].Cost = Force_skill_costs[0][index];

                _Force_skills[index].Type = Force_skill_types[0][index];

                switch (_Force_skills[index].Type)
                {
                    case 1: _Neutral_force_skills.Add(_Force_skills[index]); break;
                    case 2: _Jedi_force_skills.Add   (_Force_skills[index]); break;
                    case 3: _Sith_force_skills.Add   (_Force_skills[index]); break;
                }

                if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_skills\\Images\\" + _Force_skills[index].Name + ".jpg"))
                {
                    _Force_skills[index].Img_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_skills\Images\{_Force_skills[index].Name}.jpg";
                }
                else
                {
                    _Force_skills[index].Img_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                }

                if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_skills\\Icons\\" + _Force_skills[index].Name + ".jpg"))
                {
                    _Force_skills[index].Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_skills\Icons\{_Force_skills[index].Name}";
                }
                else
                {
                    _Force_skills[index].Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                }
            }

            // Обнуляем коллекции, в которые считываем из базы
            ClearList(Force_skill_general_info_coloumn_name);
            ClearList(Force_skill_costs_coloumn_name);
            ClearList(Force_skill_types_coloumn_name);

            ClearDoubleLists(Force_skill_general_info);
            ClearDoubleLists(Force_skill_costs);
            ClearDoubleLists(Force_skill_types);
        }



        public Force_skill_manager()
        {
            _Force_skills = new List<Force_skill_class>();

            Force_skill_general_info_coloumn_name   = new List<string>();
            Force_skill_costs_coloumn_name          = new List<string>();
            Force_skill_types_coloumn_name          = new List<string>();
            Force_skill_ID                          = new List<string>();
            Force_skill_name                        = new List<string>();
            Force_skill_description                 = new List<string>();
            Force_skill_base                        = new List<string>();

            Force_skill_general_info = new List<List<string>>();

            Force_skill_costs = new List<List<int>>();
            Force_skill_types = new List<List<int>>();

            Force_skill_general_info.Add(Force_skill_ID);
            Force_skill_general_info.Add(Force_skill_name);
            Force_skill_general_info.Add(Force_skill_description);
            Force_skill_general_info.Add(Force_skill_base);

            _Neutral_force_skills   = new List<Force_skill_class>();
            _Jedi_force_skills      = new List<Force_skill_class>();
            _Sith_force_skills      = new List<Force_skill_class>();

            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Force_skills.db;Version=3;";

            //SQLite_connection = new SQLiteConnection(SQLite_connection_string);
        }
    }
}
