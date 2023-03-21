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
        public Age_status_class Get_Unknown_age_status() { return Unknown_age; }
        public Age_status_class Get_Child_age_status() { return Child; }
        public Age_status_class Get_Teen_age_status() { return Teen; }
        public Age_status_class Get_Adult_age_status() { return Adult; }
        public Age_status_class Get_Middle_age_status() { return Middle; }
        public Age_status_class Get_Old_age_status() { return Old; }
        public Age_status_class Get_Eldery_age_status() { return Eldery; }
    }
}
