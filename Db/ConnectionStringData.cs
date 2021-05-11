using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Db
{
    public class ConnectionStringData
    {
        // TODO - Move Connection Name to appSettings.json
        public string SqlConnectionName { get; set; } = "default";
    }
}
