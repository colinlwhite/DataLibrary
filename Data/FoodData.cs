using DataLibrary.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Data
{
    public class FoodData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public FoodData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }
    }
}
