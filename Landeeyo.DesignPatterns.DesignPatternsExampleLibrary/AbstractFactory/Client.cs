using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.AbstractFactory
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override bool Equals(System.Object obj)
        {
            Client client = obj as Client;
            if ((object)client == null)
            {
                return false;
            }

            //TODO Examine why base.equals returns false even if it should be true...
            return //base.Equals(obj) &&
                ClientID == client.ClientID &&
                Name == client.Name &&
                Address == client.Address;
        }
    }
}
