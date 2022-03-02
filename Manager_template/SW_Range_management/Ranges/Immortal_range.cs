using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_Class
{
    public class Immortal_range : Range_Class
    {
        #region // переменные класса 
        private SW_Character _SW_Char;
        #endregion
        public Immortal_range(SW_Character SW_Char) : base(SW_Char)
        {
            _SW_Char = SW_Char;
            Set_range_code((int)SW_Character.enum_Range.Immortal);      // Устанваливаем код для определения ранга персонажа
            Set_range_name("Бессмертный");                              // Устанавливаем название ранга персонажа
            // Set_range_descr("");                                        // Устанавливаем описание текущего ранга

            Set_path_read_description("");          // Путь к файлу для вычитывания текстового описания ранга
        }
        public void Set_range_bonus()
        {
            foreach (Atribute_class atribute in _SW_Char._Atributes)
            {
                switch (atribute.Get_atribute_code())
                {
                    case (int)SW_Character.enum_Atributes.Strength:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Agility:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Stamina:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Quicness:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Perception:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Intelligence:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Charm:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Willpower:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                }
            }
        }
        public void Reset_range_bonus()
        {
            foreach (Atribute_class atribute in _SW_Char._Atributes)
            {
                switch (atribute.Get_atribute_code())
                {
                    case (int)SW_Character.enum_Atributes.Strength:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Agility:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Stamina:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Quicness:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Perception:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Intelligence:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Charm:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                    case (int)SW_Character.enum_Atributes.Willpower:
                        atribute.Increase_atr(0);
                        atribute.Decrease_atr(0);
                        break;
                }
            }
        }
    }
}
