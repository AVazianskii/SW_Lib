using SW_Character_creation;

namespace Races_libs
{
    internal sealed class Duro_race : Race_class
    {
        #region // переменные класса 
        #endregion
        #region // конструктор класса
        public Duro_race() 
        {
            Set_race_name("Дуро");               // Устанавливаем текущее показатель атрибута 
            Set_race_code((int)Race_manager.enum_Races._Duro);                       // Устанавливаем идентификатор расы
            Set_img_path(@"D:\STAR WARS Saga\Character_creation\Manager_template\Manager_template\SW_Race_management\Race_pictures\Duro.jpg");                       // Устанавливаем путь к картинке 
            Set_small_img_path(@"D:\STAR WARS Saga\Character_creation\Manager_template\Manager_template\SW_Race_management\Race_small_pictures\Duro.jpg");
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)
        #endregion
    }
}
