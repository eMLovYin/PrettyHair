using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrettyHair;

namespace UnitTests
{
    [TestClass]
    public class WTest
    {
        [TestMethod]
        public void CanGetWares()
        {
            ItemRepository itemRep = new ItemRepository();

            List<Ware> wareList = itemRep.GetWare();

            Assert.AreEqual(5, wareList.Count);
        }
    }
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void CanRegisterCustomer()
        {
            CustomerRepository CRC = new CustomerRepository();
            List<Customer> customerList = CRC.FindAllCustomers();

            Assert.AreEqual(5, customerList.Count);

            CRC.RegisterCustomer(new Customer(6, "Sez", "somewhere"));
            customerList = CRC.RegisterCustomer();

            Assert.AreEqual(6, customerList.Count);
        }
    }
}
