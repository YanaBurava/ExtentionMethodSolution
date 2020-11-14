using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtHelper.Tests
{
    [TestClass()]
    public class ExtMethTests
    {
       
        int w = 0b11001010;

        [TestMethod()]
        public void GetBitsTest()
        {
            bool expected = true;
            bool actual= w.GetBits(1, 2);
                       
            Assert.AreEqual(expected, actual);
        
        }

        [TestMethod()]
        public void SetBitsTest()
        {
       
            int act = w.SetBits(1, 0, 7);
            int exp = 0b11001011;

            Assert.AreEqual(exp, act);
        }
   
    }
}