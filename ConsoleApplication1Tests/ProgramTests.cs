using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aquapark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapark.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        //time = 0h 0min

        [TestMethod()]
        public void chargesCalcTest()
        {
            Program target = new Program();
            string E = "12:00";
            string L = "12:00";
            int expected = 0;
            int actual;
            actual = target.chargesCalc(E, L);
            Assert.AreEqual(expected, actual);
        }

        //time = 0h 10min

        [TestMethod()]
        public void chargesCalcTest2()
        {
            Program target = new Program();
            string E = "12:00";
            string L = "12:10";
            int expected = 4;
            int actual;
            actual = target.chargesCalc(E, L);
            Assert.AreEqual(expected, actual);
        }

        //time = 2h 10min

        [TestMethod()]
        public void chargesCalcTest3()
        {
            Program target = new Program();
            string E = "12:00";
            string L = "14:10";
            int expected = 8;
            int actual;
            actual = target.chargesCalc(E, L);
            Assert.AreEqual(expected, actual);
        }
    }
}