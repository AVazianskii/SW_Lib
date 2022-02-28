using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SW_Character_creation
{
    internal interface IManager
    {
        void Run_download_from_SQLite(string SQLite_Command_text,
                                      SQLiteConnection SQLite_connection,
                                      List<string> Names_of_coloumns,
                                      object List_for_reading_data,
                                      int reading_data_type);
    }
}
