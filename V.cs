using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;

namespace Sader_Hotkey_Creator
{
    public static class V
    {
        public static bool Working = false;
        public enum CommandList
        {
            OpenApp,
            OpenAppAdmin,
            OpenFile,
            PowerShell,
            CMD,
            CMDAdmin
        }

        public static List<Key> Key_1 = new List<Key>();
        public static List<Keys> Key_2 = new List<Keys>();
        public static List<CommandList> Type = new List<CommandList>();
        public static List<string> Commands = new List<string>();

        public static bool k1_cap = false;
        public static bool k2_cap = false;
        public static bool data_refresh = false;
        private static string application_path = Application.ExecutablePath.ToString();
        private static string path = Path.GetDirectoryName(application_path);
        private static string setting = "sader_hotkey_creator.ini";
        private static string setting_path = path + @"\" + setting;
        public const string application_name = "Sader Hotkey Creator";

        public static bool readConfig()
        {
            if (!File.Exists(setting_path))
            {
                File.WriteAllText(setting_path, "#(Key)HotKey|(Keys)HotKey|(Enum)Type|(String)Command" + Environment.NewLine);
            }
            string[] Config = File.ReadAllLines(setting_path);
            foreach (string line in Config)
            {
                if(line.StartsWith("#")) continue;
                if (!line.Contains("|")) continue;
                string[] content = line.Split("|".ToCharArray(),4);

                Key k1;
                if (Enum.TryParse(content[0], out k1))
                {
                    if (!Enum.IsDefined(typeof(Key), k1)) continue;
                }

                Keys k2;
                if (Enum.TryParse(content[1], out k2))
                {
                    if (!Enum.IsDefined(typeof(Keys), k2)) continue;
                }

                V.CommandList Type;
                if(Enum.TryParse(content[2], out Type)){
                    if(!Enum.IsDefined(typeof(V.CommandList), Type)) continue;
                }

                V.Key_1.Add(k1);
                V.Key_2.Add(k2);
                V.Type.Add(Type);
                V.Commands.Add(content[3]);
            }
            return true;
        }

        public static bool saveConfig()
        {
            File.Delete(setting_path);
            string text = "#(Key)HotKey|(Keys)HotKey|(Enum)Type|(String)Command" + Environment.NewLine;
            for (int i = 0;i< Key_1.Count; i++)
            {
                text += Key_1[i] + "|" + Key_2[i] + "|" + Type[i] + "|" + Commands[i] + Environment.NewLine;
            }
            File.WriteAllText(setting_path, text);
            return true;
        }
    }
}
