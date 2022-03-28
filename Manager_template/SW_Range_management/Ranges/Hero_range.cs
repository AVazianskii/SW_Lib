using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_libs
{
    public class Hero_range : Range_Class
    {
        #region // переменные класса 
        #endregion
        public Hero_range() 
        {
            
            //Set_range_code((int)SW_Character.enum_Range.Hero);       // Устанваливаем код для определения ранга персонажа
            // Set_range_name("Герой");                                 // Устанавливаем название ранга персонажа
            Set_range_descr("");                                        // Устанавливаем описание текущего ранга

        }
    }
}
