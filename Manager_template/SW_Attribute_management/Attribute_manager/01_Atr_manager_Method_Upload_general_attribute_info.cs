using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_libs
{
    public partial class Attribute_manager
    {
        private void Upload_general_attribute_info()
        {
            foreach (Atribute_class Attribute in _Attributes)
            {
                int index = _Attributes.IndexOf(Attribute);
                Attribute.Set_description(Attributes_description[Attributes_description.IndexOf(Attribute_general_description)][index]);
            }
        }
    }
}
