using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Tests
{
    [TestClass()]
    public class VendingMachineTests
    {
        VendingMachine vendingMachine = new VendingMachine();
        [TestMethod()]
        public void TestDepositCoin()
        {
            
            try
            {
                vendingMachine.DepositCoin(0);
                Assert.IsNotNull(0);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Machine wont accept below then 1 cent");
                Assert.Fail();
                return;
            }

        }

        [TestMethod()]
        public void GetProductTest()
        {
            try
            {
                vendingMachine.GetProduct("001", 30);
            }
            catch (Exception e)
            {
                Assert.Fail();
                return;
            }
        }
    }
}