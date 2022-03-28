using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_libs
{
    public class Private_range : Range_Class
    {
        #region // переменные класса 
        #endregion
        public Private_range()
        {
            //Set_range_code((int)SW_Character.enum_Range.Private);       // Устанваливаем код для определения ранга персонажа
            Set_range_name("Рядовой");                                  // Устанавливаем название ранга персонажа
            //Set_range_descr("");                                        // Устанавливаем описание текущего ранга    

        }
    }
}
