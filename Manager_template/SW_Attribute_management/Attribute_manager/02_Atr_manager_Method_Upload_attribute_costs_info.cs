using System;
using System.Collections.Generic;

namespace Attribute_libs
{
    public partial class Attribute_manager
    {
        private void Upload_attribute_costs_info()
        {
            foreach(Atribute_class Attribute in _Attributes)
            {
                int index = _Attributes.IndexOf(Attribute);
                Attribute.Set_attribute_cost_for_atr(Attribute_costs[Attribute_costs.IndexOf(Attribute_cost_atr)][index]);
                Attribute.Set_attribute_cost_for_exp(Attribute_costs[Attribute_costs.IndexOf(Attribute_cost_exp)][index]);
            }
        }
    }
}
