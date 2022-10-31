using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SW_Character_creation
{
    public class Feature_manager : Abstract_manager
    {
        private static Feature_manager feature_instance;

        private List<All_feature_template> _Features;

        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;

        private List<string> Feature_ID;
        private List<string> Feature_name;
        private List<string> Feature_description;
        private List<string> Feature_general_info_coloumn_name;

        private List<List<string>> Feature_general_info;



        public List<All_feature_template> Get_features() { return _Features; }
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
            }

            ClearList(Feature_general_info_coloumn_name);

            ClearDoubleLists(Feature_general_info);
        }



        private Feature_manager()
        {
            _Features = new List<All_feature_template>();

            Feature_ID          = new List<string>();
            Feature_name        = new List<string>();
            Feature_description = new List<string>();

            Feature_general_info = new List<List<string>>();
            Feature_general_info.Add(Feature_ID);
            Feature_general_info.Add(Feature_name);
            Feature_general_info.Add(Feature_description);

            Feature_general_info_coloumn_name = new List<string>();

            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Features.db;Version=3;";

            SQLite_connection = new SQLiteConnection(SQLite_connection_string);
        }
    }
}
