using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attribute_libs;

namespace SW_Character_creation
{
    public partial class Attribute_manager
    {
        private void Upload_general_attribute_info()
        {
            foreach (Atribute_class Attribute in _Attributes)
            {
                int index = _Attributes.IndexOf(Attribute);
                Attribute.Set_atribute_code(Convert.ToInt32(Attributes_description[0][index]));
                Attribute.Atr_name = Attributes_description[1][index];
                Attribute.Set_description(Attributes_description[Attributes_description.IndexOf(Attribute_general_description)][index]);
            }
        }
    }
}
