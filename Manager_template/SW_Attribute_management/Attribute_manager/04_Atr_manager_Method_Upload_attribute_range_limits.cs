using System;
using System.Collections.Generic;

namespace Attribute_libs
{
    public partial class Attribute_manager
    {
        private void Upload_attribute_range_limits()
        {
            foreach(Atribute_class Attribute in _Attributes)
            {
                int index = _Attributes.IndexOf(Attribute);
                Attribute.Set_private_range_attribute_limit (Attribute_range_limits[Attribute_range_limits.IndexOf(Attribute_private_limit) ][index]);
                Attribute.Set_veteran_range_attribute_limit (Attribute_range_limits[Attribute_range_limits.IndexOf(Attribute_veteran_limit) ][index]);
                Attribute.Set_hero_range_attribute_limit    (Attribute_range_limits[Attribute_range_limits.IndexOf(Attribute_hero_limit)    ][index]);
                Attribute.Set_epic_range_attribute_limit    (Attribute_range_limits[Attribute_range_limits.IndexOf(Attribute_epic_limit)    ][index]);
                Attribute.Set_immortal_range_attribute_limit(Attribute_range_limits[Attribute_range_limits.IndexOf(Attribute_immortal_limit)][index]);
            }
        }
    }
}
