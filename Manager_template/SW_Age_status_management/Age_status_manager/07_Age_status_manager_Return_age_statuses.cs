using System.Collections.Generic;
using Age_status_libs;

namespace SW_Character_creation
{
    public partial class Age_status_manager
    {
        public List<Age_status_class> Age_Statuses ()
        {
            return Age_statuses;
        }
        public Unknown_age_status Get_Unknown_age_status()
        {
            return Unknown_age;
        }
        public Child_age Get_Child_age_status()
        {
            return Child;
        }
        public Teen_age Get_Teen_age_status()
        {
            return Teen;
        }
        public Adult_age Get_Adult_age_status()
        {
            return Adult;
        }
        public Middle_age Get_Middle_age_status()
        {
            return Middle;
        }
        public Old_age Get_Old_age_status()
        {
            return Old;
        }
        public Eldery_age Get_Eldery_age_status()
        {
            return Eldery;
        }
    }
}
