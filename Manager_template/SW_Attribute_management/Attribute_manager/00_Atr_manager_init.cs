using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Attribute_libs;

namespace SW_Character_creation
{
    public partial class Attribute_manager : Abstract_manager
    {
        //private static Attribute_manager Attribute_manager_instance;

        public Atribute_class Strength; //private Strength_atr
        public Atribute_class Agility; //private Agility_atr
        public Atribute_class Stamina; //private Stamina_atr
        public Atribute_class Perception;//private Perception_atr
        public Atribute_class Quickness;//private Quickness_atr
        public Atribute_class Intelligence;//private Intelligence_atr
        public Atribute_class Charm;//private Charm_atr
        public Atribute_class Willpower;//private Willpower_atr

        private List<Atribute_class> _Attributes;

        #region переменные для обращения к базе SQLite
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;
        #endregion

        private List<string> Attribute_general_coloumn_name;
        private List<string> Attributes_cost_coloumn_name;
        private List<string> Attributes_limits_due_range_coloumn_name;
        private List<string> Attributes_limits_due_age_status_coloumn_name;

        private List<List<string>> Attributes_description;

        private List<List<int>> Attribute_costs;
        private List<List<int>> Attribute_age_status_limits;
        private List<List<int>> Attribute_range_limits;

        private List<int> Attribute_cost_exp;
        private List<int> Attribute_cost_atr;
        private List<int> Attribute_private_limit;
        private List<int> Attribute_veteran_limit;
        private List<int> Attribute_hero_limit;
        private List<int> Attribute_epic_limit;
        private List<int> Attribute_immortal_limit;
        private List<int> Attribute_unknown_age_limit;
        private List<int> Attribute_child_limit;
        private List<int> Attribute_teen_limit;
        private List<int> Attribute_adult_limit;
        private List<int> Attribute_middle_limit;
        private List<int> Attribute_old_limit;
        private List<int> Attribute_eldery_limit;

        private List<string> Attribute_general_description;
        private List<string> Attribute_ID;
        private List<string> Attribute_name;

        public enum enum_Atributes // перечисляем порядок атрибутов в последовательности, начиная с 0
        {
            Strength,   
            Agility,    
            Stamina,    
            Perception,
            Quicness,   
            Intelligence,
            Charm,      
            Willpower   
        }
    }
}
