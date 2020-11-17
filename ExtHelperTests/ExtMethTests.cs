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
        #region int case
        [TestMethod()]
        public void GetBitsTest()
        {
            int w = 0b11001010;
            bool expected = true;
            bool actual = w.GetBits(3);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetBits_PositioGreaterThanSize_Exeption_Test()
        {
            int w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBits(33));

        }
       
        [TestMethod()]
        public void GetBits_PositioLessThan0_Exeption_Test()
        {
            int w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBits(-1));
        }

        [TestMethod()]
        public void SetBitsTest()
        {
            int w = 0b11001010;
            int act = w.SetBits(1, 0);
            int exp = 0b11001011;

            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void SetBits_PositionBiggerThanSize_Exeption_Test()
        {
            int w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBits(0, 33));
        }
               
        [TestMethod()]
        public void SetBits_PositioLessThan0_Exeption_Test()
        {
            int w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBits(1, -1));
        }

        #endregion

        #region byte
        [TestMethod()]
        public void GetBitsTest_byte()
        {
            byte w = 0b11001010;
            bool expected = true;
            bool actual = w.GetBits(3);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetBits_PositioGreaterThanSize_Exeption_Test_byte()
        {
            byte w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBits(8));

        }

        [TestMethod()]
        public void GetBits_PositioLessThan0_Exeption_Test_byte()
        {
            byte w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBits(-1));
        }

        [TestMethod()]
        public void SetBitsTest_byte()
        {
            byte w = 0b11001010;
            int act = w.SetBits(1, 0);
            int exp = 0b11001011;

            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void SetBits_PositionBiggerThanSize_Exeption_Test_byte()
        {
            byte w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBits(0, 8));
        }

        [TestMethod()]
        public void SetBits_PositioLessThan0_Exeption_Test_byte()
        {
            byte w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBits(1, -1));
        }

        #endregion
    }
}