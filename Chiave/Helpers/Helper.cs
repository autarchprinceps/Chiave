using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Chiave
{
    class Helper
    {
        #region Image to Icon

        public Icon GetIcon(Image img, int size, bool keepAspectRatio)
        {
            Bitmap square = new Bitmap(size, size);
            Graphics g = Graphics.FromImage(square);

            int x, y, w, h;

            if (!keepAspectRatio || img.Height == img.Width)
            {
                x = y = 0;
                w = h = size; 
            }
            else
            {
                float r = (float)img.Width / (float)img.Height;

                if (r > 1)
                { 
                    w = size;
                    h = (int)((float)size / r);
                    x = 0; y = (size - h) / 2; 
                }
                else
                { 
                    w = (int)((float)size * r);
                    h = size;
                    y = 0; x = (size - w) / 2; 
                }
            }

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, x, y, w, h);
            g.Flush();

            return Icon.FromHandle(square.GetHicon());
        }

        internal Icon GetIcon(Icon icon)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region File Association
        // Associate file extension with progID, description, icon and application
        public static void Associate(string extension,
               string progID, string description, string icon, string application)
        {
            Registry.ClassesRoot.CreateSubKey(extension).SetValue("", progID);
            if (progID != null && progID.Length > 0)
                using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(progID))
                {
                    if (description != null)
                        key.SetValue("", description);
                    if (icon != null)
                        key.CreateSubKey("DefaultIcon").SetValue("", ToShortPathName(icon));
                    if (application != null)
                        key.CreateSubKey(@"Shell\Open\Command").SetValue("",
                                    ToShortPathName(application) + " \"%1\"");
                }
        }

        // Return true if extension already associated in registry
        public static bool IsAssociated(string extension)
        {
            return (Registry.ClassesRoot.OpenSubKey(extension, false) != null);
        }

        [DllImport("Kernel32.dll")]
        private static extern uint GetShortPathName(string lpszLongPath,
            [Out] StringBuilder lpszShortPath, uint cchBuffer);

        // Return short path format of a file name
        private static string ToShortPathName(string longName)
        {
            StringBuilder s = new StringBuilder(1000);
            uint iSize = (uint)s.Capacity;
            uint iRet = GetShortPathName(longName, s, iSize);
            return s.ToString();
        }

        #endregion
    }
}
