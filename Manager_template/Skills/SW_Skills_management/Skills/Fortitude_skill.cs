using SW_Character_creation;

namespace Skills_libs
{
    internal sealed class Fortitude_skill : Skill_Class
    {
        #region // конструктор класса
        public Fortitude_skill()// определяем конструктор класса, используя конструктор базового класса
        {
            Set_cost(1);                        // Устанавиваем стоимость умения за очки опыта
            Set_score(0);                       // Устанавливаем текущее показатель умения 
            Set_counter(0);                     // Устанавливаем счетчик прокачки умения за очки опыта
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного умения (если они есть)

        #endregion
    }
}
