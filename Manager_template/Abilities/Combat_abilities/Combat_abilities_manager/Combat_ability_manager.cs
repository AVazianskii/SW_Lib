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

        private Abilities_sequence_template echany,
                                            mandolor_style,
                                            zeishen,
                                            matukai,
                                            terras_kasi;

        private List<string> Combat_abilities_general_coloumn_name;
        private List<string> Combat_abilities_costs_coloumn_name;
        private List<string> Combat_abilities_combat_bonuses_coloumn_name;
        private List<string> Combat_abilities_skills_bonuses_coloumn_name;

        private List<List<string>> Combat_abilities_general_info;
        private List<List<int>> Combat_abilities_costs;
        private List<List<int>> Combat_abilities_combat_bonuses;
        private List<List<int>> Combat_abilities_skills_bonuses;

        private List<string> Combat_abilities_ID;
        private List<string> Combat_abilities_name;
        private List<string> Combat_general_description;
        private List<string> Combat_description;

        private List<Abilities_sequence_template> _Combat_sequences;



        public static Combat_ability_manager GetInstance()
        {
            if (Combat_ability_manager_instance == null)
            {
                Combat_ability_manager_instance = new Combat_ability_manager();
            }
            return Combat_ability_manager_instance;
        }



        public Abilities_sequence_template Echany
        {
            get { return echany; }
            set { echany = value; }
        }
        public Abilities_sequence_template Mandolor_style
        {
            get { return mandolor_style; }
            set { mandolor_style = value; }
        }
        public Abilities_sequence_template Zeishen
        {
            get { return zeishen; }
            set { zeishen = value; }
        }
        public Abilities_sequence_template Matukai
        {
            get { return matukai; }
            set { matukai = value; }
        }
        public Abilities_sequence_template Terras_kasi
        {
            get { return terras_kasi; }
            set { terras_kasi = value; }
        }



        public List<Combat_abilities_template> Get_abilities() { return _Combat_abilities; }
        public List<Abilities_sequence_template> Get_sequences() { return _Combat_sequences; }



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

            Run_download_from_SQLite_v2("SELECT * FROM Combat_abilities_skill_bonuses ORDER BY ID",
                                        SQLite_connection,
                                        Combat_abilities_skills_bonuses_coloumn_name,
                                        Combat_abilities_skills_bonuses,
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

                foreach (List<int> list in Combat_abilities_skills_bonuses)
                {
                    _Combat_abilities[index].Skill_bonuses.Add(list[_Combat_abilities[index].ID - 1]);
                }

                if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Combat_abilities\\Images\\" + _Combat_abilities[index].Name + ".jpg"))
                {
                    _Combat_abilities[index].Img_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Combat_abilities\Images\{_Combat_abilities[index].Name}.jpg";
                }
                else
                {
                    _Combat_abilities[index].Img_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                }

                if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Combat_abilities\\Icons\\" + _Combat_abilities[index].Name + ".jpg"))
                {
                    _Combat_abilities[index].Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Combat_abilities\Icons\{_Combat_abilities[index].Name}.jpg";
                }
                else
                {
                    _Combat_abilities[index].Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                }

            }
            Echany.Name = "Эхани";
            Echany.Base_ability_lvl     = _Combat_abilities[0];
            Echany.Adept_ability_lvl    = _Combat_abilities[1];
            Echany.Master_ability_lvl   = _Combat_abilities[2];

            Echany.Enable_condition_base    = null;
            Echany.Enable_condition_adept   = Echany.Base_ability_lvl;
            Echany.Enable_condition_master  = Echany.Adept_ability_lvl;

            Echany.Check_enable_state();


            Mandolor_style.Name = "Мандолорский стиль";
            Mandolor_style.Base_ability_lvl     = _Combat_abilities[3];
            Mandolor_style.Adept_ability_lvl    = _Combat_abilities[4];
            Mandolor_style.Master_ability_lvl   = _Combat_abilities[5];

            Mandolor_style.Enable_condition_base    = null;
            Mandolor_style.Enable_condition_adept   = Mandolor_style.Base_ability_lvl;
            Mandolor_style.Enable_condition_master  = Mandolor_style.Adept_ability_lvl;

            Mandolor_style.Check_enable_state();


            Zeishen.Name = "Зейшен Ши";
            Zeishen.Base_ability_lvl    = _Combat_abilities[6];
            Zeishen.Adept_ability_lvl   = _Combat_abilities[7];
            Zeishen.Master_ability_lvl  = _Combat_abilities[8];

            Zeishen.Enable_condition_base   = null;
            Zeishen.Enable_condition_adept  = Zeishen.Base_ability_lvl;
            Zeishen.Enable_condition_master = Zeishen.Adept_ability_lvl;

            Zeishen.Check_enable_state();


            Matukai.Name = "Матукай";
            Matukai.Base_ability_lvl    = _Combat_abilities[9];
            Matukai.Adept_ability_lvl   = _Combat_abilities[10];
            Matukai.Master_ability_lvl  = _Combat_abilities[11];

            Matukai.Enable_condition_base   = null;
            Matukai.Enable_condition_adept  = Matukai.Base_ability_lvl;
            Matukai.Enable_condition_master = Matukai.Adept_ability_lvl;

            Matukai.Check_enable_state();


            Terras_kasi.Name = "Террас Каси";
            Terras_kasi.Base_ability_lvl    = _Combat_abilities[12];
            Terras_kasi.Adept_ability_lvl   = _Combat_abilities[13];
            Terras_kasi.Master_ability_lvl  = _Combat_abilities[14];

            Terras_kasi.Enable_condition_base   = null;
            Terras_kasi.Enable_condition_adept  = Terras_kasi.Base_ability_lvl;
            Terras_kasi.Enable_condition_master = Terras_kasi.Adept_ability_lvl;

            Terras_kasi.Check_enable_state();
        }



        private Combat_ability_manager()
        {
            Combat_abilities_general_coloumn_name           = new List<string>();
            Combat_abilities_costs_coloumn_name             = new List<string>();
            Combat_abilities_combat_bonuses_coloumn_name    = new List<string>();
            Combat_abilities_skills_bonuses_coloumn_name    = new List<string>();

            Combat_abilities_general_info   = new List<List<string>>();
            Combat_abilities_costs          = new List<List<int>>();
            Combat_abilities_combat_bonuses = new List<List<int>>();
            Combat_abilities_skills_bonuses = new List<List<int>>();

            Combat_abilities_ID         = new List<string>();
            Combat_abilities_name       = new List<string>();
            Combat_general_description  = new List<string>();
            Combat_description          = new List<string>();

            Combat_abilities_general_info.Add(Combat_abilities_ID);
            Combat_abilities_general_info.Add(Combat_abilities_name);
            Combat_abilities_general_info.Add(Combat_general_description);
            Combat_abilities_general_info.Add(Combat_description);

            Echany          = new Abilities_sequence_template();
            Mandolor_style  = new Abilities_sequence_template();
            Zeishen         = new Abilities_sequence_template();
            Matukai         = new Abilities_sequence_template();
            Terras_kasi     = new Abilities_sequence_template();

            _Combat_sequences = new List<Abilities_sequence_template>();
            
            _Combat_sequences.Add(Echany);
            _Combat_sequences.Add(Mandolor_style);
            _Combat_sequences.Add(Zeishen);
            _Combat_sequences.Add(Matukai);
            _Combat_sequences.Add(Terras_kasi);
            
            _Combat_abilities = new List<Combat_abilities_template>();

            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Combat_abilities.db;Version=3;";

            SQLite_connection = new SQLiteConnection(SQLite_connection_string);
        }
    }
}
