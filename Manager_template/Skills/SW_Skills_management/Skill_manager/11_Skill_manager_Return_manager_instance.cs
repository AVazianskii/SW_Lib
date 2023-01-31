namespace SW_Character_creation
{
    public partial class Skill_manager
    {
        public static Skill_manager GetInstance()
        {
            if (Skill_manager_instance == null)
            {
                Skill_manager_instance = new Skill_manager();
            }
            return Skill_manager_instance;
        }
        public static void DeleteInstance()
        {
            if (Skill_manager_instance != null)
            {
                Skill_manager_instance = null;
            }
        }
    }
}
