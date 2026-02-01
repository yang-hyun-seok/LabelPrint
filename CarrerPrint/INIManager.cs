using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace IniManager
{
    public class INIManager
    {
        private String m_strINIPath;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(String section,
            String key, String val, String filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(String section,
                 String key, String def, StringBuilder retVal,
            int size, String filePath);

        public INIManager(String INIPath)
        {
            m_strINIPath = INIPath;
        }

        public bool ExistINI()
        {
            return File.Exists(m_strINIPath); //파일 존재 여부 리턴 bool type
        }

        public void WriteValue(String strSection, String strKey, String strValue)
        {
            WritePrivateProfileString(strSection, strKey, strValue, m_strINIPath);
        }

        public void DeleteSection(String strSection)
        {
            WritePrivateProfileString(strSection, null, null, m_strINIPath);
        }

        public string ReadValue(String strSection, String Key)
        {
            StringBuilder strValue = new StringBuilder(255);
            int i = GetPrivateProfileString(strSection, Key, "", strValue, 255, m_strINIPath);
            return strValue.ToString();
        }
    }
}

