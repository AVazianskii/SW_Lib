namespace Attribute_libs
{
    public class Agility_atr :Atribute_class
    {
        #region // конструктор класса
        public Agility_atr() // определяем конструктор класса, используя конструктор базового класса
        {
            Set_atr_score(0);                       // Устанавливаем текущее показатель атрибута 
            Set_atribute_code((int)Attribute_manager.enum_Atributes.Agility);    // Устанавливаем код текущего атрибута

        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)

        #endregion
    }
}
