using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.AbstractFactory;

namespace Landeeyo.DesignPatterns.Tests.AbstractFactory
{
    [TestFixture]
    public class AbstractFactoryTest
    {
        [Test]
        void DALAbstractFactoryMemoryTest()
        {
            //arrange
            DAOFactory concreteFactory = DAOFactory.GetFactory(DAOFactoryType.Memory);
            Client client =
                new Client()
                {
                    Name = "Test",
                    Address = "Test"
                };

            //act
            concreteFactory.AddClient(client);
            Client client2 = concreteFactory.GetClientByID(client.ClientID);

            //assert
            Assert.AreEqual(client, client2);
        }

        [Test]
        void DALAbstractFactoryXMLTest()
        {
            //arrange
            DAOFactory concreteFactory = DAOFactory.GetFactory(DAOFactoryType.Memory);
            Client client =
                new Client()
                {
                    Name = "Test",
                    Address = "Test"
                };

            //act
            concreteFactory.AddClient(client);
            Client client2 = concreteFactory.GetClientByID(client.ClientID);

            //assert
            Assert.AreEqual(client, client2);
        }
    }
}
