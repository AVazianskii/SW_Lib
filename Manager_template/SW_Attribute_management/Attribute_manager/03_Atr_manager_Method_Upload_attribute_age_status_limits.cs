using System;
using System.Collections.Generic;

namespace Attribute_libs
{
    public partial class Attribute_manager
    {
        private void Upload_attribute_age_status_limits()
        {
            foreach(Atribute_class Attribute in _Attributes)
            {
                int index = _Attributes.IndexOf(Attribute);
                Attribute.Set_unknown_age_attribute_limit   (Attribute_age_status_limits[Attribute_age_status_limits.IndexOf(Attribute_unknown_age_limit)][index]);
                Attribute.Set_child_attribute_limit         (Attribute_age_status_limits[Attribute_age_status_limits.IndexOf(Attribute_child_limit)      ][index]);
                Attribute.Set_teen_attribute_limit          (Attribute_age_status_limits[Attribute_age_status_limits.IndexOf(Attribute_teen_limit)       ][index]);
                Attribute.Set_adult_attribute_limit         (Attribute_age_status_limits[Attribute_age_status_limits.IndexOf(Attribute_adult_limit)      ][index]);
                Attribute.Set_middle_attribute_limit        (Attribute_age_status_limits[Attribute_age_status_limits.IndexOf(Attribute_middle_limit)     ][index]);
                Attribute.Set_old_attribute_limit           (Attribute_age_status_limits[Attribute_age_status_limits.IndexOf(Attribute_old_limit)        ][index]);
                Attribute.Set_eldery_attribute_limit        (Attribute_age_status_limits[Attribute_age_status_limits.IndexOf(Attribute_eldery_limit)     ][index]);
            }
        }
    }
}
