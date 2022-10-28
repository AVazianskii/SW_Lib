using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_creation
{
    public class All_feature_template
    {
        private byte id,
                     type;
        private sbyte cost;

        private string name,
                       description,
                       icon_path,
                       image_path;

        private bool is_chosen;



        public byte ID
        {
            get { return id; }
            set { id = value; }
        }
        public byte Type
        {
            get { return type; }
            set { type = value; }
        }
        public sbyte Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Icon_path
        {
            get { return icon_path; }
            set { icon_path = value; }
        }
        public string Image_path
        {
            get { return image_path; }
            set { image_path = value; }
        }
        public bool Is_chosen
        {
            get { return is_chosen; }
            set { is_chosen = value; }
        }



        public virtual void Apply_feature_bonus()
        {

        }



        public All_feature_template()
        {

        }

    }
}
