using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Microsoft.Extensions.Configuration;


namespace testmvc_vue.Data
{
    public class ExecuteDB
    {
        public ExecuteDB()
        {
        }

        public static string GetConnectionString()
        {
            return (string)Startup.StartupObjects["connectionString"];

            //return "Data Source=192.168.0.24;Initial Catalog=TESTMVC;User ID=sa;Password=sa";
        }
    }
}
