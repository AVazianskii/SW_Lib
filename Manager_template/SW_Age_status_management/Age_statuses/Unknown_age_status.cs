using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_status_libs
{
    public class Unknown_age_status : Age_status_class
    {
        #region // Переменные класса
        
        #endregion

        #region // Конструктор класса
        public Unknown_age_status()
        {
            
            //Set_age_status_code((int)SW_Character.enum_Age_status.Unknown);
            Set_age_status_name("Неизвестно");
            Set_age_status_descr("");

            //Set_age_status_strength_bonus(0);
            //Set_age_status_agility_bonus(0);
            //Set_age_status_stamina_bonus(0);
            //Set_age_status_quickness_bonus(0);
            //Set_age_status_perception_bonus(0);
            //Set_age_status_intelligence_bonus(0);
            //Set_age_status_charm_bonus(0);
            //Set_age_status_willpower_bonus(0);
        }
        #endregion

        #region // Методы класса

        #endregion

    }
}
