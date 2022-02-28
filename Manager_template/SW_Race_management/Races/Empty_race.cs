using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public class Empty_race: Race_class
    {
        #region // переменные класса 
        #endregion
        #region // конструктор класса
        public Empty_race()
        {
            Set_race_name("");                      // Устанавливаем текущее показатель атрибута 
            Set_race_code((int)Race_manager.enum_Races._Empty_race);                       // Устанавливаем идентификатор расы
            Set_img_path("");                       // Устанавливаем путь к картинке расы
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)
        #endregion
    }
}
