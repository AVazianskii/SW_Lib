using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SW_Character_creation
{
    public class Feature_manager : Abstract_manager
    {
        private static Feature_manager feature_instance;


        public static Feature_manager GetInstance()
        {
            if (feature_instance == null)
            {
                feature_instance = new Feature_manager();
            }
            return feature_instance;
        }



        private Feature_manager()
        {

        }
    }
}
