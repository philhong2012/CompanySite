using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CompanySite.Settings
{
    public static class ApplicationSettings
    {
        public static int PageSize;
        public static int PageGroup;

        static ApplicationSettings()
        {
            PageSize = int.Parse(ConfigurationManager.AppSettings["PageSize"]);
            PageGroup = int.Parse(ConfigurationManager.AppSettings["PageGroup"]);
        }
    }
}