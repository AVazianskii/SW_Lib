using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{ 
    public partial class Race_manager
    {
        private void Upload_general_info()
        {
            // Устанавливаем конфигурационные поля объектов Рас при помощи прочитанной из базы информации
            foreach(Race_class Race in _Races)
            {
                int index = Race.Get_race_code();    // _Races.IndexOf(Race);
                Race.Set_general_description(General_description[index]);
                Race.Set_personal_properties(Personal_properties[index]);
                Race.Set_physical_properties(Physical_properties[index]);
                Race.Set_home_world(Home_world[index]);
                Race.Set_language_1(Language_1[index]);
                Race.Set_language_2(Language_2[index]);
                Race.Set_language_3(Language_3[index]);
                Race.Set_language_4(Language_4[index]);
                Race.Set_feature_1(Feature_1[index]);
                Race.Set_feature_2(Feature_2[index]);
                Race.Set_feature_3(Feature_3[index]);
                Race.Set_feature_4(Feature_4[index]);
                Race.Set_feature_5(Feature_5[index]);
                Race.Set_feature_6(Feature_6[index]);
            }
        }
    }
}
