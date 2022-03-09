using SW_Character_creation;

namespace Races_libs
{
    internal sealed class Botan_race : Race_class
    {
        #region // переменные класса 
        #endregion
        #region // конструктор класса
        public Botan_race()
        {

            Set_race_name("Ботан");                  // Устанавливаем текущее показатель атрибута 
            Set_race_code((int)Race_manager.enum_Races._Botan);                       // Устанавливаем идентификатор расы
            Set_img_path(@"D:\STAR WARS Saga\Character_creation\Manager_template\Manager_template\SW_Race_management\Race_pictures\Botan.jpg");                       // Устанавливаем путь к картинке расы
            Set_small_img_path(@"D:\STAR WARS Saga\Character_creation\Manager_template\Manager_template\SW_Race_management\Race_small_pictures\Botan.jpg");
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)
        #endregion
    }
}

