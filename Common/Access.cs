using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common
{
    class Access
    {
        public string[] ReadLine()
        {
            string strPath = "";
            List<string> lstFileContents = new List<string>();
            StreamReader sr = File.OpenText(strPath);
            while (sr.Peek() > -1)
            {
                lstFileContents.Add(sr.ReadLine());
            }

            return lstFileContents.ToArray();
        }
    }
}
