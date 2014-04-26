using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.AbstractFactory
{
    public abstract class DAOFactory
    {
        public static DAOFactory GetFactory(DAOFactoryType type)
        {
            switch (type)
            {
                case DAOFactoryType.Memory:
                    throw new NotImplementedException();
                case DAOFactoryType.XML:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }
        }

        public abstract Client GetClientByID(int ID);
        public abstract void AddClient(Client client);
    }

    public enum DAOFactoryType
    {
        XML,
        Memory
    }
}
