using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public partial class Race_manager
    {
        private void Upload_race_age_statuses ()
        {
            foreach(Race_class Race in _Races)
            {
                int index = _Races.IndexOf(Race);
                Race.Set_min_child_age(Race_age_statuses[Race_age_statuses.IndexOf(Child_min_age)][index]);
                Race.Set_max_child_age(Race_age_statuses[Race_age_statuses.IndexOf(Child_max_age)][index]);
                Race.Set_min_teen_age(Race_age_statuses[Race_age_statuses.IndexOf(Teen_min_age)][index]);
                Race.Set_max_teen_age(Race_age_statuses[Race_age_statuses.IndexOf(Teen_max_age)][index]);
                Race.Set_min_adult_age(Race_age_statuses[Race_age_statuses.IndexOf(Adult_min_age)][index]);
                Race.Set_max_adult_age(Race_age_statuses[Race_age_statuses.IndexOf(Adult_max_age)][index]);
                Race.Set_min_middle_age(Race_age_statuses[Race_age_statuses.IndexOf(Middle_min_age)][index]);
                Race.Set_max_middle_age(Race_age_statuses[Race_age_statuses.IndexOf(Middle_max_age)][index]);
                Race.Set_min_old_age(Race_age_statuses[Race_age_statuses.IndexOf(Old_min_age)][index]);
                Race.Set_max_old_age(Race_age_statuses[Race_age_statuses.IndexOf(Old_max_age)][index]);
                Race.Set_min_eldery_age(Race_age_statuses[Race_age_statuses.IndexOf(Eldery_min_age)][index]);
             }
        }
    }
}
