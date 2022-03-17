using System.Collections.Generic;
using Skills_libs;

namespace SW_Character_creation
{
    public partial class Skill_manager
    {
        public List<Skill_Class> Get_skills() { return _Skills; }
        public List<Skill_Class> Get_Combat_skills() { return _Combat_skills; }
        public List<Skill_Class> Get_Survivng_skills() { return _Survivng_skills; }
        public List<Skill_Class> Get_Charming_skills() { return _Charming_skills; }
        public List<Skill_Class> Get_Tech_skills() { return _Tech_skills; }
        public List<Skill_Class> Get_Specific_skills() { return _Specific_skills; }
        public Skill_Class Get_Swimming() { return _swimming; }

    }
}
