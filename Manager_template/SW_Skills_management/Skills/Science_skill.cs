using SW_Character_creation;

namespace Skills_libs
{
    internal sealed class Science_skill : Skill_Class
    {
        #region // конструктор класса
        public Science_skill()
        {
            Set_cost(1);                        // Устанавиваем стоимость умения за очки опыта
            Set_score(0);                       // Устанавливаем текущее показатель умения 
            Set_counter(0);                     // Устанавливаем счетчик прокачки умения за очки опыта
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного умения (если они есть)
        // должно выводиться поле, чтобы игрок ввел название науки, в которой он силен
        #endregion
    }
}
