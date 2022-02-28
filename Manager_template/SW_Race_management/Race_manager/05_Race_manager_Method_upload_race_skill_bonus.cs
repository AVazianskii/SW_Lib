using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public partial class Race_manager
    {
        private void Upload_race_skill_bonus()
        {
            foreach(Race_class Race in _Races)
            {
                int index = _Races.IndexOf(Race);
                Race.Set_swimming_bonus             (Race_skills_bonus[Race_skills_bonus.IndexOf(Swimming_bonus)]               [index]);
                Race.Set_heavy_athletics_bonus      (Race_skills_bonus[Race_skills_bonus.IndexOf(Heavy_athletics_bonus)]        [index]);
                Race.Set_climbing_bonus             (Race_skills_bonus[Race_skills_bonus.IndexOf(Climbing_bonus)]               [index]);
                Race.Set_light_athletics_bonus      (Race_skills_bonus[Race_skills_bonus.IndexOf(Light_athletics_bonus)]        [index]);
                Race.Set_sleight_of_hand_bonus      (Race_skills_bonus[Race_skills_bonus.IndexOf(Sleight_of_hand_bonus)]        [index]);
                Race.Set_stealthiness_bonus         (Race_skills_bonus[Race_skills_bonus.IndexOf(Stealthiness_bonus)]           [index]);
                Race.Set_acrobatics_bonus           (Race_skills_bonus[Race_skills_bonus.IndexOf(Acrobatics_bonus)]             [index]);
                Race.Set_horse_riding_bonus         (Race_skills_bonus[Race_skills_bonus.IndexOf(Horse_riding_bonus)]           [index]);
                Race.Set_light_saber_fighting_bonus (Race_skills_bonus[Race_skills_bonus.IndexOf(Light_saber_fighting_bonus)]   [index]);
                Race.Set_hand_combat_bonus          (Race_skills_bonus[Race_skills_bonus.IndexOf(Hand_combat_bonus)]            [index]);
                Race.Set_usual_saber_fighting_bonus (Race_skills_bonus[Race_skills_bonus.IndexOf(Usual_saber_fighting_bonus)]   [index]);
                Race.Set_evasion_bonus              (Race_skills_bonus[Race_skills_bonus.IndexOf(Evasion_bonus)]                [index]);
                Race.Set_throwing_bonus             (Race_skills_bonus[Race_skills_bonus.IndexOf(Throwing_bonus)]               [index]);
                Race.Set_lips_reading_bonus         (Race_skills_bonus[Race_skills_bonus.IndexOf(Lips_reading_bonus)]           [index]);
                Race.Set_old_weapon_bonus           (Race_skills_bonus[Race_skills_bonus.IndexOf(Old_weapon_bonus)]             [index]);
                Race.Set_light_weapon_bonus         (Race_skills_bonus[Race_skills_bonus.IndexOf(Light_weapon_bonus)]           [index]);
                Race.Set_heavy_weapon_bonus         (Race_skills_bonus[Race_skills_bonus.IndexOf(Heavy_weapon_bonus)]           [index]);
                Race.Set_sniper_weapon_bonus        (Race_skills_bonus[Race_skills_bonus.IndexOf(Sniper_weapon_bonus)]          [index]);
                Race.Set_musicality_bonus           (Race_skills_bonus[Race_skills_bonus.IndexOf(Musicality_bonus)]             [index]);
                Race.Set_riding_bonus               (Race_skills_bonus[Race_skills_bonus.IndexOf(Riding_bonus)]                 [index]);
                Race.Set_resisting_bonus            (Race_skills_bonus[Race_skills_bonus.IndexOf(Resisting_bonus)]              [index]);
                Race.Set_strength_of_mind_bonus     (Race_skills_bonus[Race_skills_bonus.IndexOf(Strength_of_mind_bonus)]       [index]);
                Race.Set_watchfulness_bonus         (Race_skills_bonus[Race_skills_bonus.IndexOf(Watchfulness_bonus)]           [index]);
                Race.Set_pilot_bonus                (Race_skills_bonus[Race_skills_bonus.IndexOf(Pilot_bonus)]                  [index]);
                Race.Set_programming_bonus          (Race_skills_bonus[Race_skills_bonus.IndexOf(Programming_bonus)]            [index]);
                Race.Set_surviving_bonus            (Race_skills_bonus[Race_skills_bonus.IndexOf(Surviving_bonus)]              [index]);
                Race.Set_reapair_bonus              (Race_skills_bonus[Race_skills_bonus.IndexOf(Reapair_bonus)]                [index]);
                Race.Set_training_bonus             (Race_skills_bonus[Race_skills_bonus.IndexOf(Training_bonus)]               [index]);
                Race.Set_medicine_crafting_bonus    (Race_skills_bonus[Race_skills_bonus.IndexOf(Medicine_crafting_bonus)]      [index]);
                Race.Set_science_bonus              (Race_skills_bonus[Race_skills_bonus.IndexOf(Science_bonus)]                [index]);
                Race.Set_engineering_bonus          (Race_skills_bonus[Race_skills_bonus.IndexOf(Engineering_bonus)]            [index]);
                Race.Set_star_wars_tactic_bonus     (Race_skills_bonus[Race_skills_bonus.IndexOf(Star_wars_tactic_bonus)]       [index]);
                Race.Set_crafting_bonus             (Race_skills_bonus[Race_skills_bonus.IndexOf(Crafting_bonus)]               [index]);
                Race.Set_trading_bonus              (Race_skills_bonus[Race_skills_bonus.IndexOf(Trading_bonus)]                [index]);
                Race.Set_astronavigation_bonus      (Race_skills_bonus[Race_skills_bonus.IndexOf(Astronavigation_bonus)]        [index]);
                Race.Set_change_looking_bonus       (Race_skills_bonus[Race_skills_bonus.IndexOf(Change_looking_bonus)]         [index]);
                Race.Set_light_saber_crafting_bonus (Race_skills_bonus[Race_skills_bonus.IndexOf(Light_saber_crafting_bonus)]   [index]);
                Race.Set_exploding_bonus            (Race_skills_bonus[Race_skills_bonus.IndexOf(Exploding_bonus)]              [index]);
                Race.Set_security_bonus             (Race_skills_bonus[Race_skills_bonus.IndexOf(Security_bonus)]               [index]);
                Race.Set_medicine_bonus             (Race_skills_bonus[Race_skills_bonus.IndexOf(Medicine_bonus)]               [index]);
                Race.Set_language_bonus             (Race_skills_bonus[Race_skills_bonus.IndexOf(Language_bonus)]               [index]);
                Race.Set_knowledge_bonus            (Race_skills_bonus[Race_skills_bonus.IndexOf(Knowledge_bonus)]              [index]);
                Race.Set_dancing_bonus              (Race_skills_bonus[Race_skills_bonus.IndexOf(Dancing_bonus)]                [index]);
                Race.Set_interrogation_bonus        (Race_skills_bonus[Race_skills_bonus.IndexOf(Interrogation_bonus)]          [index]);
                Race.Set_diplomacy_bonus            (Race_skills_bonus[Race_skills_bonus.IndexOf(Diplomacy_bonus)]              [index]);
                Race.Set_leadership_bonus           (Race_skills_bonus[Race_skills_bonus.IndexOf(Leadership_bonus)]             [index]);
                Race.Set_singing_bonus              (Race_skills_bonus[Race_skills_bonus.IndexOf(Singing_bonus)]                [index]);
                Race.Set_deception_bonus            (Race_skills_bonus[Race_skills_bonus.IndexOf(Deception_bonus)]              [index]);
                Race.Set_insight_bonus              (Race_skills_bonus[Race_skills_bonus.IndexOf(Insight_bonus)]                [index]);
                Race.Set_seduction_bonus            (Race_skills_bonus[Race_skills_bonus.IndexOf(Seduction_bonus)]              [index]);
            }
        }
    }
}
