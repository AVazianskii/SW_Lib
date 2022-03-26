using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Races_libs;

namespace SW_Character_creation
{ 
    public partial class Race_manager
    {
        private void Upload_general_info()
        {
            // Устанавливаем конфигурационные поля объектов Рас при помощи прочитанной из базы информации
            foreach(Race_class Race in _Races)
            {
                int index = Race.Get_race_code();    // _Races.IndexOf(Race);
                Race.Set_race_code(Convert.ToInt32( Race_description[00][_Races.IndexOf(Race)]));
                Race.Set_race_name(                 Race_description[01][_Races.IndexOf(Race)]);
                Race.Set_general_description(       Race_description[02][_Races.IndexOf(Race)]);
                Race.Set_personal_properties(       Race_description[03][_Races.IndexOf(Race)]);
                Race.Set_physical_properties(       Race_description[04][_Races.IndexOf(Race)]);
                Race.Set_home_world(                Race_description[05][_Races.IndexOf(Race)]);
                Race.Set_language_1(                Race_description[06][_Races.IndexOf(Race)]);
                Race.Set_language_2(                Race_description[07][_Races.IndexOf(Race)]);
                Race.Set_language_3(                Race_description[08][_Races.IndexOf(Race)]);
                Race.Set_language_4(                Race_description[09][_Races.IndexOf(Race)]);
                Race.Set_feature_1(                 Race_description[10][_Races.IndexOf(Race)]);
                Race.Set_feature_2(                 Race_description[11][_Races.IndexOf(Race)]);
                Race.Set_feature_3(                 Race_description[12][_Races.IndexOf(Race)]);
                Race.Set_feature_4(                 Race_description[13][_Races.IndexOf(Race)]);
                Race.Set_feature_5(                 Race_description[14][_Races.IndexOf(Race)]);
                Race.Set_feature_6(                 Race_description[15][_Races.IndexOf(Race)]);
                Race.Set_feature_7(                 Race_description[16][_Races.IndexOf(Race)]);
            }
        }
    }
}
