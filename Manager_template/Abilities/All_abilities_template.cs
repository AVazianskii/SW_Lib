using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Character_creation
{
    public class All_abilities_template
    {
        private string description_base,
                       description_adept,
                       description_master,
                       description,
                       name,
                       img_path,
                       icon_path;

        private int id,
                    cost_base,
                    cost_adept,
                    cost_master;

        private bool exist_base,
                     exist_adept,
                     exist_master;   



        public string Description_base
        {
            get { return description_base; }
            set { description_base = value; }
        }
        public string Description_adept
        {
            get { return description_adept; }
            set { description_adept = value; }
        }
        public string Description_master
        {
            get { return description_master; }
            set { description_master = value; }
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
        public int Cost_base
        {
            get { return cost_base; }
            set { cost_base = value; }
        }
        public int Cost_adept
        {
            get { return cost_adept; }
            set { cost_adept = value; }
        }
        public int Cost_master
        {
            get { return cost_master; }
            set { cost_master = value; }
        }
        public bool IsExist_base
        {
            get { return exist_base; }
            set { exist_base = value; }
        }
        public bool IsExist_adept
        {
            get { return exist_adept; }
            set { exist_adept = value; }
        }
        public bool IsExist_master
        {
            get { return exist_master; }
            set { exist_master = value; }
        }
    }
}
