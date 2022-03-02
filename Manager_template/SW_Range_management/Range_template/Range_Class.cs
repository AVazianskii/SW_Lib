using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_libs
{
    public class Range_Class
    {
        #region // переменные класса
        private int range_code;             // числовой код для определения ранга

        private string range_name;          // задаем название для ранга
        private string range_description;   // описание ранга персонажа
        private string path_read_description; // Путь к файлу для вычитывания текстового описания расы

        
        #endregion

        #region // конструктор класса
        public Range_Class()
        {
            
        }
        #endregion

        #region //методы класса
        // Устанавливаем уникальный код для определения ранга персонажа
        public void Set_range_code(int insert_int) { range_code = insert_int; }
        // Получаем универсальный код для определени ранга персонажа
        public int Get_range_code() { return range_code; }
        // Устанавливаем название ранга персонажа
        public void Set_range_name(string insert_text) { range_name = insert_text; }
        // Получаем название ранга персонажа
        public string Get_range_name() { return range_name; }
        // Устанавливаем бонусы к атрибутам от принятия нового ранга персонажа
        public void Set_range_bonus() { }
        // Снимаем бонусы у атрибутов при отмене текущего ранга персонажа
        public void Reset_range_bonus() { }
        // Устанавливаем описание ранга персонажа
        public void Set_range_descr(string insert_text) { range_description = insert_text; }
        // Получаем описание ранга персонажа
        public string Get_range_descr() { return range_description; }
        // Устанавливаем путь к текстовому файлу с описанием навыка
        public void Set_path_read_description(string input_text) { path_read_description = input_text; }
        // Предоставляем путь к текстовому файлу с описанием навыка
        public string Get_path_read_description() { return path_read_description; }
        #endregion
    }
}
