﻿using SW_Character_creation;

namespace Races_libs
{
    internal sealed class Gungan_race : Race_class
    {
        #region // переменные класса 
        #endregion
        #region // конструктор класса
        public Gungan_race() 
        {
            Set_race_name("Гунган");               // Устанавливаем текущее показатель атрибута 
            Set_race_code((int)Race_manager.enum_Races._Gungan);                       // Устанавливаем идентификатор расы
            Set_img_path(@"D:\STAR WARS Saga\Character_creation\Races_Libs\Races_lib\SW_Races\Pictures\Gungan.jpg");                       // Устанавливаем путь к картинке расы
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)
        #endregion
    }
}
