using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonDP.Models
{
    public class DBHelper
    {
        public string ConnectionString { get; set; }
        public string StatusMessage { get; set; }
        private DBHelper(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private static DBHelper _helper;
        public static DBHelper CreateDBHelper(string connectionString)
        {
            if (_helper==null)
            {
                _helper = new DBHelper(connectionString);
            }
            else
            {
                if (_helper.ConnectionString!=connectionString)
                {
                    _helper = new DBHelper(connectionString);
                }
            }
            return _helper;
        }
    }
}
