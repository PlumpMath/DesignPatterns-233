using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Builder
{
    public class Connection
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public ConnectionType Type { get; set; }
    }

    public enum ConnectionType
    {
        UDP,
        TCP
    }
}
