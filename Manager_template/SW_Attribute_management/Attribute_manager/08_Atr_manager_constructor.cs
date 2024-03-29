﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Attribute_libs;
using System.IO;

namespace SW_Character_creation
{
    public partial class Attribute_manager
    {
        public Attribute_manager()
        {
            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Attributes.db;Version=3;";
            //SQLite_connection = new SQLiteConnection(SQLite_connection_string);

            #region инициализация переменных обхектов атрибутов и коллекции этих атрибутов
            Strength = new Atribute_class(); //Strength_atr
            Agility = new Atribute_class(); //Agility_atr
            Stamina = new Atribute_class(); //Stamina_atr
            Perception = new Atribute_class(); //Perception_atr
            Quickness = new Atribute_class(); //Quickness_atr
            Intelligence = new Atribute_class(); //Intelligence_atr
            Charm = new Atribute_class(); //Charm_atr
            Willpower = new Atribute_class(); //Willpower_atr

            _Attributes = new List<Atribute_class>();
            _Attributes.Add(Strength);
            _Attributes.Add(Agility);
            _Attributes.Add(Stamina);
            _Attributes.Add(Perception);
            _Attributes.Add(Quickness);
            _Attributes.Add(Intelligence);
            _Attributes.Add(Charm);
            _Attributes.Add(Willpower);
            #endregion

            #region инициализация коллекций для считывания общего описания атрибутов
            Attribute_general_coloumn_name = new List<string>();
            Attribute_general_description = new List<string>();
            Attribute_ID = new List<string>();
            Attribute_name = new List<string>();
            Attributes_description = new List<List<string>>();
            Attributes_description.Add(Attribute_ID);
            Attributes_description.Add(Attribute_name);
            Attributes_description.Add(Attribute_general_description);
            #endregion
            #region инициализация коллекций для считывания стоимости прокачки атрибутов
            Attributes_cost_coloumn_name = new List<string>();
            Attribute_costs = new List<List<int>>();
            Attribute_cost_exp = new List<int>();
            Attribute_cost_atr = new List<int>();
            Attribute_costs.Add(Attribute_cost_atr);
            Attribute_costs.Add(Attribute_cost_exp);
            #endregion
            #region инициализация коллекций для считывания лимитов прокачки атрибутов исходя из возраста персонажа
            Attributes_limits_due_age_status_coloumn_name = new List<string>();
            Attribute_age_status_limits = new List<List<int>>();
            Attribute_unknown_age_limit = new List<int>();
            Attribute_child_limit = new List<int>();
            Attribute_teen_limit = new List<int>();
            Attribute_adult_limit = new List<int>();
            Attribute_middle_limit = new List<int>();
            Attribute_old_limit = new List<int>();
            Attribute_eldery_limit = new List<int>();
            Attribute_age_status_limits.Add(Attribute_unknown_age_limit);
            Attribute_age_status_limits.Add(Attribute_child_limit);
            Attribute_age_status_limits.Add(Attribute_teen_limit);
            Attribute_age_status_limits.Add(Attribute_adult_limit);
            Attribute_age_status_limits.Add(Attribute_middle_limit);
            Attribute_age_status_limits.Add(Attribute_old_limit);
            Attribute_age_status_limits.Add(Attribute_eldery_limit);
            #endregion
            #region инициализация коллекций для считывания лимитов прокачки атрибутов исходя из ранга персонажа
            Attributes_limits_due_range_coloumn_name = new List<string>();
            Attribute_range_limits = new List<List<int>>();
            Attribute_private_limit = new List<int>();
            Attribute_veteran_limit = new List<int>();
            Attribute_hero_limit = new List<int>();
            Attribute_epic_limit = new List<int>();
            Attribute_immortal_limit = new List<int>();
            Attribute_range_limits.Add(Attribute_private_limit);
            Attribute_range_limits.Add(Attribute_veteran_limit);
            Attribute_range_limits.Add(Attribute_hero_limit);
            Attribute_range_limits.Add(Attribute_epic_limit);
            Attribute_range_limits.Add(Attribute_immortal_limit);
            #endregion
        }
    }
}
