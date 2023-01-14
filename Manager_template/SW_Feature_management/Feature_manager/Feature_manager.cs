﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SW_Character_creation
{
    public class Feature_manager : Abstract_manager
    {
        private static Feature_manager feature_instance;

        private List<All_feature_template> _Features;
        private List<All_feature_template> _Positive_feature;
        private List<All_feature_template> _Negative_feature;
        
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;

        private List<string>    Feature_ID,
                                Feature_name,
                                Feature_description,
                                Feature_general_info_coloumn_name,
                                Feature_type_coloumn_name,
                                Feature_cost_coloumn_name,
                                Feature_common_bonuses_coloumn_name,
                                Feature_skill_bonuses_coloumn_name;

        private List<List<byte>> Feature_type,
                                 Feature_skill_bonuses;

        private List<List<sbyte>>   Feature_cost,
                                    Feature_common_bonuses;

        private List<List<string>> Feature_general_info;



        public List<All_feature_template> Get_features() { return _Features; }
        public List<All_feature_template> Get_positive_features() { return _Positive_feature; }
        public List<All_feature_template> Get_negative_features() { return _Negative_feature; }
        public static Feature_manager GetInstance()
        {
            if (feature_instance == null)
            {
                feature_instance = new Feature_manager();
            }
            return feature_instance;
        }
        public override void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            Run_download_general_from_SQLite("SELECT * FROM Features_general_info ORDER BY ID",
                                             SQLite_connection,
                                             Feature_general_info_coloumn_name,
                                             Feature_general_info);

            Run_download_from_SQLite_v2("SELECT * FROM Features_costs ORDER BY ID",
                                        SQLite_connection,
                                        Feature_cost_coloumn_name,
                                        Feature_cost,
                                        (int)Type_of_var.sbyte_type);

            Run_download_from_SQLite_v2("SELECT * FROM Features_type ORDER BY ID",
                                        SQLite_connection,
                                        Feature_type_coloumn_name,
                                        Feature_type,
                                        (int)Type_of_var.byte_type);

            Run_download_from_SQLite_v2("SELECT * FROM Features_skill_bonuses ORDER BY ID",
                                        SQLite_connection,
                                        Feature_skill_bonuses_coloumn_name,
                                        Feature_skill_bonuses,
                                        (int)Type_of_var.byte_type);

            Run_download_from_SQLite_v2("SELECT * FROM Features_common_bonuses ORDER BY ID",
                                        SQLite_connection,
                                        Feature_common_bonuses_coloumn_name,
                                        Feature_common_bonuses,
                                        (int)Type_of_var.sbyte_type);

            SQLite_connection.Close();

            int index = 0;

            foreach (var count in Feature_general_info[0])
            {
                // На каждую новую строку создаем новый инстанс
                _Features.Add(new All_feature_template());

                // Определяем порядковый нмоер текущего инстанса
                index = Feature_general_info[0].IndexOf(count);

                _Features[index].ID             = Convert.ToByte(Feature_general_info[0][index]);
                _Features[index].Name           =                Feature_general_info[1][index];
                _Features[index].Description    =                Feature_general_info[2][index];

                _Features[index].Type = Feature_type[0][index];

                if ((_Features[index].Type % 20) < 10)
                {
                    _Positive_feature.Add(_Features[index]);
                }
                else 
                {
                    _Negative_feature.Add(_Features[index]);
                }

                if(_Features[index].Type > 40)
                {
                    _Features[index].Is_force_usered_only = true;
                }
                else if((_Features[index].Type > 20) && (_Features[index].Type < 41))
                {
                    _Features[index].Is_usual_usered_only = true;
                }

                if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Features\\Images\\" + _Features[index].Name + ".jpg"))
                {
                    _Features[index].Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Features\Images\{_Features[index].Name}.jpg";
                }
                else
                {
                    _Features[index].Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                }

                if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Features\\Icons\\" + _Features[index].Name + ".jpg"))
                {
                    _Features[index].Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Features\Icons\{_Features[index].Name}";
                }
                else
                {
                    _Features[index].Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                }

                _Features[index].Strength_bonus     = Feature_common_bonuses[0][index];
                _Features[index].Stamina_bonus      = Feature_common_bonuses[1][index];
                _Features[index].Agility_bonus      = Feature_common_bonuses[2][index];
                _Features[index].Quickness_bonus    = Feature_common_bonuses[3][index];
                _Features[index].Intelligence_bonus = Feature_common_bonuses[4][index];
                _Features[index].Perception_bonus   = Feature_common_bonuses[5][index];
                _Features[index].Charm_bonus        = Feature_common_bonuses[6][index];
                _Features[index].Willpower_bonus    = Feature_common_bonuses[7][index];
                _Features[index].Karma_bonus        = Feature_common_bonuses[8][index];
                _Features[index].Exp_bonus          = Feature_common_bonuses[9][index];

                foreach (List<byte> list in Feature_skill_bonuses)
                {
                    _Features[index].Skill_bonus.Add(list[_Features[index].ID - 1]);
                }

                for (byte k = 0; k < 10; k++)
                {
                    if(Feature_cost[k][index] != 0)
                    {
                        _Features[index].Cost.Add(Feature_cost[k][index]);
                    }
                }
            }

            ClearList(Feature_general_info_coloumn_name);
            ClearList(Feature_type_coloumn_name);
            ClearList(Feature_cost_coloumn_name);
            ClearList(Feature_common_bonuses_coloumn_name);

            ClearDoubleLists(Feature_general_info);
            ClearDoubleLists(Feature_type);
            ClearDoubleLists(Feature_cost);
            ClearDoubleLists(Feature_common_bonuses);
        }



        private Feature_manager()
        {
            _Features           = new List<All_feature_template>();
            _Positive_feature   = new List<All_feature_template>();
            _Negative_feature   = new List<All_feature_template>();
            
            Feature_ID          = new List<string>();
            Feature_name        = new List<string>();
            Feature_description = new List<string>();

            Feature_general_info = new List<List<string>>();

            Feature_general_info.Add(Feature_ID);
            Feature_general_info.Add(Feature_name);
            Feature_general_info.Add(Feature_description);

            Feature_general_info_coloumn_name   = new List<string>();
            Feature_type_coloumn_name           = new List<string>();
            Feature_cost_coloumn_name           = new List<string>();
            Feature_common_bonuses_coloumn_name = new List<string>();
            Feature_skill_bonuses_coloumn_name  = new List<string>();

            Feature_type            = new List<List<byte>>();
            Feature_skill_bonuses   = new List<List<byte>>();
            Feature_cost            = new List<List<sbyte>>();
            Feature_common_bonuses  = new List<List<sbyte>>();

            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Features.db;Version=3;";

            SQLite_connection = new SQLiteConnection(SQLite_connection_string);
        }
    }
}
