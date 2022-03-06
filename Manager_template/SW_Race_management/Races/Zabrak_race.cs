using SW_Character_creation;

namespace Races_libs
{
    internal sealed class Zabrak_race : Race_class
    {
        #region // переменные класса 
        #endregion
        #region // конструктор класса
        public Zabrak_race() 
        {
            Set_race_name("Забрак");               // Устанавливаем текущее показатель атрибута 
            Set_race_code((int)Race_manager.enum_Races._Zabrak);                       // Устанавливаем идентификатор расы
            Set_img_path(@"D:\STAR WARS Saga\Character_creation\Manager_template\Manager_template\SW_Race_management\Race_pictures\Zabrak.jpg");                       // Устанавливаем путь к картинке расы
            Set_small_img_path(@"D:\STAR WARS Saga\Character_creation\Manager_template\Manager_template\SW_Race_management\Race_small_pictures\Zabrak.jpg");
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)
        #endregion
    }
}
