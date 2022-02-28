using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public partial class Race_manager
    {
        private void Upload_languages_info()
        {
            foreach(Race_class Race in _Races)
            {
                foreach(string race_language in Race_languages_coloumn_name)
                {
                    if (Race.Get_language_1() == race_language)
                    {
                        Race.Set_language_1_lvl(Languages[Race_languages_coloumn_name.IndexOf(race_language)][_Races.IndexOf(Race)]);
                    }
                    if (Race.Get_language_2() == race_language)
                    {
                        Race.Set_language_2_lvl(Languages[Race_languages_coloumn_name.IndexOf(race_language)][_Races.IndexOf(Race)]);
                    }
                    if (Race.Get_language_3() == race_language)
                    {
                        Race.Set_language_3_lvl(Languages[Race_languages_coloumn_name.IndexOf(race_language)][_Races.IndexOf(Race)]);
                    }
                    if (Race.Get_language_4() == race_language)
                    {
                        Race.Set_language_4_lvl(Languages[Race_languages_coloumn_name.IndexOf(race_language)][_Races.IndexOf(Race)]);
                    }
                }
            }
        }
    }
}
