using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public class Race_class
    {

        #region // переменные класса
        private int Error_code;     /* код ошибки в дейстиях персонажа                  */
        private int min_child_age,  /* минимальный  детский      возраст выбранной расы */
                    max_child_age,  /* максимальный детский      возраст выбранной расы */
                    min_teen_age,   /* минимальный  подростковый возраст выбранной расы */
                    max_teen_age,   /* максимальный подростковый возраст выбранной расы */
                    min_adult_age,  /* минимальный  взрослый     возраст выбранной расы */
                    max_adult_age,  /* максимальный взрослый     возраст выбранной расы */
                    min_middle_age, /* минимальный  средний      возраст выбранной расы */
                    max_middle_age, /* максимальный средний      возраст выбранной расы */
                    min_old_age,    /* минимальный  пожилой      возраст выбранной расы */
                    max_old_age,    /* максимальный пожилой      возраст выбранной расы */
                    min_eldery_age; /* минимальный  почтенный    возраст выбранной расы */

        private string Error_msg;               // сообщение об ошибке в действиях игрока
        private string description;             // описание расы персонажа
        private string description_2;           // дополнительное описание расы персонажа
        private string img_path;                // путь к изображению расы
        private string race_name;               // название расы персонажа
        private string path_read_description;   // Путь к файлу для вычитывания текстового описания расы
        private string path_read_description_2; // Путь к файлу для вычитывания текстового описания расы


        private int race_code;              // задаем код расы, по которому можно будет определить выбранную расу
        private int race_bonus_strength,    // задаем расовый бонус атрибута Сила
                    race_bonus_agility,     // задаем расовый бонус атрибута Ловкость
                    race_bonus_stamina,     // задаем расовый бонус атрибута Выносливость
                    race_bonus_quickness,   // задаем расовый бонус атрибута Проворство
                    race_bonus_perception,  // задаем расовый бонус атрибута Восприятие
                    race_bonus_intelligence,// задаем расовый бонус атрибута Интеллект
                    race_bonus_charm,       // задаем расовый бонус атрибута Обаяние
                    race_bonus_willpower;   // задаем расовый бонус атрибута Сила воли

        private string general_description, // Общее описание расы, взятое из базы
                       personal_properties, // Персональные свойства расы
                       physical_properties, // Физические свойства расы
                       home_world,          // Родной мир расы
                       language_1,          // 1 язык расы
                       language_2,          // 2 язык расы
                       language_3,          // 3 язык расы
                       language_4,          // 4 язык расы
                       feature_1,           // 1 особенность расы
                       feature_2,           // 2 особенность расы
                       feature_3,           // 3 особенность расы
                       feature_4,           // 4 особенность расы
                       feature_5,           // 5 особенность расы
                       feature_6;           // 6 особенность расы

        private int language_1_lvl,         // навык владения 1 языком расы
                    language_2_lvl,         // навык владения 2 языком расы
                    language_3_lvl,         // навык владения 3 языком расы
                    language_4_lvl;         // навык владения 4 языком расы

        private int reaction_bonus,
                    armor_bonus,
                    force_resist_bonus,
                    stealthiness_combat_bonus,
                    watchfulness_combat_bonus,
                    flow_control_bonus;

        private int swimming_bonus,
                    heavy_athletics_bonus,
                    climbing_bonus,
                    light_athletics_bonus,
                    sleight_of_hand_bonus,
                    stealthiness_bonus,
                    acrobatics_bonus,
                    horse_riding_bonus,
                    light_saber_fighting_bonus,
                    hand_combat_bonus,
                    usual_saber_fighting_bonus,
                    evasion_bonus,
                    throwing_bonus,
                    lips_reading_bonus,
                    old_weapon_bonus,
                    light_weapon_bonus,
                    heavy_weapon_bonus,
            sniper_weapon_bonus,
            musicality_bonus,
            riding_bonus,
            resisting_bonus,
            strength_of_mind_bonus,
            watchfulness_bonus,
            pilot_bonus,
            programming_bonus,
            surviving_bonus,
            reapair_bonus,
            training_bonus,
            medicine_crafting_bonus,
            science_bonus,
            engineering_bonus,
            star_wars_tactic_bonus,
            crafting_bonus,
            trading_bonus,
            astronavigation_bonus,
            change_looking_bonus,
            light_saber_crafting_bonus,
            exploding_bonus,
            security_bonus,
            medicine_bonus,
            language_bonus,
            knowledge_bonus,
            dancing_bonus,
            interrogation_bonus,
            diplomacy_bonus,
            leadership_bonus,
            singing_bonus,
            deception_bonus,
            insight_bonus,
            seduction_bonus;



        // SW_Character _SW_Char;      // Класс персонажа, с которым происходят изменения

        private bool is_choosen;            // Флаг выбранного состояния
        #endregion

        #region // конструктор класса
        public Race_class() // SW_Character SW_Char
        {
            //_SW_Char = SW_Char;
            Set_Error_Code(0);
        }
        #endregion

        #region //методы класса
         // Устнаваливаем код ошибки для выведения сообщения
        private void Set_Error_Code(int error_code) { Error_code = error_code; }
        // формируем сообщение по сформированному коду ошибки
        public string Get_Error_msg()
        {
            switch (Error_code)
            {
                case 0:
                    Error_msg = "";
                    break;
                case 1:
                    Error_msg = "";
                    break;
                case 2:
                    Error_msg = "";
                    break;
                case 3:
                    Error_msg = "";
                    break;

            }

            return Error_msg;
        }
        // Устанавливаем метод для запоминания описания каждой расы в объектах шаблона
        public void Set_description(string insert_text) { description = insert_text; }
        // Устанавливаем метод для вывода описания каждой расы по запросу
        public string Get_description() { return description; }
        // Устанавливаем метод для запоминания описания бонусов каждой расы в объектах шаблона
        public void Set_description_2(string insert_text) { description_2 = insert_text; }
        // Устанавливаем метод для вывода описания бонусов каждой расы по запросу
        public string Get_description_2() { return description_2; }
        // Устанавливаем метод для запоминания пути к картинке каждой расы в объектах шаблона
        public void Set_img_path(string insert_text) { img_path = insert_text; }
        // Устанавливаем метод для вывода пути картинки каждой расы по запросу
        public string Get_img_path() { return img_path; }
        // Устанавливаем флаг выбранной расы персонажа
        //public void Set_choosen() { is_choosen = true; Set_race_bonus(); }
        // Снимаем флаг выбранной расы персонажа
        //public void Set_unchoosen() { is_choosen = false; Reset_race_bonus(); }
        // Предоставляем состояние флага выбранной расы по запросу
        public bool Get_is_choosen() { return is_choosen; }
        // Устанавливаем имя расы
        public void Set_race_name (string insert_text) { race_name = insert_text; }
        // Предоставляем значение выбранной расы по запросу
        public string Get_race_name(){ return race_name; }
        // Устанавливаем минимальный возраст персонажа - ребенка
        public void Set_min_child_age(int insert_value) { min_child_age = insert_value; }
        // Предоставление значение минимального возраста персонажа - ребенка
        public int Get_min_child_age() { return min_child_age; }
        // Устанавливаем максимальный возраст персонажа - ребенка
        public void Set_max_child_age(int insert_value) { max_child_age = insert_value; }
        // Предоставление значение максимальный возраста персонажа - ребенка
        public int Get_max_child_age() { return max_child_age; }
        // Устанавливаем минимальный возраст персонажа - подростка
        public void Set_min_teen_age(int insert_value) { min_teen_age = insert_value; }
        // Предоставление значение минимального возраста персонажа - подростка
        public int Get_min_teen_age() { return min_teen_age; }
        // Устанавливаем максимальный возраст персонажа - подростка
        public void Set_max_teen_age(int insert_value) { max_teen_age = insert_value; }
        // Предоставление значение максимальный возраста персонажа - подростка
        public int Get_max_teen_age() { return max_teen_age; }
        // Устанавливаем минимальный возраст персонажа - взрослого
        public void Set_min_adult_age(int insert_value) { min_adult_age = insert_value; }
        // Предоставление значение минимального возраста персонажа - взрослого
        public int Get_min_adult_age() { return min_adult_age; }
        // Устанавливаем максимальный возраст персонажа - взрослого
        public void Set_max_adult_age(int insert_value) { max_adult_age = insert_value; }
        // Предоставление значение максимальный возраста персонажа - взрослого
        public int Get_max_adult_age() { return max_adult_age; }
        // Устанавливаем минимальный возраст персонажа - среднего возраста
        public void Set_min_middle_age(int insert_value) { min_middle_age = insert_value; }
        // Предоставление значение минимального возраста персонажа - среднего возраста
        public int Get_min_middle_age() { return min_middle_age; }
        // Устанавливаем максимальный возраст персонажа - среднего возраста
        public void Set_max_middle_age(int insert_value) { max_middle_age = insert_value; }
        // Предоставление значение максимальный возраста персонажа - среднего возраста
        public int Get_max_middle_age() { return max_middle_age; }
        // Устанавливаем минимальный возраст персонажа - пожилого возраста
        public void Set_min_old_age(int insert_value) { min_old_age = insert_value; }
        // Предоставление значение минимального возраста персонажа - пожилого возраста
        public int Get_min_old_age() { return min_old_age; }
        // Устанавливаем максимальный возраст персонажа - пожилого возраста
        public void Set_max_old_age(int insert_value) { max_old_age = insert_value; }
        // Предоставление значение максимальный возраста персонажа - пожилого возраста
        public int Get_max_old_age() { return max_old_age; }
        // Устанавливаем минимальный возраст персонажа - почтенного возраста
        public void Set_min_eldery_age(int insert_value) { min_eldery_age = insert_value; }
        // Предоставление значение минимального возраста персонажа - почтенного возраста
        public int Get_min_eldery_age() { return min_eldery_age; }
        // Устанавливаем уникальный код расы
        public void Set_race_code(int insert_int) { race_code = insert_int; }
        // Предоставляем уникальный код расы
        public int Get_race_code() { return race_code; }
        // Устанавливаем расовый бонус к атрибуту Сила
        public void Set_race_bonus_strength(int insert_int) { race_bonus_strength = insert_int; }
        // Предоставляем расовый бонус к атрибуту Сила
        public int Get_race_bonus_strength() { return race_bonus_strength; }
        // Устанавливаем расовый бонус к атрибуту Ловкость
        public void Set_race_bonus_agility(int insert_int) { race_bonus_agility = insert_int; }
        // Предоставляем расовый бонус к атрибуту Ловкость
        public int Get_race_bonus_agility() { return race_bonus_agility; }
        // Устанавливаем расовый бонус к атрибуту Выносливость
        public void Set_race_bonus_stamina(int insert_int) { race_bonus_stamina = insert_int; }
        // Предоставляем расовый бонус к атрибуту Выносливость
        public int Get_race_bonus_stamina() { return race_bonus_stamina; }
        // Устанавливаем расовый бонус к атрибуту Проворство
        public void Set_race_bonus_quickness(int insert_int) { race_bonus_quickness = insert_int; }
        // Предоставляем расовый бонус к атрибуту Проворство
        public int Get_race_bonus_quickness() { return race_bonus_quickness; }
        // Устанавливаем расовый бонус к атрибуту Восприятие
        public void Set_race_bonus_perception(int insert_int) { race_bonus_perception = insert_int; }
        // Предоставляем расовый бонус к атрибуту Восприятие
        public int Get_race_bonus_perception() { return race_bonus_perception; }
        // Устанавливаем расовый бонус к атрибуту Интеллект
        public void Set_race_bonus_intelligence(int insert_int) { race_bonus_intelligence = insert_int; }
        // Предоставляем расовый бонус к атрибуту Интеллект
        public int Get_race_bonus_intelligence() { return race_bonus_intelligence; }
        // Устанавливаем расовый бонус к атрибуту Обаяние
        public void Set_race_bonus_charm(int insert_int) { race_bonus_charm = insert_int; }
        // Предоставляем расовый бонус к атрибуту Обаяние
        public int Get_race_bonus_charm() { return race_bonus_charm; }
        // Устанавливаем расовый бонус к атрибуту Сила воли
        public void Set_race_bonus_willpower(int insert_int) { race_bonus_willpower = insert_int; }
        // Предоставляем расовый бонус к атрибуту Сила воли
        public int Get_race_bonus_willpower() { return race_bonus_willpower; }
        // Устанавливаем бонусы персонажа при выборе расы
        /*
        public void Set_race_bonus() 
        {
            foreach(Atribute_class atribute in _SW_Char._Atributes)
            {
                switch(atribute.Get_atribute_code())
                {
                    case (int)SW_Character.enum_Atributes.Strength:
                        atribute.Increase_atr(Get_race_bonus_strength());
                        break;
                    case (int)SW_Character.enum_Atributes.Agility:
                        atribute.Increase_atr(Get_race_bonus_agility());
                        break;
                    case (int)SW_Character.enum_Atributes.Stamina:
                        atribute.Increase_atr(Get_race_bonus_stamina());
                        break;
                    case (int)SW_Character.enum_Atributes.Quicness:
                        atribute.Increase_atr(Get_race_bonus_quickness());
                        break;
                    case (int)SW_Character.enum_Atributes.Perception:
                        atribute.Increase_atr(Get_race_bonus_perception());
                        break;
                    case (int)SW_Character.enum_Atributes.Intelligence:
                        atribute.Increase_atr(Get_race_bonus_intelligence());
                        break;
                    case (int)SW_Character.enum_Atributes.Charm:
                        atribute.Increase_atr(Get_race_bonus_charm());
                        break;
                    case (int)SW_Character.enum_Atributes.Willpower:
                        atribute.Increase_atr(Get_race_bonus_willpower());
                        break;
                }
            }
        }
        */
        // Снимаем бонусы персонажа при смене расы
        /*
        public void Reset_race_bonus() 
        {
            foreach (Atribute_class atribute in _SW_Char._Atributes)
            {
                switch (atribute.Get_atribute_code())
                {
                    case (int)SW_Character.enum_Atributes.Strength:
                        atribute.Decrease_atr(Get_race_bonus_strength());
                        break;
                    case (int)SW_Character.enum_Atributes.Agility:
                        atribute.Decrease_atr(Get_race_bonus_agility());
                        break;
                    case (int)SW_Character.enum_Atributes.Stamina:
                        atribute.Decrease_atr(Get_race_bonus_stamina());
                        break;
                    case (int)SW_Character.enum_Atributes.Quicness:
                        atribute.Decrease_atr(Get_race_bonus_quickness());
                        break;
                    case (int)SW_Character.enum_Atributes.Perception:
                        atribute.Decrease_atr(Get_race_bonus_perception());
                        break;
                    case (int)SW_Character.enum_Atributes.Intelligence:
                        atribute.Decrease_atr(Get_race_bonus_intelligence());
                        break;
                    case (int)SW_Character.enum_Atributes.Charm:
                        atribute.Decrease_atr(Get_race_bonus_charm());
                        break;
                    case (int)SW_Character.enum_Atributes.Willpower:
                        atribute.Decrease_atr(Get_race_bonus_willpower());
                        break;
                }
            }
        }
        */

        // Устанавливаем путь к текстовому файлу с описанием навыка
        public void Set_path_read_description(string input_text) { path_read_description = input_text; }
        // Предоставляем путь к текстовому файлу с описанием навыка
        public string Get_path_read_description() { return path_read_description; }
        // Устанавливаем путь к текстовому файлу с описанием навыка
        public void Set_path_read_description_2(string input_text) { path_read_description_2 = input_text; }
        // Предоставляем путь к текстовому файлу с описанием навыка
        public string Get_path_read_description_2() { return path_read_description_2; }
        // Устанавливаем текст общего описания расы
        public void Set_general_description(string input_text) { general_description = input_text; }
        // Предоставляем текст общего описания расы
        public string Get_general_description() { return general_description; }
        public void Set_personal_properties(string input_text) { personal_properties = input_text; }
        public string Get_personal_properties() { return personal_properties; }
        public void Set_physical_properties(string input_text) { physical_properties = input_text; }
        public string Get_physical_properties() { return physical_properties; }
        public void Set_home_world(string input_text) { home_world = input_text; }
        public string Get_home_world() { return home_world; }
        public void Set_language_1(string input_text) { language_1 = input_text; }
        public string Get_language_1() { return language_1; }
        public void Set_language_2(string input_text) { language_2 = input_text; }
        public string Get_language_2() { return language_2; }
        public void Set_language_3(string input_text) { language_3 = input_text; }
        public string Get_language_3() { return language_3; }
        public void Set_language_4(string input_text) { language_4 = input_text; }
        public string Get_language_4() { return language_4; }
        public void Set_feature_1(string input_text) { feature_1 = input_text; }
        public string Get_feature_1() { return feature_1; }
        public void Set_feature_2(string input_text) { feature_2 = input_text; }
        public string Get_feature_2() { return feature_2; }
        public void Set_feature_3(string input_text) { feature_3 = input_text; }
        public string Get_feature_3() { return feature_3; }
        public void Set_feature_4(string input_text) { feature_4 = input_text; }
        public string Get_feature_4() { return feature_4; }
        public void Set_feature_5(string input_text) { feature_5 = input_text; }
        public string Get_feature_5() { return feature_5; }
        public void Set_feature_6(string input_text) { feature_6 = input_text; }
        public string Get_feature_6() { return feature_6; }
        public void Set_language_1_lvl(int input_int) { language_1_lvl = input_int; }
        public int Get_language_1_lvl() { return language_1_lvl; }
        public void Set_language_2_lvl(int input_int) { language_2_lvl = input_int; }
        public int Get_language_2_lvl() { return language_2_lvl; }
        public void Set_language_3_lvl(int input_int) { language_3_lvl = input_int; }
        public int Get_language_3_lvl() { return language_3_lvl; }
        public void Set_language_4_lvl(int input_int) { language_4_lvl = input_int; }
        public int Get_language_4_lvl() { return language_4_lvl; }
        public void Set_race_reaction_bonus(int insert_int) { reaction_bonus = insert_int;  }
        public int Get_race_reaction_bonus() { return reaction_bonus; }
        public void Set_race_armor_bonus(int insert_int) { armor_bonus = insert_int; }
        public int Get_race_armor_bonus() { return armor_bonus; }
        public void Set_race_stealthiness_combat_bonus(int insert_int) { stealthiness_combat_bonus = insert_int;}
        public int Get_race_stealthiness_combat_bonus() { return stealthiness_combat_bonus; }
        public void Set_race_force_resist_bonus(int insert_int) { force_resist_bonus = insert_int; }
        public int Get_race_force_resist_bonus() { return force_resist_bonus; }
        public void Set_race_watchfulness_combat_bonus(int insert_int) { watchfulness_combat_bonus = insert_int; }
        public int Get_race_watchfulness_combat_bonus() { return watchfulness_combat_bonus; }
        public void Set_race_flow_control_bonus(int insert_int) { flow_control_bonus = insert_int; }
        public int Get_race_flow_control_bonus() { return flow_control_bonus; }
        public void Set_swimming_bonus(int insert_int) { swimming_bonus = insert_int; }
        public int Get_swimming_bonus() { return swimming_bonus; }
        public void Set_heavy_athletics_bonus(int insert_int) { heavy_athletics_bonus = insert_int; }
        public int Get_heavy_athletics_bonus() { return heavy_athletics_bonus; }
        public void Set_climbing_bonus(int insert_int) { climbing_bonus = insert_int; }
        public int Get_climbing_bonus() { return climbing_bonus; }
        public void Set_light_athletics_bonus(int insert_int) { light_athletics_bonus = insert_int; }
        public int Get_light_athletics_bonus() { return light_athletics_bonus; }
        public void Set_sleight_of_hand_bonus(int insert_int) { sleight_of_hand_bonus = insert_int; }
        public int Get_sleight_of_hand_bonus() { return sleight_of_hand_bonus; }
        public void Set_stealthiness_bonus(int insert_int) { stealthiness_bonus = insert_int; }
        public int Get_stealthiness_bonus() { return stealthiness_bonus; }
        public void Set_acrobatics_bonus(int insert_int) { acrobatics_bonus = insert_int; }
        public int Get_acrobatics_bonus() { return acrobatics_bonus; }
        public void Set_horse_riding_bonus(int insert_int) { horse_riding_bonus = insert_int; }
        public int Get_horse_riding_bonus() { return horse_riding_bonus; }
        public void Set_light_saber_fighting_bonus(int insert_int) { light_saber_fighting_bonus = insert_int; }
        public int Get_light_saber_fighting_bonus() { return light_saber_fighting_bonus; }
        public void Set_hand_combat_bonus(int insert_int) { hand_combat_bonus = insert_int; }
        public int Get_hand_combat_bonus() { return hand_combat_bonus; }
        public void Set_usual_saber_fighting_bonus(int insert_int) { usual_saber_fighting_bonus = insert_int; }
        public int Get_usual_saber_fighting_bonus() { return usual_saber_fighting_bonus; }
        public void Set_evasion_bonus(int insert_int) { evasion_bonus = insert_int; }
        public int Get_evasion_bonus() { return evasion_bonus; }
        public void Set_throwing_bonus(int insert_int) { throwing_bonus = insert_int; }
        public int Get_throwing_bonus() { return throwing_bonus; }
        public void Set_lips_reading_bonus(int insert_int) { lips_reading_bonus = insert_int; }
        public int Get_lips_reading_bonus() { return lips_reading_bonus; }
        public void Set_old_weapon_bonus(int insert_int) { old_weapon_bonus = insert_int; }
        public int Get_old_weapon_bonus() { return old_weapon_bonus; }
        public void Set_light_weapon_bonus(int insert_int) { light_weapon_bonus = insert_int; }
        public int Get_light_weapon_bonus() { return light_weapon_bonus; }
        public void Set_heavy_weapon_bonus(int insert_int) { heavy_weapon_bonus = insert_int; }
        public int Get_heavy_weapon_bonus() { return heavy_weapon_bonus; }
        public void Set_sniper_weapon_bonus(int insert_int) { sniper_weapon_bonus = insert_int; }
        public int Get_sniper_weapon_bonus() { return sniper_weapon_bonus; }
        public void Set_musicality_bonus(int insert_int) { musicality_bonus = insert_int; }
        public int Get_musicality_bonus() { return musicality_bonus; }
        public void Set_riding_bonus(int insert_int) { riding_bonus = insert_int; }
        public int Get_riding_bonus() { return riding_bonus; }
        public void Set_resisting_bonus(int insert_int) { resisting_bonus = insert_int; }
        public int Get_resisting_bonus() { return resisting_bonus; }
        public void Set_strength_of_mind_bonus(int insert_int) { strength_of_mind_bonus = insert_int; }
        public int Get_strength_of_mind_bonus() { return strength_of_mind_bonus; }
        public void Set_watchfulness_bonus(int insert_int) { watchfulness_bonus = insert_int; }
        public int Get_watchfulness_bonus() { return watchfulness_bonus; }
        public void Set_pilot_bonus(int insert_int) { pilot_bonus = insert_int; }
        public int Get_pilot_bonus() { return pilot_bonus; }
        public void Set_programming_bonus(int insert_int) { programming_bonus = insert_int; }
        public int Get_programming_bonus() { return programming_bonus; }
        public void Set_surviving_bonus(int insert_int) { surviving_bonus = insert_int; }
        public int Get_surviving_bonus() { return surviving_bonus; }
        public void Set_reapair_bonus(int insert_int) { reapair_bonus = insert_int; }
        public int Get_reapair_bonus() { return reapair_bonus; }
        public void Set_training_bonus(int insert_int) { training_bonus = insert_int; }
        public int Get_training_bonus() { return training_bonus; }
        public void Set_medicine_crafting_bonus(int insert_int) { medicine_crafting_bonus = insert_int; }
        public int Get_medicine_crafting_bonus() { return medicine_crafting_bonus; }
        public void Set_science_bonus(int insert_int) { science_bonus = insert_int; }
        public int Get_science_bonus() { return science_bonus; }
        public void Set_engineering_bonus(int insert_int) { engineering_bonus = insert_int; }
        public int Get_engineering_bonus() { return engineering_bonus; }
        public void Set_star_wars_tactic_bonus(int insert_int) { star_wars_tactic_bonus = insert_int; }
        public int Get_star_wars_tactic_bonus() { return star_wars_tactic_bonus; }
        public void Set_crafting_bonus(int insert_int) { crafting_bonus = insert_int; }
        public int Get_crafting_bonus() { return crafting_bonus; }
        public void Set_trading_bonus(int insert_int) { trading_bonus = insert_int; }
        public int Get_trading_bonus() { return trading_bonus; }
        public void Set_astronavigation_bonus(int insert_int) { astronavigation_bonus = insert_int; }
        public int Get_astronavigation_bonus() { return astronavigation_bonus; }
        public void Set_change_looking_bonus(int insert_int) { change_looking_bonus = insert_int; }
        public int Get_change_looking_bonus() { return change_looking_bonus; }
        public void Set_light_saber_crafting_bonus(int insert_int) { light_saber_crafting_bonus = insert_int; }
        public int Get_light_saber_crafting_bonus() { return light_saber_crafting_bonus; }
        public void Set_exploding_bonus(int insert_int) { exploding_bonus = insert_int; }
        public int Get_exploding_bonus() { return exploding_bonus; }
        public void Set_security_bonus(int insert_int) { security_bonus = insert_int; }
        public int Get_security_bonus() { return security_bonus; }
        public void Set_medicine_bonus(int insert_int) { medicine_bonus = insert_int; }
        public int Get_medicine_bonus() { return medicine_bonus; }
        public void Set_language_bonus(int insert_int) { language_bonus = insert_int; }
        public int Get_language_bonus() { return language_bonus; }
        public void Set_knowledge_bonus(int insert_int) { knowledge_bonus = insert_int; }
        public int Get_knowledge_bonus() { return knowledge_bonus; }
        public void Set_dancing_bonus(int insert_int) { dancing_bonus = insert_int; }
        public int Get_dancing_bonus() { return dancing_bonus; }
        public void Set_interrogation_bonus(int insert_int) { interrogation_bonus = insert_int; }
        public int Get_interrogation_bonus() { return interrogation_bonus; }
        public void Set_diplomacy_bonus(int insert_int) { diplomacy_bonus = insert_int; }
        public int Get_diplomacy_bonus() { return diplomacy_bonus; }
        public void Set_leadership_bonus(int insert_int) { leadership_bonus = insert_int; }
        public int Get_leadership_bonus() { return leadership_bonus; }
        public void Set_singing_bonus(int insert_int) { singing_bonus = insert_int; }
        public int Get_singing_bonus() { return singing_bonus; }
        public void Set_deception_bonus(int insert_int) { deception_bonus = insert_int; }
        public int Get_deception_bonus() { return deception_bonus; }
        public void Set_insight_bonus(int insert_int) { insight_bonus = insert_int; }
        public int Get_insight_bonus() { return insight_bonus; }
        public void Set_seduction_bonus(int insert_int) { seduction_bonus = insert_int; }
        public int Get_seduction_bonus() { return seduction_bonus; }

        #endregion
    }
}
