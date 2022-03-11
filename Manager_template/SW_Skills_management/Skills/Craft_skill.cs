using SW_Character_creation;

namespace Skills_libs
{
    internal sealed class Сraft_skill : Skill_Class
    {
        #region // конструктор класса
        public Сraft_skill() // определяем конструктор класса, используя конструктор базового класса
        {
            Set_cost(1);                        // Устанавиваем стоимость умения за очки опыта
            Set_score(0);                       // Устанавливаем текущее показатель умения 
            Set_counter(0);                     // Устанавливаем счетчик прокачки умения за очки опыта
            //Set_skill_code((int)Skill_manager.enum_Skills.Craft_skill); // устанавливаем уникальный код навыка
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного умения (если они есть)
        // должно появляться поле, в котором игрок указывает ремесло, в котором он силен
        #endregion
    }
}
