using System;
using System.Collections.Generic;
using System.IO;
using Races_libs;

namespace SW_Character_creation
{
    public partial class Race_manager
    {
        private void Upload_race_pics()
        {
            foreach(Race_class Race in _Races)
            {
                Race.Set_img_path       ($@"{Directory.GetCurrentDirectory()}\Pictures\Races\Images\{Race.Get_race_name()}.jpg");
                Race.Set_small_img_path ($@"{Directory.GetCurrentDirectory()}\Pictures\Races\Icons\{Race.Get_race_name()}.jpg");
            }
        }
    }
}
