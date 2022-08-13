using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;

namespace SW_Character_creation
{
    public class Combat_ability_manager : Abstract_manager
    {
        private static Combat_ability_manager Combat_ability_manager_instance;

        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;

        private List<Combat_abilities_template> _Combat_abilities;

        private List<string> Combat_abilities_general_coloumn_name;
        private List<string> Combat_abilities_costs_coloumn_name;
        private List<string> Combat_abilities_combat_bonuses_coloumn_name;

        private List<List<string>> Combat_abilities_general_info;
        private List<List<int>> Combat_abilities_costs;
        private List<List<int>> Combat_abilities_combat_bonuses;



        public static Combat_ability_manager GetInstance()
        {
            if (Combat_ability_manager_instance == null)
            {
                Combat_ability_manager_instance = new Combat_ability_manager();
            }
            return Combat_ability_manager_instance;
        }



        public override void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            Run_download_general_from_SQLite("SELECT * FROM Combat_abilities_general ORDER BY ID",
                                             SQLite_connection,
                                             Combat_abilities_general_coloumn_name,
                                             Combat_abilities_general_info);

            Run_download_from_SQLite_v2("SELECT * FROM Combat_abilities_costs ORDER BY ID",
                                        SQLite_connection,
                                        Combat_abilities_costs_coloumn_name,
                                        Combat_abilities_costs,
                                        (int)Type_of_var.int_type);

            Run_download_from_SQLite_v2("SELECT * FROM Combat_abilities_combat_bonuses ORDER BY ID",
                                        SQLite_connection,
                                        Combat_abilities_combat_bonuses_coloumn_name,
                                        Combat_abilities_combat_bonuses,
                                        (int)Type_of_var.int_type);

            SQLite_connection.Close();

            int index = 0;

            foreach (var count in Combat_abilities_general_info[0])
            {
                // На каждую новую строку создаем новый инстанс
                _Combat_abilities.Add(new Combat_abilities_template());

                // Определяем порядковый нмоер текущего инстанса
                index = Combat_abilities_general_info[0].IndexOf(count);

                _Combat_abilities[index].ID                  = Convert.ToInt32( Combat_abilities_general_info[0][index]);
                _Combat_abilities[index].Name                =                  Combat_abilities_general_info[1][index];
                _Combat_abilities[index].General_description =                  Combat_abilities_general_info[2][index];
                _Combat_abilities[index].Description         =                  Combat_abilities_general_info[3][index];

                _Combat_abilities[index].Cost = Combat_abilities_costs[0][index];

                _Combat_abilities[index].Reaction_bonus         = Combat_abilities_combat_bonuses[0][index];
                _Combat_abilities[index].Armor_bonus            = Combat_abilities_combat_bonuses[1][index];
                _Combat_abilities[index].Force_resistance_bonus = Combat_abilities_combat_bonuses[2][index];
                _Combat_abilities[index].Stealthness_bonus      = Combat_abilities_combat_bonuses[3][index];
                _Combat_abilities[index].Watchfullness_bonus    = Combat_abilities_combat_bonuses[4][index];
                _Combat_abilities[index].Concentration_bonus    = Combat_abilities_combat_bonuses[5][index];
            }
        }



        private Combat_ability_manager()
        {
            Combat_abilities_general_coloumn_name           = new List<string>();
            Combat_abilities_costs_coloumn_name             = new List<string>();
            Combat_abilities_combat_bonuses_coloumn_name    = new List<string>();

            Combat_abilities_general_info   = new List<List<string>>();
            Combat_abilities_costs          = new List<List<int>>();
            Combat_abilities_combat_bonuses = new List<List<int>>();

            _Combat_abilities = new List<Combat_abilities_template>();

            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Combat_abilities.db;Version=3;";

            SQLite_connection = new SQLiteConnection(SQLite_connection_string);
        }
    }
}
