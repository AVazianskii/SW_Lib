using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_status_libs
{
    public class Age_status_class
    {
        #region // Переменные класса
        
        private int age_status_code;            // уникальный код для определения возрастного статуса персонажа

        private string age_status_name;         // название возратсного статуса персонажа 
        private string age_status_descr;        // описание возрастного статуса персонажа


        private int age_status_strength_bonus;      // бонус к атрибуту Сила            при изменении возрастного статуса
        private int age_status_agility_bonus;       // бонус к атрибуту Ловкость        при изменении возрастного статуса
        private int age_status_stamina_bonus;       // бонус к атрибуту Выносливость    при изменении возрастного статуса
        private int age_status_quickness_bonus;     // бонус к атрибуту Проворство      при изменении возрастного статуса
        private int age_status_perception_bonus;    // бонус к атрибуту Восприятие      при изменении возрастного статуса
        private int age_status_intelligence_bonus;  // бонус к атрибуту Интеллект       при изменении возрастного статуса
        private int age_status_charm_bonus;         // бонус к атрибуту Обаяние         при изменении возрастного статуса
        private int age_status_willpower_bonus;     // бонус к атрибуту Сила воли       при изменении возрастного статуса

        private int age_status_strength_limit,
                    age_status_agility_limit,
                    age_status_stamina_limit,
                    age_status_quickness_limit,
                    age_status_perception_limit,
                    age_status_intelligence_limit,
                    age_status_charm_limit,
                    age_status_willpower_limit;

        private int skill_limit,
                    force_skill_limit;

        private string age_status_feature_descr;

        public string Age_status_name { get; set; }

        public int Age_status_strength_limit
        {
            get { return age_status_strength_limit; }
            set { age_status_strength_limit = value; }
        }
        public int Age_status_agility_limit
        {
            get { return age_status_agility_limit; }
            set { age_status_agility_limit = value; }
        }
        public int Age_status_stamina_limit
        {
            get { return age_status_stamina_limit; }
            set { age_status_stamina_limit = value; }
        }
        public int Age_status_quickness_limit
        {
            get { return age_status_quickness_limit; }
            set { age_status_quickness_limit = value; }
        }
        public int Age_status_perception_limit
        {
            get { return age_status_perception_limit; }
            set { age_status_perception_limit = value; }
        }
        public int Age_status_intelligence_limit
        {
            get { return age_status_intelligence_limit; }
            set { age_status_intelligence_limit = value; }
        }
        public int Age_status_charm_limit
        {
            get { return age_status_charm_limit; }
            set { age_status_charm_limit = value; }
        }
        public int Age_status_willpower_limit
        {
            get { return age_status_willpower_limit; }
            set { age_status_willpower_limit = value; }
        }
        public int Skill_limit
        {
            get { return skill_limit; }
            set { skill_limit = value; }
        }
        public int Force_skill_limit
        {
            get { return force_skill_limit; }
            set { force_skill_limit = value; }
        }
        #endregion

        #region // Конструктор класса
        internal Age_status_class()
        {
            
        }
        #endregion

        #region // Методы класса
        // Устанавливаем уникальный код для определения возрастного статуса персонажа
        public void Set_age_status_code(int insert_int) { age_status_code = insert_int; }
        // Получаем уникальный код возрастного статуса персонажа
        public int Get_age_status_code() { return age_status_code; }
        // Устанавливаем название возрастного статуса персонажа
        public void Set_age_status_name(string insert_text) { age_status_name = insert_text; Age_status_name = insert_text; }
        // Получаем название возрастного статуса персонажа
        public string Get_age_status_name() { return age_status_name; }
        // Устанавливаем описание возрастного статуса персонажа
        public void Set_age_status_descr(string insert_text) { age_status_descr = insert_text; }
        // Получаем описание возрастного статуса персонажа
        public string Get_age_status_descr() { return age_status_descr; }
        // Устанавливаем значение бонуса к атрибуту Сила
        public void Set_age_status_strength_bonus(int insert_int) 
        { 
            age_status_strength_bonus = insert_int; 
        }
        // Получаем значение бонуса к атрибуту Сила
        public int Get_age_status_strength_bonus()
        {
            return age_status_strength_bonus;
        }
        // Устанавливаем значение бонуса к атрибуту Ловкость
        public void Set_age_status_agility_bonus(int insert_int)
        {
            age_status_agility_bonus = insert_int;
        }
        // Получаем значение бонуса к атрибуту Ловкость
        public int Get_age_status_agility_bonus()
        {
            return age_status_agility_bonus;
        }
        // Устанавливаем значение бонуса к атрибуту Выносливость
        public void Set_age_status_stamina_bonus(int insert_int)
        {
            age_status_stamina_bonus = insert_int;
        }
        // Получаем значение бонуса к атрибуту Выносливость
        public int Get_age_status_stamina_bonus()
        {
            return age_status_stamina_bonus;
        }
        // Устанавливаем значение бонуса к атрибуту Проворство
        public void Set_age_status_quickness_bonus(int insert_int)
        {
            age_status_quickness_bonus = insert_int;
        }
        // Получаем значение бонуса к атрибуту Проворство
        public int Get_age_status_quickness_bonus()
        {
            return age_status_quickness_bonus;
        }
        // Устанавливаем значение бонуса к атрибуту Восприятие
        public void Set_age_status_perception_bonus(int insert_int)
        {
            age_status_perception_bonus = insert_int;
        }
        // Получаем значение бонуса к атрибуту Восприятие
        public int Get_age_status_perception_bonus()
        {
            return age_status_perception_bonus;
        }
        // Устанавливаем значение бонуса к атрибуту Интеллект
        public void Set_age_status_intelligence_bonus(int insert_int)
        {
            age_status_intelligence_bonus = insert_int;
        }
        // Получаем значение бонуса к атрибуту Интеллект
        public int Get_age_status_intelligence_bonus()
        {
            return age_status_intelligence_bonus;
        }
        // Устанавливаем значение бонуса к атрибуту Обаяние
        public void Set_age_status_charm_bonus(int insert_int)
        {
            age_status_charm_bonus = insert_int;
        }
        // Получаем значение бонуса к атрибуту Обаяние
        public int Get_age_status_charm_bonus()
        {
            return age_status_charm_bonus;
        }
        // Устанавливаем значение бонуса к атрибуту Сила Воли
        public void Set_age_status_willpower_bonus(int insert_int)
        {
            age_status_willpower_bonus = insert_int;
        }
        // Получаем значение бонуса к атрибуту Сила Воли
        public int Get_age_status_willpower_bonus()
        {
            return age_status_willpower_bonus;
        }
        public void Set_age_status_feature_descr(string input_text) { age_status_feature_descr = input_text; }
        public string Get_age_status_feature_descr() { return age_status_feature_descr; }
        #endregion
    }
}
