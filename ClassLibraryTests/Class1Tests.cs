using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpectedObjects;
namespace ClassLibrary.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void GetSample1Test_GroupNum_3_Result_must_be_6_15_24_21()
        {
            //arrange
            var target = new Class1();
            var expected = new List<int>() {6,24,15,21 };
            //act
            var actual = target.GetSample1(3);
            //assert

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod()]
        public void GetSample1Test_GroupNum_4_Result_must_be_50_66_60()
        {
            //arrange
            var target = new Class1();
            var expected = new List<int>() { 50,66,60 };
            //act
            var actual = target.GetSample1(4);
            //assert

            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
