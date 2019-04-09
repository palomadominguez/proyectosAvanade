using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscotecaBL
{
    public static class Connection
    {
        public static string GetConnectionString()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["ChinookConnection"];
            return settings.ConnectionString;
        }

        public static string GetConnectionString(string connectionName)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["connectionName"];



            return settings.ConnectionString;
        }



    }


}
