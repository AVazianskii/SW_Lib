using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;

namespace SW_Character_creation
{
    public class Force_ability_manager : Abstract_manager
    {
        private static Force_ability_manager Force_ability_manager_instance;

        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;

        private List<Force_abilities_template> _Force_abilities;

        private List<string> Force_abilities_general_coloumn_name;
        private List<string> Force_abilities_costs_coloumn_name;
        private List<string> Force_abilities_combat_bonuses_coloumn_name;

        private List<List<string>> Force_abilities_general_info;
        private List<List<int>> Force_abilities_costs;
        private List<List<int>> Force_abilities_combat_bonuses;

        private List<string> Force_abilities_ID;
        private List<string> Force_abilities_name;
        private List<string> Force_general_description;
        private List<string> Force_description;



        public static Force_ability_manager GetInstance()
        {
            if (Force_ability_manager_instance == null)
            {
                Force_ability_manager_instance = new Force_ability_manager();
            }
            return Force_ability_manager_instance;
        }



        public override void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            Run_download_general_from_SQLite("SELECT * FROM Force_abilities_general ORDER BY ID",
                                             SQLite_connection,
                                             Force_abilities_general_coloumn_name,
                                             Force_abilities_general_info);

            Run_download_from_SQLite_v2("SELECT * FROM Force_abilities_costs ORDER BY ID",
                                        SQLite_connection,
                                        Force_abilities_costs_coloumn_name,
                                        Force_abilities_costs,
                                        (int)Type_of_var.int_type);

            Run_download_from_SQLite_v2("SELECT * FROM Force_abilities_combat_bonuses ORDER BY ID",
                                        SQLite_connection,
                                        Force_abilities_combat_bonuses_coloumn_name,
                                        Force_abilities_combat_bonuses,
                                        (int)Type_of_var.int_type);

            SQLite_connection.Close();

            int index = 0;

            foreach (var count in Force_abilities_general_info[0])
            {
                // На каждую новую строку создаем новый инстанс
                _Force_abilities.Add(new Force_abilities_template());

                // Определяем порядковый нмоер текущего инстанса
                index = Force_abilities_general_info[0].IndexOf(count);

                _Force_abilities[index].ID                  = Convert.ToInt32(  Force_abilities_general_info[0][index]);
                _Force_abilities[index].Name                =                   Force_abilities_general_info[1][index];
                _Force_abilities[index].General_description =                   Force_abilities_general_info[2][index];
                _Force_abilities[index].Description         =                   Force_abilities_general_info[3][index];

                _Force_abilities[index].Cost = Force_abilities_costs[0][index];

                _Force_abilities[index].Reaction_bonus          = Force_abilities_combat_bonuses[0][index];
                _Force_abilities[index].Armor_bonus             = Force_abilities_combat_bonuses[1][index];
                _Force_abilities[index].Force_resistance_bonus  = Force_abilities_combat_bonuses[2][index];
                _Force_abilities[index].Stealthness_bonus       = Force_abilities_combat_bonuses[3][index];
                _Force_abilities[index].Watchfullness_bonus     = Force_abilities_combat_bonuses[4][index];
                _Force_abilities[index].Concentration_bonus     = Force_abilities_combat_bonuses[5][index];
            }
        }



        private Force_ability_manager()
        {
            Force_abilities_general_coloumn_name        = new List<string>();
            Force_abilities_costs_coloumn_name          = new List<string>();
            Force_abilities_combat_bonuses_coloumn_name = new List<string>();

            Force_abilities_general_info    = new List<List<string>>();
            Force_abilities_costs           = new List<List<int>>();
            Force_abilities_combat_bonuses  = new List<List<int>>();


            Force_abilities_ID = new List<string>();
            Force_abilities_name = new List<string>();
            Force_general_description = new List<string>();
            Force_description = new List<string>();

            Force_abilities_general_info.Add(Force_abilities_ID);
            Force_abilities_general_info.Add(Force_abilities_name);
            Force_abilities_general_info.Add(Force_general_description);
            Force_abilities_general_info.Add(Force_description);

            _Force_abilities = new List<Force_abilities_template>();

            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Force_abilities.db;Version=3;";

            SQLite_connection = new SQLiteConnection(SQLite_connection_string);
        }
    }
}
