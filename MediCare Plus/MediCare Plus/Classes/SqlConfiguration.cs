using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare_Plus.Classes
{
    internal class SqlConfiguration
    {
        public static string connectionString;

        public string SqlConnectionAccess()
        {
            connectionString = @"Data Source=DESKTOP-TDDKJH3;Initial Catalog=MediCarePlus;Integrated Security=True";
            return connectionString;
        }
    }
}
