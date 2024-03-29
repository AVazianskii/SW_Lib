﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;

namespace SW_Character_creation
{
    public class Force_ability_manager : Abstract_manager
    {
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;

        private List<All_abilities_template> _Force_abilities;

        private List<string> Force_abilities_general_coloumn_name;
        private List<string> Force_abilities_costs_coloumn_name;
        private List<string> Force_abilities_combat_bonuses_coloumn_name;

        private List<List<string>> Force_abilities_general_info;
        private List<List<int>> Force_abilities_costs;
        private List<List<int>> Force_abilities_combat_bonuses;

        private List<string> Force_abilities_ID;
        private List<string> Force_abilities_name;
        private List<string> Force_general_description;
        private List<string> Force_description;

        private Abilities_sequence_template shii_cho,
                                            makashi,
                                            soresu,
                                            ataro,
                                            diem_so,
                                            new_niman,
                                            juyo,
                                            vaapad,
                                            old_niman,
                                            sokan,
                                            shien;
        private All_abilities_template juyo_special_condition;

        private List<Abilities_sequence_template> _Force_sequences;



        public Abilities_sequence_template Shii_cho
        {
            get { return shii_cho; }
            set { shii_cho = value; }
        }
        public Abilities_sequence_template Makashi
        {
            get { return makashi; }
            set { makashi = value; }
        }
        public Abilities_sequence_template Soresu
        {
            get { return soresu; }
            set { soresu = value; }
        }
        public Abilities_sequence_template Ataro
        {
            get { return ataro; }
            set { ataro = value; }
        }
        public Abilities_sequence_template Diem_so
        {
            get { return diem_so; }
            set { diem_so = value; }
        }
        public Abilities_sequence_template New_niman
        {
            get { return new_niman; }
            set { new_niman = value; }
        }
        public Abilities_sequence_template Juyo
        {
            get { return juyo; }
            set { juyo = value; }
        }
        public Abilities_sequence_template Vaapad
        {
            get { return vaapad; }
            set { vaapad = value; }
        }
        public Abilities_sequence_template Old_niman
        {
            get { return old_niman; }
            set { old_niman = value; }
        }
        public Abilities_sequence_template Sokan
        {
            get { return sokan; }
            set { sokan = value; }
        }
        public Abilities_sequence_template Shien
        {
            get { return shien; }
            set { shien = value; }
        }



        public List<All_abilities_template> Get_abilities() { return _Force_abilities; }
        public List<Abilities_sequence_template> Get_sequences() { return _Force_sequences; }



        public override void Run_download_and_upload_process()
        {
            using (SQLite_connection = new SQLiteConnection(SQLite_connection_string))
            {
                SQLite_connection.Open();

                Run_download_general_from_SQLite("SELECT * FROM Force_abilities_general ORDER BY ID",
                                                 SQLite_connection,
                                                 Force_abilities_general_coloumn_name,
                                                 Force_abilities_general_info);

                Run_download_from_SQLite_v2("SELECT * FROM Force_abilities_costs ORDER BY ID",
                                            SQLite_connection,
                                            Force_abilities_costs_coloumn_name,
                                            Force_abilities_costs,
                                            (int)Type_of_var.int_type);

                Run_download_from_SQLite_v2("SELECT * FROM Force_abilities_combat_bonuses ORDER BY ID",
                                            SQLite_connection,
                                            Force_abilities_combat_bonuses_coloumn_name,
                                            Force_abilities_combat_bonuses,
                                            (int)Type_of_var.int_type);

                SQLite_connection.Close();
            }

            int index = 0;

            foreach (var count in Force_abilities_general_info[0])
            {
                // На каждую новую строку создаем новый инстанс
                _Force_abilities.Add(new All_abilities_template());

                // Определяем порядковый нмоер текущего инстанса
                index = Force_abilities_general_info[0].IndexOf(count);

                _Force_abilities[index].ID                  = Convert.ToInt32(  Force_abilities_general_info[0][index]);
                _Force_abilities[index].Name                =                   Force_abilities_general_info[1][index];
                _Force_abilities[index].General_description =                   Force_abilities_general_info[2][index];
                _Force_abilities[index].Description         =                   Force_abilities_general_info[3][index];

                _Force_abilities[index].Cost = Force_abilities_costs[0][index];

                _Force_abilities[index].Reaction_bonus          = Force_abilities_combat_bonuses[0][index];
                _Force_abilities[index].Armor_bonus             = Force_abilities_combat_bonuses[1][index];
                _Force_abilities[index].Force_resistance_bonus  = Force_abilities_combat_bonuses[2][index];
                _Force_abilities[index].Stealthness_bonus       = Force_abilities_combat_bonuses[3][index];
                _Force_abilities[index].Watchfullness_bonus     = Force_abilities_combat_bonuses[4][index];
                _Force_abilities[index].Concentration_bonus     = Force_abilities_combat_bonuses[5][index];

                if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_abilities\\Images\\" + _Force_abilities[index].Name + ".jpg"))
                {
                    _Force_abilities[index].Img_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_abilities\Images\{_Force_abilities[index].Name}.jpg";
                }
                else
                {
                    _Force_abilities[index].Img_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                }

                if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_abilities\\Icons\\" + _Force_abilities[index].Name + ".jpg"))
                {
                    _Force_abilities[index].Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_abilities\Icons\{_Force_abilities[index].Name}.jpg";
                }
                else
                {
                    _Force_abilities[index].Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg";
                }
            }

            Shii_cho.Name = "Шии Чо";
            Shii_cho.Base_ability_lvl   = _Force_abilities[0];
            Shii_cho.Adept_ability_lvl  = _Force_abilities[1];
            Shii_cho.Master_ability_lvl = _Force_abilities[2];

            Shii_cho.Enable_condition_base   = null;
            Shii_cho.Enable_condition_adept  = Shii_cho.Base_ability_lvl;
            Shii_cho.Enable_condition_master = Shii_cho.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + Shii_cho.Name + ".jpg"))
            {
                Shii_cho.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{Shii_cho.Name}.jpg";
            }
            else { Shii_cho.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + Shii_cho.Name + ".jpg"))
            {
                Shii_cho.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{Shii_cho.Name}.jpg";
            }
            else { Shii_cho.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            Shii_cho.Check_enable_state();


            Makashi.Name = "Макаши";
            Makashi.Base_ability_lvl    = _Force_abilities[3];
            Makashi.Adept_ability_lvl   = _Force_abilities[4];
            Makashi.Master_ability_lvl  = _Force_abilities[5];

            Makashi.Enable_condition_base   = null;
            Makashi.Enable_condition_adept  = Makashi.Base_ability_lvl;
            Makashi.Enable_condition_master = Makashi.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + Makashi.Name + ".jpg"))
            {
                Makashi.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{Makashi.Name}.jpg";
            }
            else { Makashi.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + Makashi.Name + ".jpg"))
            {
                Makashi.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{Makashi.Name}.jpg";
            }
            else { Makashi.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            Makashi.Check_enable_state();


            Soresu.Name = "Сорэсу";
            Soresu.Base_ability_lvl     = _Force_abilities[6];
            Soresu.Adept_ability_lvl    = _Force_abilities[7];
            Soresu.Master_ability_lvl   = _Force_abilities[8];

            Soresu.Enable_condition_base    = null;
            Soresu.Enable_condition_adept   = Soresu.Base_ability_lvl;
            Soresu.Enable_condition_master  = Soresu.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + Soresu.Name + ".jpg"))
            {
                Soresu.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{Soresu.Name}.jpg";
            }
            else { Soresu.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + Soresu.Name + ".jpg"))
            {
                Soresu.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{Soresu.Name}.jpg";
            }
            else { Soresu.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            Soresu.Check_enable_state();


            Ataro.Name = "Атаро";
            Ataro.Base_ability_lvl      = _Force_abilities[9];
            Ataro.Adept_ability_lvl     = _Force_abilities[10];
            Ataro.Master_ability_lvl    = _Force_abilities[11];

            Ataro.Enable_condition_base     = null;
            Ataro.Enable_condition_adept    = Ataro.Base_ability_lvl;
            Ataro.Enable_condition_master   = Ataro.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + Ataro.Name + ".jpg"))
            {
                Ataro.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{Ataro.Name}.jpg";
            }
            else { Ataro.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + Ataro.Name + ".jpg"))
            {
                Ataro.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{Ataro.Name}.jpg";
            }
            else { Ataro.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            Ataro.Check_enable_state();


            Diem_so.Name = "Дьем Со";
            Diem_so.Base_ability_lvl    = _Force_abilities[12];
            Diem_so.Adept_ability_lvl   = _Force_abilities[13];
            Diem_so.Master_ability_lvl  = _Force_abilities[14];

            Diem_so.Enable_condition_base   = null;
            Diem_so.Enable_condition_adept  = Diem_so.Base_ability_lvl;
            Diem_so.Enable_condition_master = Diem_so.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + Diem_so.Name + ".jpg"))
            {
                Diem_so.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{Diem_so.Name}.jpg";
            }
            else { Diem_so.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + Diem_so.Name + ".jpg"))
            {
                Diem_so.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{Diem_so.Name}.jpg";
            }
            else { Diem_so.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            Diem_so.Check_enable_state();


            New_niman.Name = "Новый Ниман";
            New_niman.Base_ability_lvl      = _Force_abilities[15];
            New_niman.Adept_ability_lvl     = _Force_abilities[16];
            New_niman.Master_ability_lvl    = _Force_abilities[17];

            New_niman.Enable_condition_base     = null;
            New_niman.Enable_condition_adept    = New_niman.Base_ability_lvl;
            New_niman.Enable_condition_master   = New_niman.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + New_niman.Name + ".jpg"))
            {
                New_niman.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{New_niman.Name}.jpg";
            }
            else { New_niman.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + New_niman.Name + ".jpg"))
            {
                New_niman.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{New_niman.Name}.jpg";
            }
            else { New_niman.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            New_niman.Check_enable_state();


            Juyo.Name = "Джуйо";
            Juyo.Base_ability_lvl   = _Force_abilities[18];
            Juyo.Adept_ability_lvl  = _Force_abilities[19];
            Juyo.Master_ability_lvl = _Force_abilities[20];

            juyo_special_condition.Is_chosen = (Convert.ToInt32(Shii_cho.Master_ability_lvl.Is_chosen   ) +
                                                Convert.ToInt32(Makashi.Master_ability_lvl.Is_chosen    ) +
                                                Convert.ToInt32(Soresu.Master_ability_lvl.Is_chosen     ) +
                                                Convert.ToInt32(Ataro.Master_ability_lvl.Is_chosen      ) +
                                                Convert.ToInt32(Diem_so.Master_ability_lvl.Is_chosen    ) +
                                                Convert.ToInt32(New_niman.Master_ability_lvl.Is_chosen  )) > 2;

            Juyo.Enable_condition_base      = juyo_special_condition;
            Juyo.Enable_condition_adept     = Juyo.Base_ability_lvl;
            Juyo.Enable_condition_master    = Juyo.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + Juyo.Name + ".jpg"))
            {
                Juyo.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{Juyo.Name}.jpg";
            }
            else { Juyo.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + Juyo.Name + ".jpg"))
            {
                Juyo.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{Juyo.Name}.jpg";
            }
            else { Juyo.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            Juyo.Check_enable_state();


            Vaapad.Name = "Ваапад";
            Vaapad.Base_ability_lvl     = null;
            Vaapad.Adept_ability_lvl    = _Force_abilities[21];
            Vaapad.Master_ability_lvl   = _Force_abilities[22];

            Vaapad.Enable_condition_base    = null;
            Vaapad.Enable_condition_adept   = Juyo.Base_ability_lvl;
            Vaapad.Enable_condition_master  = Vaapad.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + Vaapad.Name + ".jpg"))
            {
                Vaapad.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{Vaapad.Name}.jpg";
            }
            else { Vaapad.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + Vaapad.Name + ".jpg"))
            {
                Vaapad.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{Vaapad.Name}.jpg";
            }
            else { Vaapad.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            Vaapad.Check_enable_state();


            Old_niman.Name = "Старый Ниман";
            Old_niman.Base_ability_lvl      = null;
            Old_niman.Adept_ability_lvl     = _Force_abilities[23];
            Old_niman.Master_ability_lvl    = _Force_abilities[24];

            Old_niman.Enable_condition_base     = null;
            Old_niman.Enable_condition_adept    = New_niman.Base_ability_lvl;
            Old_niman.Enable_condition_master   = Old_niman.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + Old_niman.Name + ".jpg"))
            {
                Old_niman.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{Old_niman.Name}.jpg";
            }
            else { Old_niman.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + Old_niman.Name + ".jpg"))
            {
                Old_niman.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{Old_niman.Name}.jpg";
            }
            else { Old_niman.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            Old_niman.Check_enable_state();


            Sokan.Name = "Сокан";
            Sokan.Base_ability_lvl      = null;
            Sokan.Adept_ability_lvl     = _Force_abilities[25];
            Sokan.Master_ability_lvl    = _Force_abilities[26];

            Sokan.Enable_condition_base     = null;
            Sokan.Enable_condition_adept    = Ataro.Base_ability_lvl;
            Sokan.Enable_condition_master   = Sokan.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + Sokan.Name + ".jpg"))
            {
                Sokan.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{Sokan.Name}.jpg";
            }
            else { Sokan.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + Sokan.Name + ".jpg"))
            {
                Sokan.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{Sokan.Name}.jpg";
            }
            else { Sokan.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            Sokan.Check_enable_state();


            Shien.Name = "Шиен";
            Shien.Base_ability_lvl      = null;
            Shien.Adept_ability_lvl     = _Force_abilities[27];
            Shien.Master_ability_lvl    = _Force_abilities[28];

            Shien.Enable_condition_base     = null;
            Shien.Enable_condition_adept    = Diem_so.Base_ability_lvl;
            Shien.Enable_condition_master   = Shien.Adept_ability_lvl;

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Icons\\" + Shien.Name + ".jpg"))
            {
                Shien.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Icons\{Shien.Name}.jpg";
            }
            else { Shien.Icon_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\Pictures\\Force_sequences\\Images\\" + Shien.Name + ".jpg"))
            {
                Shien.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Force_sequences\Images\{Shien.Name}.jpg";
            }
            else { Shien.Image_path = $@"{Directory.GetCurrentDirectory()}\Pictures\Common\picture_is_searching.jpg"; }

            Shien.Check_enable_state();

            // Обнуляем коллекции, в которые считываем из базы
            ClearList(Force_abilities_general_coloumn_name);
            ClearList(Force_abilities_costs_coloumn_name);
            ClearList(Force_abilities_combat_bonuses_coloumn_name);

            ClearDoubleLists(Force_abilities_general_info);
            ClearDoubleLists(Force_abilities_costs);
            ClearDoubleLists(Force_abilities_combat_bonuses);
        }



        public Force_ability_manager()
        {
            Force_abilities_general_coloumn_name        = new List<string>();
            Force_abilities_costs_coloumn_name          = new List<string>();
            Force_abilities_combat_bonuses_coloumn_name = new List<string>();

            Force_abilities_general_info    = new List<List<string>>();
            Force_abilities_costs           = new List<List<int>>();
            Force_abilities_combat_bonuses  = new List<List<int>>();


            Force_abilities_ID          = new List<string>();
            Force_abilities_name        = new List<string>();
            Force_general_description   = new List<string>();
            Force_description           = new List<string>();

            Force_abilities_general_info.Add(Force_abilities_ID);
            Force_abilities_general_info.Add(Force_abilities_name);
            Force_abilities_general_info.Add(Force_general_description);
            Force_abilities_general_info.Add(Force_description);

            juyo_special_condition = new Force_abilities_template();

            Shii_cho    = new Abilities_sequence_template();
            Makashi     = new Abilities_sequence_template();
            Soresu      = new Abilities_sequence_template();
            Ataro       = new Abilities_sequence_template();
            Diem_so     = new Abilities_sequence_template();
            New_niman   = new Abilities_sequence_template();
            Juyo        = new Abilities_sequence_template();
            Vaapad      = new Abilities_sequence_template();
            Old_niman   = new Abilities_sequence_template();
            Sokan       = new Abilities_sequence_template();
            Shien       = new Abilities_sequence_template();
            
            _Force_sequences = new List<Abilities_sequence_template>();
            
            _Force_sequences.Add(Shii_cho);
            _Force_sequences.Add(Makashi);
            _Force_sequences.Add(Soresu);
            _Force_sequences.Add(Ataro);
            _Force_sequences.Add(Diem_so);
            _Force_sequences.Add(New_niman);
            _Force_sequences.Add(Juyo);
            _Force_sequences.Add(Vaapad);
            _Force_sequences.Add(Old_niman);
            _Force_sequences.Add(Sokan);
            _Force_sequences.Add(Shien);
            
            _Force_abilities = new List<All_abilities_template>();

            SQLite_connection_string = $@"Data Source={Directory.GetCurrentDirectory()}\Database\Force_abilities.db;Version=3;";
        }
    }
}
