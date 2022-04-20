using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_libs
{
    public class Range_Class
    {
        #region // переменные класса
        private int range_code;             // числовой код для определения ранга

        private string range_name;          // задаем название для ранга
        private string range_description;   // описание ранга персонажа
        private int strength_limit;
        private int agility_limit;
        private int stamina_limit;
        private int quickness_limit;
        private int perception_limit;
        private int intelligence_limit;
        private int charm_limit;
        private int willpower_limit;

        private int combat_skill_limit,
                    surviving_skill_limit,
                    charming_skill_limit,
                    tech_skills_limit,
                    specific_skills_limit;


        public string Range_name { get; set; }
        public int Strength_limit 
        {   
            get { return strength_limit;  }
            set { strength_limit = value; }
        }
        public int Agility_limit
        {
            get { return agility_limit; }
            set { agility_limit = value; }
        }
        public int Stamina_limit
        {
            get { return stamina_limit; }
            set { stamina_limit = value; }
        }
        public int Quickness_limit
        {
            get { return quickness_limit; }
            set { quickness_limit = value; }
        }
        public int Perception_limit
        {
            get { return perception_limit; }
            set { perception_limit = value; }
        }
        public int Intelligence_limit
        {
            get { return intelligence_limit; }
            set { intelligence_limit = value; }
        }
        public int Charm_limit
        {
            get { return charm_limit; }
            set { charm_limit = value; }
        }
        public int Willpower_limit
        {
            get { return willpower_limit; }
            set { willpower_limit = value; }
        }
        public int Combat_skill_limit
        {
            get { return combat_skill_limit; }
            set { combat_skill_limit = value; }
        }
        public int Surviving_skill_limit
        {
            get { return surviving_skill_limit; }
            set { surviving_skill_limit = value; }
        }
        public int Charming_skill_limit
        {
            get { return charming_skill_limit; }
            set { charming_skill_limit = value; }
        }
        public int Tech_skill_limit
        {
            get { return tech_skills_limit; }
            set { tech_skills_limit = value; }
        }
        public int Specific_skill_limit
        {
            get { return specific_skills_limit; }
            set { specific_skills_limit = value; }
        }

        #endregion

        #region // конструктор класса
        public Range_Class()
        {
            
        }
        #endregion

        #region //методы класса
        // Устанавливаем уникальный код для определения ранга персонажа
        public void Set_range_code(int insert_int) { range_code = insert_int; }
        // Получаем универсальный код для определени ранга персонажа
        public int Get_range_code() { return range_code; }
        // Устанавливаем название ранга персонажа
        public void Set_range_name(string insert_text) { range_name = insert_text; Range_name = insert_text; }
        // Получаем название ранга персонажа
        public string Get_range_name() { return range_name; }
        // Устанавливаем бонусы к атрибутам от принятия нового ранга персонажа
        public void Set_range_bonus() { }
        // Снимаем бонусы у атрибутов при отмене текущего ранга персонажа
        public void Reset_range_bonus() { }
        // Устанавливаем описание ранга персонажа
        public void Set_range_descr(string insert_text) { range_description = insert_text; }
        // Получаем описание ранга персонажа
        public string Get_range_descr() { return range_description; }


        #endregion
    }
}
