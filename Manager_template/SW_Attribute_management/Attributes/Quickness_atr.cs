using SW_Character_creation;

namespace Attribute_libs
{
    internal sealed class Quickness_atr : Atribute_class
    {
        #region // конструктор класса
        internal Quickness_atr() // определяем конструктор класса, используя конструктор базового класса
        {
            Set_atr_score(0);                       // Устанавливаем текущее показатель атрибута 
            Set_atribute_code((int)Attribute_manager.enum_Atributes.Quicness);    // Устанавливаем код текущего атрибута
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)

        #endregion
    }
}
