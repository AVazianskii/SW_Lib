using System.Data.SQLite;
using System.Collections.Generic;

namespace Races_libs
{
    public partial class Race_manager
    {
        public Race_manager()
        {
            #region инициализация рас
            Empty_Race = new Empty_race();
            Human = new Human_race();
            Botan = new Botan_race();
            Cereanin = new Cereanin_race();
            Duro = new Duro_race();
            Evok = new Evok_race();
            Gamor = new Gamor_race();
            Gungan = new Gungan_race();
            Kel_Dor = new Kel_Dor_race();
            Mon_Kalamari = new Mon_Kalamari_race();
            Rodian = new Rodian_race();
            Sullu = new Sullu_race();
            Trando = new Trando_race();
            Tvi_lek = new Tvi_lek_race();
            Wooki = new Wooki_race();
            Zabrak = new Zabrak_race();
            #endregion
            #region инициализация коллекции рас
            _Races = new List<Race_class>();
            _Races.Add(Empty_Race); 
            _Races.Add(Human); 
            _Races.Add(Botan); 
            _Races.Add(Cereanin);
            _Races.Add(Duro); 
            _Races.Add(Evok);
            _Races.Add(Gamor);
            _Races.Add(Gungan);
            _Races.Add(Kel_Dor);
            _Races.Add(Mon_Kalamari);
            _Races.Add(Rodian);
            _Races.Add(Sullu);
            _Races.Add(Trando);
            _Races.Add(Tvi_lek);
            _Races.Add(Wooki);
            _Races.Add(Zabrak);
            #endregion
            #region инициализация полей основного описания рас
            General_description = new List<string>();
            Personal_properties = new List<string>();
            Physical_properties = new List<string>();
            Home_world = new List<string>();
            Language_1 = new List<string>();
            Language_2 = new List<string>();
            Language_3 = new List<string>();
            Language_4 = new List<string>();
            Feature_1 = new List<string>();
            Feature_2 = new List<string>();
            Feature_3 = new List<string>();
            Feature_4 = new List<string>();
            Feature_5 = new List<string>();
            Feature_6 = new List<string>();
            Feature_7 = new List<string>();
            #endregion
            #region инициализация коллекции описаний рас
            Race_description = new List<List<string>>();
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
            #endregion
            #region инициализация уровней знания языков рас
            Galactic_lang = new List<int>();
            Botan_lang = new List<int>();
            Cerenian_lang = new List<int>();
            Duro_lang = new List<int>();
            Evok_lang = new List<int>();
            Gamor_lang = new List<int>();
            Gungan_lang = new List<int>();
            Rodian_lang = new List<int>();
            Hatt_lang = new List<int>();
            Ril_lang = new List<int>();
            Leku_lang = new List<int>();
            Wooki_lang = new List<int>();
            Kel_dor_lang = new List<int>();
            Mon_kalamari_lang = new List<int>();
            Trando_lang = new List<int>();
            Sullu_lang = new List<int>();
            Zabrak_lang = new List<int>();
            #endregion
            #region инициализация коллекции языков рас
            Languages = new List<List<int>>();
            Languages.Add(Galactic_lang);
            Languages.Add(Botan_lang);
            Languages.Add(Cerenian_lang);
            Languages.Add(Duro_lang);
            Languages.Add(Evok_lang);
            Languages.Add(Gamor_lang);
            Languages.Add(Gungan_lang);
            Languages.Add(Rodian_lang);
            Languages.Add(Hatt_lang);
            Languages.Add(Ril_lang);
            Languages.Add(Leku_lang);
            Languages.Add(Wooki_lang);
            Languages.Add(Kel_dor_lang);
            Languages.Add(Mon_kalamari_lang);
            Languages.Add(Trando_lang);
            Languages.Add(Sullu_lang);
            Languages.Add(Zabrak_lang);
            #endregion
            #region инициализация коллекции расовых бонусов атрибутов
            Strength_bonus = new List<int>();
            Agility_bonus = new List<int>();
            Stamina_bonus = new List<int>();
            Perception_bonus = new List<int>();
            Quickness_bonus = new List<int>();
            Intelligence_bonus = new List<int>();
            Charm_bonus = new List<int>();
            Willpower_bonus = new List<int>();
            #endregion
            #region инициализация коллекции коллекций расовых бонусов атрибутов
            Race_attributes_bonus = new List<List<int>>();
            Race_attributes_bonus.Add(Strength_bonus);
            Race_attributes_bonus.Add(Agility_bonus);
            Race_attributes_bonus.Add(Stamina_bonus);
            Race_attributes_bonus.Add(Perception_bonus);
            Race_attributes_bonus.Add(Quickness_bonus);
            Race_attributes_bonus.Add(Intelligence_bonus);
            Race_attributes_bonus.Add(Charm_bonus);
            Race_attributes_bonus.Add(Willpower_bonus);
            #endregion
            #region инициализация коллекции расовых границ для определения возрастного статуса персонажа
            Child_min_age = new List<int>();
            Child_max_age = new List<int>();
            Teen_min_age = new List<int>();
            Teen_max_age = new List<int>();
            Adult_min_age = new List<int>();
            Adult_max_age = new List<int>();
            Middle_min_age = new List<int>();
            Middle_max_age = new List<int>();
            Old_min_age = new List<int>();
            Old_max_age = new List<int>();
            Eldery_min_age = new List<int>();
            #endregion
            #region инициализация коллекции коллекций расовых границ для определения возрастного статуса персонажа
            Race_age_statuses = new List<List<int>>();
            Race_age_statuses.Add(Child_min_age);
            Race_age_statuses.Add(Child_max_age);
            Race_age_statuses.Add(Teen_min_age);
            Race_age_statuses.Add(Teen_max_age);
            Race_age_statuses.Add(Adult_min_age);
            Race_age_statuses.Add(Adult_max_age);
            Race_age_statuses.Add(Middle_min_age);
            Race_age_statuses.Add(Middle_max_age);
            Race_age_statuses.Add(Old_min_age);
            Race_age_statuses.Add(Old_max_age);
            Race_age_statuses.Add(Eldery_min_age);
            #endregion
            #region инициализация коллекции расовых расовых боевых параметров
            Reaction_bonus = new List<int>();
            Armor_bonus = new List<int>();
            Stealthiness_combat_bonus = new List<int>();
            Watchfulness_combat_bonus = new List<int>();
            Force_resist_bonus = new List<int>();
            Flow_control_bonus = new List<int>();
            #endregion
            #region инициализация коллекции коллекций расовых боевых параметров
            Race_combat_parameters = new List<List<int>>();
            Race_combat_parameters.Add(Reaction_bonus);
            Race_combat_parameters.Add(Armor_bonus);
            Race_combat_parameters.Add(Stealthiness_combat_bonus);
            Race_combat_parameters.Add(Watchfulness_combat_bonus);
            Race_combat_parameters.Add(Force_resist_bonus);
            Race_combat_parameters.Add(Flow_control_bonus);
            #endregion
            #region инициализация коллекции расовых бонусов навыков
            Swimming_bonus = new List<int>();
            Heavy_athletics_bonus = new List<int>();
            Climbing_bonus = new List<int>();
            Light_athletics_bonus = new List<int>();
            Sleight_of_hand_bonus = new List<int>();
            Stealthiness_bonus = new List<int>();
            Acrobatics_bonus = new List<int>();
            Horse_riding_bonus = new List<int>();
            Light_saber_fighting_bonus = new List<int>();
            Hand_combat_bonus = new List<int>();
            Usual_saber_fighting_bonus = new List<int>();
            Evasion_bonus = new List<int>();
            Throwing_bonus = new List<int>();
            Lips_reading_bonus = new List<int>();
            Old_weapon_bonus = new List<int>();
            Light_weapon_bonus = new List<int>();
            Heavy_weapon_bonus = new List<int>();
            Sniper_weapon_bonus = new List<int>();
            Musicality_bonus = new List<int>();
            Riding_bonus = new List<int>();
            Resisting_bonus = new List<int>();
            Strength_of_mind_bonus = new List<int>();
            Watchfulness_bonus = new List<int>();
            Pilot_bonus = new List<int>();
            Programming_bonus = new List<int>();
            Surviving_bonus = new List<int>();
            Reapair_bonus = new List<int>();
            Training_bonus = new List<int>();
            Medicine_crafting_bonus = new List<int>();
            Science_bonus = new List<int>();
            Engineering_bonus = new List<int>();
            Star_wars_tactic_bonus = new List<int>();
            Crafting_bonus = new List<int>();
            Trading_bonus = new List<int>();
            Astronavigation_bonus = new List<int>();
            Change_looking_bonus = new List<int>();
            Light_saber_crafting_bonus = new List<int>();
            Exploding_bonus = new List<int>();
            Security_bonus = new List<int>();
            Medicine_bonus = new List<int>();
            Language_bonus = new List<int>();
            Knowledge_bonus = new List<int>();
            Dancing_bonus = new List<int>();
            Interrogation_bonus = new List<int>();
            Diplomacy_bonus = new List<int>();
            Leadership_bonus = new List<int>();
            Singing_bonus = new List<int>();
            Deception_bonus = new List<int>();
            Insight_bonus = new List<int>();
            Seduction_bonus = new List<int>();
            #endregion
            #region инициализация коллекции коллекций расовых боевых параметров
            Race_skills_bonus = new List<List<int>>();
            Race_skills_bonus.Add(Swimming_bonus);
            Race_skills_bonus.Add(Heavy_athletics_bonus);
            Race_skills_bonus.Add(Climbing_bonus);
            Race_skills_bonus.Add(Light_athletics_bonus);
            Race_skills_bonus.Add(Sleight_of_hand_bonus);
            Race_skills_bonus.Add(Stealthiness_bonus);
            Race_skills_bonus.Add(Acrobatics_bonus);
            Race_skills_bonus.Add(Horse_riding_bonus);
            Race_skills_bonus.Add(Light_saber_fighting_bonus);
            Race_skills_bonus.Add(Hand_combat_bonus);
            Race_skills_bonus.Add(Usual_saber_fighting_bonus);
            Race_skills_bonus.Add(Evasion_bonus);
            Race_skills_bonus.Add(Throwing_bonus);
            Race_skills_bonus.Add(Lips_reading_bonus);
            Race_skills_bonus.Add(Old_weapon_bonus);
            Race_skills_bonus.Add(Light_weapon_bonus);
            Race_skills_bonus.Add(Heavy_weapon_bonus);
            Race_skills_bonus.Add(Sniper_weapon_bonus);
            Race_skills_bonus.Add(Musicality_bonus);
            Race_skills_bonus.Add(Riding_bonus);
            Race_skills_bonus.Add(Resisting_bonus);
            Race_skills_bonus.Add(Strength_of_mind_bonus);
            Race_skills_bonus.Add(Watchfulness_bonus);
            Race_skills_bonus.Add(Pilot_bonus);
            Race_skills_bonus.Add(Programming_bonus);
            Race_skills_bonus.Add(Surviving_bonus);
            Race_skills_bonus.Add(Reapair_bonus);
            Race_skills_bonus.Add(Training_bonus);
            Race_skills_bonus.Add(Medicine_crafting_bonus);
            Race_skills_bonus.Add(Science_bonus);
            Race_skills_bonus.Add(Engineering_bonus);
            Race_skills_bonus.Add(Star_wars_tactic_bonus);
            Race_skills_bonus.Add(Crafting_bonus);
            Race_skills_bonus.Add(Trading_bonus);
            Race_skills_bonus.Add(Astronavigation_bonus);
            Race_skills_bonus.Add(Change_looking_bonus);
            Race_skills_bonus.Add(Light_saber_crafting_bonus);
            Race_skills_bonus.Add(Exploding_bonus);
            Race_skills_bonus.Add(Security_bonus);
            Race_skills_bonus.Add(Medicine_bonus);
            Race_skills_bonus.Add(Language_bonus);
            Race_skills_bonus.Add(Knowledge_bonus);
            Race_skills_bonus.Add(Dancing_bonus);
            Race_skills_bonus.Add(Interrogation_bonus);
            Race_skills_bonus.Add(Diplomacy_bonus);
            Race_skills_bonus.Add(Leadership_bonus);
            Race_skills_bonus.Add(Singing_bonus);
            Race_skills_bonus.Add(Deception_bonus);
            Race_skills_bonus.Add(Insight_bonus);
            Race_skills_bonus.Add(Seduction_bonus);
            #endregion
            SQLite_connection_string = @"Data Source=D:\STAR WARS Saga\Character_creation\Races_Libs\SW_Race_manager\Races.db;Version=3;";
            SQLite_connection = new SQLiteConnection(SQLite_connection_string);
            
            Race_general_info_coloumn_name = new List<string>();
            Race_languages_coloumn_name = new List<string>();
            Race_skill_bonus_coloumn_name = new List<string>();
            Race_attributes_bonus_coloumn_name = new List<string>();
            Race_age_statuses_coloumn_name = new List<string>();
            Race_combat_parameters_coloumn_name = new List<string>();


        }
    }
}
