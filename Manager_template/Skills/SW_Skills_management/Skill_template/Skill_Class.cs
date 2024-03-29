﻿using SW_Character_creation;


namespace SW_Character_creation
{
    public class Skill_Class : All_skill_template
    {
        #region // переменные класса

        private int score; // Величина навыка
        private int cost;
        private int Error_code;
        private string Error_msg;
        private int counter;

        private int child_skill_limit,              // Возрастной лимит навыков для Ребенок
                    teen_skill_limit,               // Возрастной лимит навыков для Подросток
                    adult_skill_limit,              // Возрастной лимит навыков для Взрослый
                    middle_skill_limit,             // Возрастной лимит навыков для Средний
                    old_skill_limit,                // Возрастной лимит навыков для Пожилой
                    eldery_skill_limit,             // Возрастной лимит навыков для Почтенный
                    unknown_age_status_skill_limit; // Возрастной лимит навыков для Неизвестный возрастной статус

        private int private_skill_limit,            // Лимит прокачки навыков для Рядовой
                    veteran_skill_limit,            // Лимит прокачки навыков для Ветеран
                    hero_skill_limit,               // Лимит прокачки навыков для Герой
                    epic_skill_limit,               // Лимит прокачки навыков для Эпик
                    immortal_skill_limit;           // Лимит прокачки навыков для Бессмертный

        private bool is_combat_skill;               // Флаг, является ли навык боевым умением. 1 - является, 0 - не является

        private int Non_force_user_cost,
                    Forceuser_cost;


        
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        #endregion

        #region // конструктор класса

        internal Skill_Class()
        {
            counter = 0;
            Set_Error_Code(0);
        }

        #endregion

        #region //методы класса

        #region // Методы установки счетчика прокачки умения для контроля за расовыми бонусами умения
        public void Set_counter (int insert_value) { counter = insert_value; }
        public int Get_counter() { return counter; }
        private void Increase_counter() { counter = counter + 1; }
        private void Decrease_counter() { counter = counter - 1; }
        #endregion
         
        #region // Методы установки стоимости умения
        public void Set_cost(int insert_value) { cost = insert_value; }
        public int Get_cost() { return cost; }
        #endregion

        #region // Методы установки значения умения навыка
        public void Set_score(int insert_value) { score = insert_value; Score = insert_value; }
        public int Get_score() { return score; }
        #endregion


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
                    Error_msg = "Превышение лимита очков умений для вашего персонажа!";
                    break;
                case 2:
                    Error_msg = "Невозможно опустить значение умения персонажа ниже 0!";
                    break;
                case 3:
                    Error_msg = "Недостаточно очков опыта для изучения данного навыка!";
                    break;

            }
            
            return Error_msg; 
        }

        #region // методы установки возрастных лимитов прокачки навыка
        // Устанавливаем значение возрастного лимита умения для Ребеной
        public void Set_child_skill_limit(int insert_int) { child_skill_limit = insert_int; }
        // Предоставление значение возрастного лимита умения для Ребенок
        public int Get_child_skill_limit() { return child_skill_limit; }
        // Устанавливаем значение возрастного лимита умения для Подросток
        public void Set_teen_skill_limit(int insert_int) { teen_skill_limit = insert_int; }
        // Предоставление значение возрастного лимита умения для Подросток
        public int Get_teen_skill_limit() { return teen_skill_limit; }
        // Устанавливаем значение возрастного лимита умения для Взрослый
        public void Set_adult_skill_limit(int insert_int) { adult_skill_limit = insert_int; }
        // Предоставление значение возрастного лимита умения для Взрослый
        public int Get_adult_skill_limit() { return adult_skill_limit; }
        // Устанавливаем значение возрастного лимита умения для Средний
        public void Set_middle_skill_limit(int insert_int) { middle_skill_limit = insert_int; }
        // Предоставление значение возрастного лимита умения для Средний
        public int Get_middle_skill_limit() { return middle_skill_limit; }
        // Устанавливаем значение возрастного лимита умения для Пожилой
        public void Set_old_skill_limit(int insert_int) { old_skill_limit = insert_int; }
        // Предоставление значение возрастного лимита умения для Пожилой
        public int Get_old_skill_limit() { return old_skill_limit; }
        // Устанавливаем значение возрастного лимита умения для Почтенный
        public void Set_eldery_skill_limit(int insert_int) { eldery_skill_limit = insert_int; }
        // Предоставление значение возрастного лимита умения для Почтенный
        public int Get_eldery_skill_limit() { return eldery_skill_limit; }
        // Устанавливаем значение возрастного лимита умения для Неизвестный возрастной статус
        public void Set_unknown_age_status_skill_limit(int insert_int) { unknown_age_status_skill_limit = insert_int; }
        // Предоставление значение возрастного лимита умения для Неизвестный возрастной статус
        public int Get_unknown_age_status_skill_limit() { return unknown_age_status_skill_limit; }
        #endregion


        #region // методы лимиты прокачки навыка персонажа в относительности от ранга персонажа
        // Устаниваливаем значение лимита прокачки навыка для Рядовой
        public void Set_private_skill_limit(int insert_int) { private_skill_limit = insert_int; }
        // Предоставляем значение лимита прокачки навыка для Рядовой
        public int Get_private_skill_limit() { return private_skill_limit; }
        // Устаниваливаем значение лимита прокачки навыка для Ветеран
        public void Set_veteran_skill_limit(int insert_int) { veteran_skill_limit = insert_int; }
        // Предоставляем значение лимита прокачки навыка для Ветеран
        public int Get_veteran_skill_limit() { return veteran_skill_limit; }
        // Устаниваливаем значение лимита прокачки навыка для Герой
        public void Set_hero_skill_limit(int insert_int) { hero_skill_limit = insert_int; }
        // Предоставляем значение лимита прокачки навыка для Герой
        public int Get_hero_skill_limit() { return hero_skill_limit; }
        // Устаниваливаем значение лимита прокачки навыка для Эпик
        public void Set_epic_skill_limit(int insert_int) { epic_skill_limit = insert_int; }
        // Предоставляем значение лимита прокачки навыка для Эпик
        public int Get_epic_skill_limit() { return epic_skill_limit; }
        // Устаниваливаем значение лимита прокачки навыка для Бессмертный
        public void Set_immortal_skill_limit(int insert_int) { immortal_skill_limit = insert_int; }
        // Предоставляем значение лимита прокачки навыка для Бессмертный
        public int Get_immortal_skill_limit() { return immortal_skill_limit; }
        #endregion

        // Устанавливаем флаг, является ли навык боевым умением
        public void Set_is_combat_skill() { is_combat_skill = true; }
        public void Reset_is_combat_skill() { is_combat_skill = false; }
        // Предоставляем значения флага боевого умения
        public bool Get_is_combat_skill() { return is_combat_skill; }

        public void Set_Non_force_user_cost(int input_int) { Non_force_user_cost = input_int; }
        public int Get_Non_force_user_cost() { return Non_force_user_cost; }
        public void Set_Forceuser_cost(int input_int) { Forceuser_cost = input_int; }
        public int Get_Forceuser_cost() { return Forceuser_cost; }
        public void Increase_score()
        {
            score = score + 1;
            Increase_counter();
        }
        public void Decrease_score()
        {
            score = score - 1;
            Decrease_counter();
        }
        #endregion
    }
}
