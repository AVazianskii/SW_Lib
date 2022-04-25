namespace Attribute_libs
{
    public class Atribute_class
    {
        #region // Переменные шаблона
        private int atribute_for_exp;       // счетчик прокачки атрибута персонажа за очки опыта
        private int atribute_for_atr;       // счетчик прокачки атрибута персонажа за очки атрибутов
        private int score;                  // значение атрибута персонажа
        private int atr_limit;              // лимит прокачки атрибутов персонажа
        private int age_attribute_limit;    // Лимит атрибута исходя из возраста персонажа
        private int range_attribute_limit;  // Лимит атрибута исходя из ранга персонажа

        private int child_attribute_limit;  // Возрастной лимит атрибутов для ребенка
        private int teen_attribute_limit;   // Возрастной лимит атрибутов для подростка
        private int adult_attribute_limit;  // Возрастной лимит атрибутов для взрослого
        private int middle_attribute_limit; // Возрастной лимит атрибутов для среднего возраста
        private int old_attribute_limit;    // Возрастной лимит атрибутов для старого возраста
        private int eldery_attribute_limit; // Возрастной лимит атрибутов для пожилого возраста
        private int unknown_age_attribute_limit; // Возрастной лимит атрибутов для неизвестного возраста

        private int Private_range_limit;    // Лимит атрибутов по рангу Рядовой
        private int Veteran_range_limit;    // Лимит атрибутов по рангу Ветеран
        private int Hero_range_limit;       // Лимит атрибутов по рангу Герой
        private int Epic_range_limit;       // Лимит атрибутов по рангу Эпик
        private int Immortal_range_limit;   // Лимит атрибутов по рангу Бессмертный

        private int atribute_code;          // Код атрибута

        private string description;         // описание атрибута персонажа

        private int attribute_cost_for_atr,
                    attribute_cost_for_exp;

        #endregion

        #region // Конструктор шаблона
        internal Atribute_class()
        {
            atribute_for_atr = 0;           // устанавливаем значение счетчика прокачки за очки атрибутов
            atribute_for_exp = 0;           // устанавливаем значение счетчика прокачки за очки опыта
        }
        #endregion

        #region // Методы шаблона

        public void Increase_atr_for_exp() { atribute_for_exp = atribute_for_exp + 1; }
        public void Decrease_atr_for_exp() { atribute_for_exp = atribute_for_exp - 1; }
        public int Get_atr_for_exp() { return atribute_for_exp; }
        public void Increase_atr_for_atr() { atribute_for_atr = atribute_for_atr + 1; }
        public void Decrease_atr_for_atr() { atribute_for_atr = atribute_for_atr - 1; }
        public int Get_atr_for_atr() { return atribute_for_atr; }
        public void Increase_atr(int insert_value) { score = score + insert_value; }

        public void Decrease_atr(int insert_value) { score = score - insert_value; }
        public void Set_atr_score(int insert_value) { score = insert_value; }
        public int Get_atribute_score() { return score; }
        public void Set_description(string insert_text) { description = insert_text; }
        public string Get_description () { return description; }


        public void Set_child_attribute_limit       (int insert_int) { child_attribute_limit = insert_int; }                public int Get_child_attribute_limit()          { return child_attribute_limit; }
        public void Set_teen_attribute_limit        (int insert_int) { teen_attribute_limit = insert_int; }                 public int Get_teen_attribute_limit()           { return teen_attribute_limit; }
        public void Set_adult_attribute_limit       (int insert_int) { adult_attribute_limit = insert_int; }                public int Get_adult_attribute_limit()          { return adult_attribute_limit; }
        public void Set_middle_attribute_limit      (int insert_int) { middle_attribute_limit = insert_int; }               public int Get_middle_attribute_limit()         { return middle_attribute_limit; }
        public void Set_old_attribute_limit         (int insert_int) { old_attribute_limit = insert_int; }                  public int Get_old_attribute_limit()            { return old_attribute_limit; }
        public void Set_eldery_attribute_limit      (int insert_int) { eldery_attribute_limit = insert_int; }               public int Get_eldery_attribute_limit()         { return eldery_attribute_limit; }
        public void Set_unknown_age_attribute_limit (int insert_int) { unknown_age_attribute_limit = insert_int; }          public int Get_unknown_age_attribute_limit()    { return unknown_age_attribute_limit; }
        public int Get_age_attribute_limit() { return age_attribute_limit; }
        #endregion


        public void Set_private_range_attribute_limit   (int insert_int) { Private_range_limit = insert_int; }          public int Get_private_range_attribute_limit()  { return Private_range_limit; }
        public void Set_veteran_range_attribute_limit   (int insert_int) { Veteran_range_limit = insert_int; }          public int Get_veteran_range_attribute_limit()  { return Veteran_range_limit; }
        public void Set_hero_range_attribute_limit      (int insert_int) { Hero_range_limit = insert_int; }             public int Get_hero_range_attribute_limit()     { return Hero_range_limit; }
        public void Set_epic_range_attribute_limit      (int insert_int) { Epic_range_limit = insert_int; }             public int Get_epic_range_attribute_limit()     { return Epic_range_limit; }
        public void Set_immortal_range_attribute_limit  (int insert_int) { Immortal_range_limit = insert_int; }         public int Get_immortal_range_attribute_limit() { return Immortal_range_limit; }
        public int Get_range_attribute_limit() { return range_attribute_limit; }

        public void Set_atribute_code(int insert_int) { atribute_code = insert_int; }
        public int Get_atribute_code() { return atribute_code; }
        public void Set_attribute_cost_for_atr(int insert_int) { attribute_cost_for_atr = insert_int; }
        public int Get_attribute_cost_for_atr() { return attribute_cost_for_atr; }
        public void Set_attribute_cost_for_exp(int insert_int) { attribute_cost_for_exp = insert_int; }
        public int Get_attribute_cost_for_exp() { return attribute_cost_for_exp; }

    }
}
