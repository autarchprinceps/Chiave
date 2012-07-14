using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace Chiave
{
    class Save
    {
        public string Name;
        public Save(string FileName)
        {
            Name = FileName;

            if (!File.Exists(Name))
            {
                FileStream fsOutput = new FileStream(Name, FileMode.OpenOrCreate, FileAccess.Write);
                fsOutput.Close();
                InitializePresets();
                
            }
        }

        private void InitializePresets()
        {
            Save Sav = new Save(Name);
            Sav.SetValue("Settings", "History", "1");
            Sav.SetValue("UI", "History", "1");
        }

        #region DLL Imports

        [DllImport("kernel32", SetLastError = true)]
        static extern int WritePrivateProfileString(string section, string key, string value, string fileName);
        [DllImport("kernel32", SetLastError = true)]
        static extern int WritePrivateProfileString(string section, string key, int value, string fileName);
        [DllImport("kernel32", SetLastError = true)]
        static extern int WritePrivateProfileString(string section, int key, string value, string fileName);
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder result, int size, string fileName);
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string section, int key, string defaultValue, [MarshalAs(UnmanagedType.LPArray)] byte[] result, int size, string fileName);
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(int section, string key, string defaultValue, [MarshalAs(UnmanagedType.LPArray)] byte[] result, int size, string fileName);



        #endregion

        #region Internal 

        public void SetValue(string section, string entry, object value)
        {
            WritePrivateProfileString(section, entry, value.ToString(), Name);
        }

        public object GetValue(string section, string entry)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, entry, "", temp,
                                            255, Name);
            return temp.ToString();
        }

        public void RemoveEntry(string section, string entry)
        {
            WritePrivateProfileString(section, entry, 0, Name);
        }

        /// <summary>

        public void RemoveSection(string section)
        {
            WritePrivateProfileString(section, 0, "", Name);
        }


        public string[] GetEntryNames(string section)
        {
            // Loop until the buffer has grown enough to fit the value
            for (int maxSize = 500; true; maxSize *= 2)
            {
                byte[] bytes = new byte[maxSize];
                int size = GetPrivateProfileString(section, 0, "", bytes, maxSize, Name);

                if (size < maxSize - 2)
                {
                    // Convert the buffer to a string and split it
                    string entries = Encoding.ASCII.GetString(bytes, 0, size - (size > 0 ? 1 : 0));
                    if (entries == "")
                        return new string[0];
                    return entries.Split(new char[] { '\0' });
                }
            }
        }

        public string[] GetSectionNames()
        {
            for (int maxSize = 500; true; maxSize *= 2)
            {
                byte[] bytes = new byte[maxSize];
                int size = GetPrivateProfileString(0, "", "", bytes, maxSize, Name);

                if (size < maxSize - 2)
                {
                    // Convert the buffer to a string and split it
                    string sections = Encoding.ASCII.GetString(bytes, 0, size - (size > 0 ? 1 : 0));
                    if (sections == "")
                        return new string[0];
                    return sections.Split(new char[] { '\0' });
                }
            }
        }
        #endregion
    }
}
