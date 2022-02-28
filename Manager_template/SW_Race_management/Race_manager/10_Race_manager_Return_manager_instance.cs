using Races_libs;

namespace SW_Character_creation
{
    public partial class Race_manager
    {
        public static Race_manager GetInstance()
        {
            if (Race_manager_instance == null)
            {
                Race_manager_instance = new Race_manager();
            }
            return Race_manager_instance;
        }
    }
}
