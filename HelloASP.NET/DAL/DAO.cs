using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloASP.NET
{
    public class DAO
    {
        private static iPersonDAO mock = null;
        private static iPersonDAO MS_SQL = null;

        public static iPersonDAO ini(string s)
        {
            iPersonDAO inidb = null;
            switch (s)
            {
                case "MS_SQL":
                    if (MS_SQL == null)
                    {
                        inidb = new MS_SQL_Person();
                        MS_SQL = inidb;
                    }
                    else
                    {
                        inidb = MS_SQL;
                    }
                    break;
                default:
                    if (mock == null)
                    {
                        inidb = new MockPersonDB();
                        mock = inidb;
                    }
                    else
                    {
                        inidb = mock;
                    }
                    break;
            }
            return inidb;
        }
    }
}