using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_libs
{
    public class Veteran_range : Range_Class
    {
        #region // переменные класса 
        #endregion
        public Veteran_range()
        {
            //Set_range_code((int)SW_Character.enum_Range.Veteran);       // Устанваливаем код для определения ранга персонажа
            Set_range_name("Ветеран");                                  // Устанавливаем название ранга персонажа
            //Set_range_descr("");                                        // Устанавливаем описание текущего ранга

            Set_path_read_description("");          // Путь к файлу для вычитывания текстового описания ранга
        }
    }
}
