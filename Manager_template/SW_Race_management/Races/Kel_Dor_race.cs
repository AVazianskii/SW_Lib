using SW_Character_creation;

namespace Races_libs
{
    internal sealed class Kel_Dor_race : Race_class
    {
        #region // переменные класса 
        #endregion
        #region // конструктор класса
        public Kel_Dor_race() 
        {
            Set_race_name("Кель Дор");               // Устанавливаем текущее показатель атрибута 
            Set_race_code((int)Race_manager.enum_Races._Kel_dor);                       // Устанавливаем идентификатор расы
            Set_img_path(@"D:\STAR WARS Saga\Character_creation\Races_Libs\Races_lib\SW_Races\Pictures\Keldor.jpg");                       // Устанавливаем путь к картинке расы
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)
        #endregion
    }
}
