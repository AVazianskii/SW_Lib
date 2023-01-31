using Attribute_libs;

namespace SW_Character_creation
{
    public partial class Attribute_manager
    {
        public static Attribute_manager GetInstance()
        {
            if (Attribute_manager_instance == null)
            {
                Attribute_manager_instance = new Attribute_manager();
            }
            return Attribute_manager_instance;
        }
        public static void DeleteInstance()
        {
            if (Attribute_manager_instance != null)
            {
                Attribute_manager_instance = null;
            }
        }
    }
}
