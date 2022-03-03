using Skills_libs;

namespace SW_Character_creation
{
    public partial class Skill_manager
    {
        public override void Run_download_and_upload_process()
        {
            SQLite_connection.Open();


            SQLite_connection.Close();
        }
    }
}
