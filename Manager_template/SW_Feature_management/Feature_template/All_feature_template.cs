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
                     type,
                     exp_cost;

        private sbyte   strength_bonus,
                        agility_bonus,
                        stamina_bonus,
                        quickness_bonus,
                        perception_bonus,
                        intelligence_bonus,
                        charm_bonus,
                        willpower_bonus,
                        karma_bonus,
                        exp_bonus,
                        chosen_cost,
                        scratch_penalty_bonus,
                        light_wound_penalty_bonus,
                        medium_wound_penalty_bonus,
                        tough_wound_penalty_bonus;

        private List<sbyte> cost;
        private List<byte> skill_bonus;

        private string name,
                       description,
                       icon_path,
                       image_path;

        private bool is_chosen,
                     is_enabled,
                     is_force_usered_only,
                     is_usual_usered_only,
                     is_able_to_buy_for_exp,
                     is_bought_for_exp,
                     is_able_to_buy_for_ftr,
                     is_bought_for_ftr,
                     is_chosen_for_race;



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
        public List<sbyte> Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public List <byte> Skill_bonus
        {
            get { return skill_bonus; }
            set { skill_bonus = value; }
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
        public sbyte Chosen_cost
        {
            get { return chosen_cost; }
            set { chosen_cost = value; }
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
        public bool Is_enabled
        {
            get { return is_enabled; }
            set { is_enabled = value; }
        }
        public bool Is_force_usered_only
        {
            get { return is_force_usered_only; }
            set { is_force_usered_only = value; }
        }
        public bool Is_usual_usered_only
        { 
            get { return is_usual_usered_only; }
            set { is_usual_usered_only = value; }
        }
        public sbyte Scratch_penalty_bonus
        {
            get { return scratch_penalty_bonus; }
            set { scratch_penalty_bonus = value; }
        }
        public sbyte Light_wound_penalty_bonus
        {
            get { return light_wound_penalty_bonus; }
            set { light_wound_penalty_bonus = value; }
        }
        public sbyte Medium_wound_penalty_bonus
        {
            get { return medium_wound_penalty_bonus; }
            set { medium_wound_penalty_bonus = value; }
        }
        public sbyte Tough_wound_penalty_bonus
        {
            get { return tough_wound_penalty_bonus; }
            set { tough_wound_penalty_bonus = value; }
        }
        public byte Exp_cost
        {
            get { return exp_cost; }
            set { exp_cost = value; }
        }
        public bool Is_able_to_buy_for_exp
        {
            get { return is_able_to_buy_for_exp; }
            set { is_able_to_buy_for_exp = value; }
        }
        public bool Is_bought_for_exp
        {
            get { return is_bought_for_exp; }
            set { is_bought_for_exp = value; }
        }
        public bool Is_able_to_buy_for_ftr
        {
            get { return is_able_to_buy_for_ftr; }
            set { is_able_to_buy_for_ftr = value; }
        }
        public bool Is_bought_for_ftr
        {
            get { return is_bought_for_ftr; }
            set { is_bought_for_ftr = value; }
        }
        public bool Is_chosen_for_race
        {
            get { return is_chosen_for_race; }
            set { is_chosen_for_race = value; }
        }



        public virtual void Apply_feature_bonus()
        {

        }



        public All_feature_template()
        {
            cost = new List<sbyte>();
            skill_bonus = new List<byte>();
            Is_enabled = true;
            Is_bought_for_exp = false;
            Is_bought_for_ftr = false;
            Is_chosen_for_race = false;
        }

    }
}
