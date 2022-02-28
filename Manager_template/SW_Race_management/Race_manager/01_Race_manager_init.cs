using System.Collections.Generic;
using System.Data.SQLite;


namespace Races_libs
{
    public partial class Race_manager
    {
        // Сегмент кода, отвечающий за инициализацию различных переменных
        #region Объявление переменной в виде коллекции рас
        public List<Race_class> _Races;
        #endregion
        #region Объявление переменных для каждой из рас
        public Empty_race Empty_Race;
        public Human_race Human;
        public Botan_race Botan;
        public Cereanin_race Cereanin;
        public Duro_race Duro;
        public Evok_race Evok;
        public Gamor_race Gamor;
        public Gungan_race Gungan;
        public Kel_Dor_race Kel_Dor;
        public Mon_Kalamari_race Mon_Kalamari;
        public Rodian_race Rodian;
        public Sullu_race Sullu;
        public Trando_race Trando;
        public Tvi_lek_race Tvi_lek;
        public Wooki_race Wooki;
        public Zabrak_race Zabrak;
        #endregion

        #region переменные для обращения к базе SQLite
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;
        #endregion

        #region инициализация коллекции коллекций общего описания рас
        private List<List<string>> Race_description;
        private List<string> Race_general_info_coloumn_name;
        #endregion
        #region инициализация коллекций общего описания рас
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
        #endregion
        #region инициализация коллекций языков рас
        private List<int> Galactic_lang;
        private List<int> Botan_lang;
        private List<int> Cerenian_lang;
        private List<int> Duro_lang;
        private List<int> Evok_lang;
        private List<int> Gamor_lang;
        private List<int> Gungan_lang;
        private List<int> Rodian_lang;
        private List<int> Hatt_lang;
        private List<int> Ril_lang;
        private List<int> Leku_lang;
        private List<int> Wooki_lang;
        private List<int> Kel_dor_lang;
        private List<int> Mon_kalamari_lang;
        private List<int> Trando_lang;
        private List<int> Sullu_lang;
        private List<int> Zabrak_lang;
        private List<List<int>> Languages; // инициализация коллекции различных языков
        private List<string> Race_languages_coloumn_name; // инициализация коллекции столбцов в таблице по уровням знания языков у рас
        #endregion
        #region инициализация коллекции расовых бонусов атрибутов
        private List<int> Strength_bonus;
        private List<int> Agility_bonus;
        private List<int> Stamina_bonus;
        private List<int> Perception_bonus;
        private List<int> Quickness_bonus;
        private List<int> Intelligence_bonus;
        private List<int> Charm_bonus;
        private List<int> Willpower_bonus;
        #endregion
        #region инициализация коллекции расовых границ для определения возрастного статуса
        private List<int> Child_min_age;
        private List<int> Child_max_age;
        private List<int> Teen_min_age;
        private List<int> Teen_max_age;
        private List<int> Adult_min_age;
        private List<int> Adult_max_age;
        private List<int> Middle_min_age;
        private List<int> Middle_max_age;
        private List<int> Old_min_age;
        private List<int> Old_max_age;
        private List<int> Eldery_min_age;
        #endregion
        #region инициализация коллекции расовых бонусов боевых параметров
        private List<int> Reaction_bonus;
        private List<int> Armor_bonus;
        private List<int> Stealthiness_combat_bonus;
        private List<int> Watchfulness_combat_bonus;
        private List<int> Force_resist_bonus;
        private List<int> Flow_control_bonus;
        #endregion
        #region инициализация коллекции расовых бонусов навыков
        private List<int> Swimming_bonus,
                    Heavy_athletics_bonus,
                    Climbing_bonus,
                    Light_athletics_bonus,
                    Sleight_of_hand_bonus,
                    Stealthiness_bonus,
                    Acrobatics_bonus,
                    Horse_riding_bonus,
                    Light_saber_fighting_bonus,
                    Hand_combat_bonus,
                    Usual_saber_fighting_bonus,
                    Evasion_bonus,
                    Throwing_bonus,
                    Lips_reading_bonus,
                    Old_weapon_bonus,
                    Light_weapon_bonus,
                    Heavy_weapon_bonus,
            Sniper_weapon_bonus,
            Musicality_bonus,
            Riding_bonus,
            Resisting_bonus,
            Strength_of_mind_bonus,
            Watchfulness_bonus,
            Pilot_bonus,
            Programming_bonus,
            Surviving_bonus,
            Reapair_bonus,
            Training_bonus,
            Medicine_crafting_bonus,
            Science_bonus,
            Engineering_bonus,
            Star_wars_tactic_bonus,
            Crafting_bonus,
            Trading_bonus,
            Astronavigation_bonus,
            Change_looking_bonus,
            Light_saber_crafting_bonus,
            Exploding_bonus,
            Security_bonus,
            Medicine_bonus,
            Language_bonus,
            Knowledge_bonus,
            Dancing_bonus,
            Interrogation_bonus,
            Diplomacy_bonus,
            Leadership_bonus,
            Singing_bonus,
            Deception_bonus,
            Insight_bonus,
            Seduction_bonus;
        #endregion
        List<string> Race_skill_bonus_coloumn_name;
        List<List<int>> Race_skills_bonus;
        List<string> Race_attributes_bonus_coloumn_name;
        List<List<int>> Race_attributes_bonus;
        List<string> Race_age_statuses_coloumn_name;
        List<List<int>> Race_age_statuses;
        List<string> Race_combat_parameters_coloumn_name;
        List<List<int>> Race_combat_parameters;


        public enum enum_Races // перечисляем порядок рас по порядку, начиная с 0
        {
            _Empty_race,     // 0
            _Human,          // 1
            _Botan,          // 2
            _Cereanin,       // 3
            _Duro,           // 4
            _Evok,           // 5
            _Gamor,          // 6
            _Gungan,         // 7
            _Kel_dor,        // 8 
            _Mon_kalamari,   // 9 
            _Rodian,         // 10
            _Sullu,          // 11
            _Trando,         // 12
            _Tvilek,         // 13
            _Wooki,          // 14
            _Zabrak          // 15
        }
        enum Type_of_var
        {
            string_type,
            int_type
        }
    }
}
