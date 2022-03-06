using SW_Character_creation;

namespace Races_libs
{
    internal sealed class Sullu_race : Race_class
    {
        #region // переменные класса 
        #endregion
        #region // конструктор класса
        public Sullu_race()
        {
            Set_race_name("Суллустианец");          // Устанавливаем текущее показатель атрибута 
            Set_race_code((int)Race_manager.enum_Races._Sullu);                       // Устанавливаем идентификатор расы
            Set_img_path(@"D:\STAR WARS Saga\Character_creation\Races_Libs\Races_lib\SW_Races\Pictures\Sullu.jpg");                       // Устанавливаем путь к картинке расы
            Set_small_img_path(@"D:\STAR WARS Saga\Character_creation\Manager_template\Manager_template\SW_Race_management\Race_small_pictures\Botan.jpg");
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)
        #endregion
    }
}
