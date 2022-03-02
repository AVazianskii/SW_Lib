using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_Class
{
    public class Teen_age : Age_status_class
    {
        #region // Переменные класса
        SW_Character _SW_Char;
        #endregion

        #region // Конструктор класса
        public Teen_age(SW_Character SW_Char) : base(SW_Char)
        {
            _SW_Char = SW_Char;
            Set_age_status_code((int)SW_Character.enum_Age_status.Teen);
            Set_age_status_name("Подросток");
            Set_age_status_descr("");

            Set_age_status_strength_bonus(0);
            Set_age_status_agility_bonus(0);
            Set_age_status_stamina_bonus(0);
            Set_age_status_quickness_bonus(0);
            Set_age_status_perception_bonus(0);
            Set_age_status_intelligence_bonus(0);
            Set_age_status_charm_bonus(0);
            Set_age_status_willpower_bonus(0);
        }
        #endregion

        #region // Методы класса

        #endregion
    }
}
