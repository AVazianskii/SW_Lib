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
        private sbyte   strength_bonus,
                        agility_bonus,
                        stamina_bonus,
                        quickness_bonus,
                        perception_bonus,
                        intelligence_bonus,
                        charm_bonus,
                        willpower_bonus,
                        karma_bonus,
                        exp_bonus;

        private sbyte[] cost;

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
        public sbyte[] Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public sbyte Strength_bonus
        {
            get { return strength_bonus; }
            set { strength_bonus = value; }
        }
        public sbyte Agility_bonus
        {
            get { return agility_bonus; }
            set { agility_bonus = value; }
        }
        public sbyte Stamina_bonus
        {
            get { return stamina_bonus; }
            set { stamina_bonus = value; }
        }
        public sbyte Quickness_bonus
        {
            get { return quickness_bonus; }
            set { quickness_bonus = value; }
        }
        public sbyte Perception_bonus
        {
            get { return perception_bonus; }
            set { perception_bonus = value; }
        }
        public sbyte Intelligence_bonus
        {
            get { return intelligence_bonus; }
            set { intelligence_bonus = value; }
        }
        public sbyte Charm_bonus
        {
            get { return charm_bonus; }
            set { charm_bonus = value; }
        }
        public sbyte Willpower_bonus
        {
            get { return willpower_bonus; }
            set { willpower_bonus = value; }
        }
        public sbyte Karma_bonus
        {
            get { return karma_bonus; }
            set { karma_bonus = value; }
        }
        public sbyte Exp_bonus
        {
            get { return exp_bonus; }
            set { exp_bonus = value; }
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
            cost = new sbyte [10];
        }

    }
}
