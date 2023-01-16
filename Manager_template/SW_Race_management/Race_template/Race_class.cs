using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public class Race_class
    {
        public string Race_name {get;set; }
        public string Small_img_path { get; set; }
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
        private string small_img_path;          // путь к иконке расы


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
                       feature_6,           // 6 особенность расы
                       feature_7;           // 7 особенность расы

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

        private bool is_choosen;            // Флаг выбранного состояния

        private List<int> race_skill_bonus;

        public List<int> Race_skill_bonus
        {
            get { return race_skill_bonus; }
            set { race_skill_bonus = value; }
        }
        #endregion

        #region // конструктор класса
        internal Race_class() 
        {
            Set_Error_Code(0);
            Race_skill_bonus = new List<int>();
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
        public void Set_race_name (string insert_text) { race_name = insert_text; Race_name = insert_text; }
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
        public void Set_feature_7(string input_text) { feature_7 = input_text; }
        public string Get_feature_7() { return feature_7; }
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
        public void Set_small_img_path(string insert_text) { small_img_path = insert_text; Small_img_path = insert_text; }
        // Устанавливаем метод для вывода пути картинки каждой расы по запросу
        public string Get_small_img_path() { return small_img_path; }

        #endregion
    }
}
