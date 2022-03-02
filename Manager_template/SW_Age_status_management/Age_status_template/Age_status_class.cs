using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_Class
{
    public class Age_status_class
    {
        #region // Переменные класса
        private SW_Character _SW_Char;

        private int age_status_code;            // уникальный код для определения возрастного статуса персонажа

        private string age_status_name;         // название возратсного статуса персонажа 
        private string age_status_descr;        // описание возрастного статуса персонажа
        private string path_read_description;   // Путь к файлу для вычитывания текстового описания навыка


        private int age_status_strength_bonus;      // бонус к атрибуту Сила            при изменении возрастного статуса
        private int age_status_agility_bonus;       // бонус к атрибуту Ловкость        при изменении возрастного статуса
        private int age_status_stamina_bonus;       // бонус к атрибуту Выносливость    при изменении возрастного статуса
        private int age_status_quickness_bonus;     // бонус к атрибуту Проворство      при изменении возрастного статуса
        private int age_status_perception_bonus;    // бонус к атрибуту Восприятие      при изменении возрастного статуса
        private int age_status_intelligence_bonus;  // бонус к атрибуту Интеллект       при изменении возрастного статуса
        private int age_status_charm_bonus;         // бонус к атрибуту Обаяние         при изменении возрастного статуса
        private int age_status_willpower_bonus;     // бонус к атрибуту Сила воли       при изменении возрастного статуса
        #endregion

        #region // Конструктор класса
        public Age_status_class(SW_Character SW_Char)
        {
            _SW_Char = SW_Char;
        }
        #endregion

        #region // Методы класса
        // Устанавливаем уникальный код для определения возрастного статуса персонажа
        public void Set_age_status_code(int insert_int) { age_status_code = insert_int; }
        // Получаем уникальный код возрастного статуса персонажа
        public int Get_age_status_code() { return age_status_code; }
        // Устанавливаем название возрастного статуса персонажа
        public void Set_age_status_name(string insert_text) { age_status_name = insert_text; }
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
        // Добавляем бонусы к атрибутам при установке нового возрастного статуса персонажа
        public void Set_age_status_atr_bonus() 
        {
            foreach (Atribute_class atribute in _SW_Char._Atributes)
            {
                switch (atribute.Get_atribute_code())
                {
                    case (int)SW_Character.enum_Atributes.Strength:
                        atribute.Increase_atr(Get_age_status_strength_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Agility:
                        atribute.Increase_atr(Get_age_status_agility_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Stamina:
                        atribute.Increase_atr(Get_age_status_stamina_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Perception:
                        atribute.Increase_atr(Get_age_status_perception_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Quicness:
                        atribute.Increase_atr(Get_age_status_quickness_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Intelligence:
                        atribute.Increase_atr(Get_age_status_intelligence_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Charm:
                        atribute.Increase_atr(Get_age_status_charm_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Willpower:
                        atribute.Increase_atr(Get_age_status_willpower_bonus());
                        break;
                }
            }
        }
        // Снимаем бонусы к атрибутам при смене текущего возрастного статуса персонажа
        public void Reset_age_status_atr_bonus() 
        {
            foreach (Atribute_class atribute in _SW_Char._Atributes)
            {
                switch (atribute.Get_atribute_code())
                {
                    case (int)SW_Character.enum_Atributes.Strength:
                        atribute.Decrease_atr(Get_age_status_strength_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Agility:
                        atribute.Decrease_atr(Get_age_status_agility_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Stamina:
                        atribute.Decrease_atr(Get_age_status_stamina_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Perception:
                        atribute.Decrease_atr(Get_age_status_perception_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Quicness:
                        atribute.Decrease_atr(Get_age_status_quickness_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Intelligence:
                        atribute.Decrease_atr(Get_age_status_intelligence_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Charm:
                        atribute.Decrease_atr(Get_age_status_charm_bonus());
                        break;
                    case (int)SW_Character.enum_Atributes.Willpower:
                        atribute.Decrease_atr(Get_age_status_willpower_bonus());
                        break;
                }
            }
        }
        // Устанавливаем путь к текстовому файлу с описанием навыка
        public void Set_path_read_description(string input_text) { path_read_description = input_text; }
        // Предоставляем путь к текстовому файлу с описанием навыка
        public string Get_path_read_description() { return path_read_description; }
        #endregion
    }
}
