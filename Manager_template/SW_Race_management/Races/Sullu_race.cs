using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public class Sullu_race : Race_class
    {
        #region // переменные класса 
        #endregion
        #region // конструктор класса
        public Sullu_race()
        {
            Set_race_name("Суллустианец");          // Устанавливаем текущее показатель атрибута 
            Set_race_code((int)Race_manager.enum_Races._Sullu);                       // Устанавливаем идентификатор расы
            Set_img_path(@"D:\STAR WARS Saga\Character_creation\Races_Libs\Races_lib\SW_Races\Pictures\Sullu.jpg");                       // Устанавливаем путь к картинке расы
            
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)
        #endregion
    }
}
