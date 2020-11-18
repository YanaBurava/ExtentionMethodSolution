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
        public void GetBitTest()
        {
            int w = 0b11001010;
            bool expected = true;
            bool actual = w.GetBit(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetBit0Test()
        {
            int w = 0b11001011;
            bool expected = true;
            bool actual = w.GetBit(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetBit31Test()
        {
            int w = 0b11001011;
            bool expected = false;
            bool actual = w.GetBit(31);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetBit_PositioGreaterThanSize_Exeption_Test()
        {
            int w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBit(33));

        }
       
        [TestMethod()]
        public void GetBit_PositioLessThan0_Exeption_Test()
        {
            int w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBit(-3));
        }

        [TestMethod()]
        public void SetBitTest()
        {
            int w = 0b11001010;
            int act = w.SetBit(1,11 );
            int exp = 0b0100011001010;

            Assert.AreEqual(exp, act);
        }
        [TestMethod()]
        public void SetBit0Test()
        {
            int w = 0b11001011;
            int act = w.SetBit(0, 0);
            int exp = 0b11001010;

            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void SetBit31Test()
        {
            int w = 0b1010;
            int act = w.SetBit(0, 31);
            int exp = 0b1010;

            Assert.AreEqual(exp, act);
        }
        [TestMethod()]
             public void SetBit_PositionBiggerThanSize_Exeption_Test()
        {
           int w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBit(1, 33));
        }
               
        [TestMethod()]
        public void SetBit_PositioLessThan0_Exeption_Test()
        {
            int w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBit(1, -1));
        }

        #endregion

        #region byte
        [TestMethod()]
        public void GetBitTest_byte()
        {
            byte w = 0b11001010;
            bool expected = true;
            bool actual = w.GetBit(3);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetBit7Test_byte()
        {
            byte w = 0b11001010;
            bool expected = true;
            bool actual = w.GetBit(7);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetBit0Test_byte()
        {
            byte w = 0b11001010;
            bool expected = false;
            bool actual = w.GetBit(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetBit_PositioGreaterThanSize_Exeption_Test_byte()
        {
            byte w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBit(8));

        }

        [TestMethod()]
        public void GetBit_PositioLessThan0_Exeption_Test_byte()
        {
            byte w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBit(-1));
        }

        [TestMethod()]
        public void SetBitTest_byte()
        {
            byte w = 0b11001010;
            byte act = w.SetBit(1, 5);
            byte exp = 0b11101010;

            Assert.AreEqual(exp, act);
        }
        [TestMethod()]
        public void SetBit0Test_byte()
        {
            byte w = 0b11001010;
            byte act = w.SetBit(1, 0);
            byte exp = 0b11001011;

            Assert.AreEqual(exp, act);
        }
        [TestMethod()]
        public void SetBit7Test_byte()
        {
            byte w = 0b01001010;
            int act = w.SetBit(1, 7);
            int exp = 0b11001010;

            Assert.AreEqual(exp, act);
        }


        [TestMethod()]
        public void SetBit_PositionBiggerThanSize_Exeption_Test_byte()
        {
            byte w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBit(0, 8));
        }

        [TestMethod()]
        public void SetBit_PositioLessThan0_Exeption_Test_byte()
        {
            byte w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBit(1, -1));
        }

        #endregion

        [TestMethod()]
        public void GetBitTest_ushort()
        {
            ushort w = 0b11001010;
            bool expected = true;
            bool actual = w.GetBit(3);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetBit15Test_ushort()
        {
            ushort w = 0b11001010;
            bool expected = false;
            bool actual = w.GetBit(15);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetBit0Test_ushort()
        {
            ushort w = 0b11001011;
            bool expected = true;
            bool actual = w.GetBit(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetBit_PositioGreaterThanSize_Exeption_Test_ushort()
        {
            ushort w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBit(16));

        }

        [TestMethod()]
        public void GetBit_PositioLessThan0_Exeption_Test_ushort()
        {
            ushort w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBit(-1));
        }

        [TestMethod()]
        public void SetBitTest_ushort()
        {
            ushort w = 0b11001010;
            ushort act = w.SetBit(1, 5);
            ushort exp = 0b11101010;

            Assert.AreEqual(exp, act);
        }
        [TestMethod()]
        public void SetBit0Test_ushort()
        {
            ushort w = 0b11001010;
            ushort act = w.SetBit(1, 0);
            ushort exp = 0b11001011;

            Assert.AreEqual(exp, act);
        }
        [TestMethod()]
        public void SetBit15Test_ushort()
        {
            ushort w = 0b01001010;
            ushort act = w.SetBit(1, 15);
            ushort exp = 0b1000000001001010;
            
            Assert.AreEqual(exp, act);
        }


        [TestMethod()]
        public void SetBit_PositionBiggerThanSize_Exeption_Test_ushort()
        {
            ushort w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBit(0, 18));
        }

        [TestMethod()]
        public void SetBit_PositioLessThan0_Exeption_Test_ushort()
        {
            ushort w = 0b11001010;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBit(1, -1));
        }
        #region long
        //[TestMethod()]
        //public void GetBitTest_long()
        //{
        //    long w = 0b11001010;
        //    bool expected = true;
        //    bool actual = w.GetBit(3);

        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod()]
        //public void GetBit1Test_long()
        //{
        //    long w = 0b11001010;
        //    bool expected = false;
        //    bool actual = w.GetBit(63);

        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod()]
        //public void GetBit0Test_long()
        //{
        //    ushort w = 0b11001011;
        //    bool expected = true;
        //    bool actual = w.GetBit(0);

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod()]
        //public void GetBit_PositioGreaterThanSize_Exeption_Test_long()
        //{
        //    long w = 0b11001010;
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBit(65));

        //}

        //[TestMethod()]
        //public void GetBit_PositioLessThan0_Exeption_Test_long()
        //{
        //    long w = 0b11001010;
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.GetBit(-1));
        //}

        //[TestMethod()]
        //public void SetBitTest_long()
        //{
        //    long w = 0b11001010;
        //    long act = w.SetBit(1, 5);
        //    long exp = 0b11101010;

        //    Assert.AreEqual(exp, act);
        //}
        //[TestMethod()]
        //public void SetBit0Test_long()
        //{
        //    long w = 0b11001010;
        //    long act = w.SetBit(1, 0);
        //    long exp = 0b11001011;

        //    Assert.AreEqual(exp, act);
        //}


        //[TestMethod()]
        //public void SetBit_PositionBiggerThanSize_Exeption_Test_long()
        //{
        //    long w = 0b11001010;
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBit(0, 65));
        //}

        //[TestMethod()]
        //public void SetBit_PositioLessThan0_Exeption_Test_long()
        //{
        //    ushort w = 0b11001010;
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => w.SetBit(1, -1));
        //}
        #endregion
    }
}