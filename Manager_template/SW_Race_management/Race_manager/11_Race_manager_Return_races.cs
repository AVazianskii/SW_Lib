using System.Collections.Generic;
using Races_libs;

namespace SW_Character_creation
{
    public partial class Race_manager
    {
        public List<Race_class> Get_Race_list()     {return _Races; }
        public Race_class Get_Empty_race()          { return Empty_Race; }
        public Race_class Get_Human_race()          { return Human; }
        public Race_class Get_Botan_race()          { return Botan; }
        public Race_class Get_Cereanin_race()       { return Cereanin; }
        public Race_class Get_Duro_race()           { return Duro; }
        public Race_class Get_Evok_race()           { return Evok; }
        public Race_class Get_Gamor_race()          { return Gamor; }
        public Race_class Get_Gungan_race()         { return Gungan; }
        public Race_class Get_Keldor_race()         { return Kel_Dor; }
        public Race_class Get_Mon_Kalamari_race()   { return Mon_Kalamari; }
        public Race_class Get_Rodian_race()         { return Rodian; }
        public Race_class Get_Sullu_race()          { return Sullu; }
        public Race_class Get_Trando_race()         { return Trando; }
        public Race_class Get_Tvilek_race()         { return Tvi_lek; }
        public Race_class Get_Wooki_race()          { return Wooki; }
        public Race_class Get_Zabrak_race()         { return Zabrak; }
    }
}
