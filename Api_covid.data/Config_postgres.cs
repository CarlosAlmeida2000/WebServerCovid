using System;
using System.Collections.Generic;
using System.Text;

namespace Api_covid.data
{
    public class Config_postgres
    {
        public Config_postgres(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public string connectionString { get; set; }
    }
}
