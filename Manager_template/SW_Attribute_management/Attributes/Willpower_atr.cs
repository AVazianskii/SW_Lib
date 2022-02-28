

namespace Attribute_libs
{
    public class Willpower_atr : Atribute_class
    {
        #region // конструктор класса
        public Willpower_atr()  // определяем конструктор класса, используя конструктор базового класса
        {
            Set_atr_score(0);                       // Устанавливаем текущее показатель атрибута 
            Set_atribute_code((int)Attribute_manager.enum_Atributes.Willpower);    // Устанавливаем код текущего атрибута
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)

        #endregion
    }
}
