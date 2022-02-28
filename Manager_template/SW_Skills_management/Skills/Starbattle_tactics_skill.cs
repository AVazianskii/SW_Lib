using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills_libs
{
    public class Starbattle_tactics_skill : Skill_Class
    {
        #region // конструктор класса
        public Starbattle_tactics_skill()
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
