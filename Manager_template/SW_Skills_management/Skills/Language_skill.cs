using SW_Character_creation;

namespace Skills_libs
{
    internal sealed class Language_skill : Skill_Class
    {
        #region // конструктор класса
        public Language_skill()
        {
            Set_cost(1);                        // Устанавиваем стоимость умения за очки опыта
            Set_score(0);                       // Устанавливаем текущее показатель умения 
            Set_counter(0);                     // Устанавливаем счетчик прокачки умения за очки опыта
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного умения (если они есть)
        // Здесь появляется окно для указания , каким языком обладает персонаж
        #endregion
    }
}
