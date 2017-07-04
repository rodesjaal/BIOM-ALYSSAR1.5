using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

namespace BIOM_ALYSSAR1._5
{
    class Helper
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
        }
    }
}
