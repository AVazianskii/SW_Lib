using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_creation
{
    public class All_abilities_template
    {
        private string general_description,
                       description,
                       name,
                       img_path,
                       icon_path;

        private int id,
                    cost;



        public string General_description
        {
            get { return general_description; }
            set { general_description = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Img_path
        {
            get { return img_path; }
            set { img_path = value; }
        }
        public string Icon_path
        {
            get { return icon_path; }
            set { icon_path = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
