using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Races_libs;

namespace SW_Character_creation
{
    public class Race__manager : Abstract_manager
    {
        private static Race__manager Race_manager_instance;

        public List<Race_class> _Races;

        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;

        private List<List<string>> Race_description;
        private List<string> Race_general_info_coloumn_name;
        private List<List<int>> Languages; // инициализация коллекции различных языков
        private List<string> Race_languages_coloumn_name; // инициализация коллекции столбцов в таблице по уровням знания языков у рас
        private List<string> Race_skill_bonus_coloumn_name;
        private List<List<int>> Race_skills_bonus;
        private List<string> Race_attributes_bonus_coloumn_name;
        private List<List<int>> Race_attributes_bonus;
        private List<string> Race_age_statuses_coloumn_name;
        private List<List<int>> Race_age_statuses;
        private List<string> Race_combat_parameters_coloumn_name;
        private List<List<int>> Race_combat_parameters;

        private List<string> ID_Race;
        private List<string> Race_name;
        private List<string> General_description;
        private List<string> Personal_properties;
        private List<string> Physical_properties;
        private List<string> Home_world;
        private List<string> Language_1;
        private List<string> Language_2;
        private List<string> Language_3;
        private List<string> Language_4;
        private List<string> Feature_1;
        private List<string> Feature_2;
        private List<string> Feature_3;
        private List<string> Feature_4;
        private List<string> Feature_5;
        private List<string> Feature_6;
        private List<string> Feature_7;



        public List<Race_class> Get_Race_list() { return _Races; }
        public static Race__manager GetInstance()
        {
            if (Race_manager_instance == null)
            {
                Race_manager_instance = new Race__manager();
            }
            return Race_manager_instance;
        }
        public override void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            Run_download_general_from_SQLite("SELECT * FROM Race_general ORDER BY ID",
                                             SQLite_connection,
                                             Race_general_info_coloumn_name,
                                             Race_description);

            Run_download_from_SQLite_v2("SELECT * FROM Race_languages ORDER BY ID",
                                     SQLite_connection,
                                     Race_languages_coloumn_name,
                                     Languages,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite_v2("SELECT * FROM Race_skills_bonus ORDER BY ID",
                                     SQLite_connection,
                                     Race_skill_bonus_coloumn_name,
                                     Race_skills_bonus,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite_v2("SELECT * FROM Race_attributes_bonus ORDER BY ID",
                                     SQLite_connection,
                                     Race_attributes_bonus_coloumn_name,
                                     Race_attributes_bonus,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite_v2("SELECT * FROM Race_age_statuses ORDER BY ID",
                                     SQLite_connection,
                                     Race_age_statuses_coloumn_name,
                                     Race_age_statuses,
                                     (int)Type_of_var.int_type);

            Run_download_from_SQLite_v2("SELECT * FROM Race_combat_parameters ORDER BY ID",
                                     SQLite_connection,
                                     Race_combat_parameters_coloumn_name,
                                     Race_combat_parameters,
                                     (int)Type_of_var.int_type);

            SQLite_connection.Close();

            int index = 0;

            foreach (var count in Race_description[0])
            {
                // На каждую новую строку создаем новый инстанс
                _Races.Add(new Race_class());

                // Определяем порядковый нмоер текущего инстанса
                index = Race_description[0].IndexOf(count);
                
                
                // Перекладываем инфу из базы в поля общего описания
                _Races[index].Set_race_code (Convert.ToInt32(Race_description[00][index]));
                _Races[index].Set_race_name                 (Race_description[01][index]);
                _Races[index].Set_general_description       (Race_description[02][index]);
                _Races[index].Set_personal_properties       (Race_description[03][index]);
                _Races[index].Set_physical_properties       (Race_description[04][index]);
                _Races[index].Set_home_world                (Race_description[05][index]);
                _Races[index].Set_language_1                (Race_description[06][index]);
                _Races[index].Set_language_2                (Race_description[07][index]);
                _Races[index].Set_language_3                (Race_description[08][index]);
                _Races[index].Set_language_4                (Race_description[09][index]);
                _Races[index].Set_feature_1                 (Race_description[10][index]);
                _Races[index].Set_feature_2                 (Race_description[11][index]);
                _Races[index].Set_feature_3                 (Race_description[12][index]);
                _Races[index].Set_feature_4                 (Race_description[13][index]);
                _Races[index].Set_feature_5                 (Race_description[14][index]);
                _Races[index].Set_feature_6                 (Race_description[15][index]);
                _Races[index].Set_feature_7                 (Race_description[16][index]);
                
                
                // Заполняем ссылки на картинки рас
                _Races[index].Set_img_path      ($@"{Directory.GetCurrentDirectory()}\Pictures\Races\Images\{_Races[index].Get_race_name()}.jpg");
                _Races[index].Set_small_img_path($@"{Directory.GetCurrentDirectory()}\Pictures\Races\Icons\{_Races[index].Get_race_name()}.jpg");
                

                // Определяем уровень владения различными языками
                
                foreach (string race_language in Race_languages_coloumn_name)
                {
                    if (_Races[index].Get_language_1() == race_language)
                    {
                        _Races[index].Set_language_1_lvl(Languages[Race_languages_coloumn_name.IndexOf(race_language)][index]);
                    }
                    if (_Races[index].Get_language_2() == race_language)
                    {
                        _Races[index].Set_language_2_lvl(Languages[Race_languages_coloumn_name.IndexOf(race_language)][index]);
                    }
                    if (_Races[index].Get_language_3() == race_language)
                    {
                        _Races[index].Set_language_3_lvl(Languages[Race_languages_coloumn_name.IndexOf(race_language)][index]);
                    }
                    if (_Races[index].Get_language_4() == race_language)
                    {
                        _Races[index].Set_language_4_lvl(Languages[Race_languages_coloumn_name.IndexOf(race_language)][index]);
                    }
                }


                // Определяем расовые бонусы различных навыков
                foreach (List<int> list in Race_skills_bonus)
                {
                    _Races[index].Race_skill_bonus.Add(list[_Races[index].Get_race_code() - 1]);
                }


                // Определяем расовые бонусы различных атрибутов
                _Races[index].Set_race_bonus_strength       (Race_attributes_bonus[0][index]);
                _Races[index].Set_race_bonus_agility        (Race_attributes_bonus[1][index]);
                _Races[index].Set_race_bonus_stamina        (Race_attributes_bonus[2][index]);
                _Races[index].Set_race_bonus_perception     (Race_attributes_bonus[3][index]);
                _Races[index].Set_race_bonus_quickness      (Race_attributes_bonus[4][index]);
                _Races[index].Set_race_bonus_intelligence   (Race_attributes_bonus[5][index]);
                _Races[index].Set_race_bonus_charm          (Race_attributes_bonus[6][index]);
                _Races[index].Set_race_bonus_willpower      (Race_attributes_bonus[7][index]);

                // Определяем расовые границы различных возрастных статусов
                _Races[index].Set_min_child_age (Race_age_statuses[00][index]);
                _Races[index].Set_max_child_age (Race_age_statuses[01][index]);
                _Races[index].Set_min_teen_age  (Race_age_statuses[02][index]);
                _Races[index].Set_max_teen_age  (Race_age_statuses[03][index]);
                _Races[index].Set_min_adult_age (Race_age_statuses[04][index]);
                _Races[index].Set_max_adult_age (Race_age_statuses[05][index]);
                _Races[index].Set_min_middle_age(Race_age_statuses[06][index]);
                _Races[index].Set_max_middle_age(Race_age_statuses[07][index]);
                _Races[index].Set_min_old_age   (Race_age_statuses[08][index]);
                _Races[index].Set_max_old_age   (Race_age_statuses[09][index]);
                _Races[index].Set_min_eldery_age(Race_age_statuses[10][index]);

                // Определяем расовые бонусы боевых параметров
                _Races[index].Set_race_reaction_bonus           (Race_combat_parameters[0][index]);
                _Races[index].Set_race_armor_bonus              (Race_combat_parameters[1][index]);
                _Races[index].Set_race_force_resist_bonus       (Race_combat_parameters[2][index]);
                _Races[index].Set_race_stealthiness_combat_bonus(Race_combat_parameters[3][index]);
                _Races[index].Set_race_watchfulness_combat_bonus(Race_combat_parameters[4][index]);
                _Races[index].Set_race_flow_control_bonus       (Race_combat_parameters[5][index]);
                
            }


            // Обнуляем коллекции, в которые считываем из базы
            Race_general_info_coloumn_name = null;
            Race_languages_coloumn_name = null;
            Race_skill_bonus_coloumn_name = null;
            Race_attributes_bonus_coloumn_name = null;
            Race_age_statuses_coloumn_name = null;
            Race_combat_parameters_coloumn_name = null;

            Race_description = null;
            ID_Race = null;
            Race_name = null;
            General_description = null;
            Personal_properties = null;
            Physical_properties = null;
            Home_world = null;
            Language_1 = null;
            Language_2 = null;
            Language_3 = null;
            Language_4 = null;
            Feature_1 = null;
            Feature_2 = null;
            Feature_3 = null;
            Feature_4 = null;
            Feature_5 = null;
            Feature_6 = null;

            Languages = null;
            Race_skills_bonus = null;
            Race_attributes_bonus = null;
            Race_age_statuses = null;
            Race_combat_parameters = null;
        }



        private Race__manager()
        {
            _Races = new List<Race_class>();

            Race_description = new List<List<string>>();

            ID_Race             = new List<string>();
            Race_name           = new List<string>();
            General_description = new List<string>();
            Personal_properties = new List<string>();
            Physical_properties = new List<string>();
            Home_world          = new List<string>();
            Language_1          = new List<string>();
            Language_2          = new List<string>();
            Language_3          = new List<string>();
            Language_4          = new List<string>();
            Feature_1           = new List<string>();
            Feature_2           = new List<string>();
            Feature_3           = new List<string>();
            Feature_4           = new List<string>();
            Feature_5           = new List<string>();
            Feature_6           = new List<string>();
            Feature_7           = new List<string>();

            Race_description.Add(ID_Race);
            Race_description.Add(Race_name);
            Race_description.Add(General_description);
            Race_description.Add(Personal_properties);
            Race_description.Add(Physical_properties);
            Race_description.Add(Home_world);
            Race_description.Add(Language_1);
            Race_description.Add(Language_2);
            Race_description.Add(Language_3);
            Race_description.Add(Language_4);
            Race_description.Add(Feature_1);
            Race_description.Add(Feature_2);
            Race_description.Add(Feature_3);
            Race_description.Add(Feature_4);
            Race_description.Add(Feature_5);
            Race_description.Add(Feature_6);
            Race_description.Add(Feature_7);

            Languages               = new List<List<int>>();
            Race_attributes_bonus   = new List<List<int>>();
            Race_age_statuses       = new List<List<int>>();
            Race_combat_parameters  = new List<List<int>>();
            Race_skills_bonus       = new List<List<int>>();

            Race_general_info_coloumn_name      = new List<string>();
            Race_languages_coloumn_name         = new List<string>();
            Race_skill_bonus_coloumn_name       = new List<string>();
            Race_attributes_bonus_coloumn_name  = new List<string>();
            Race_age_statuses_coloumn_name      = new List<string>();
            Race_combat_parameters_coloumn_name = new List<string>();

            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Races.db;Version=3;";

            SQLite_connection = new SQLiteConnection(SQLite_connection_string);

        }
    }
}
