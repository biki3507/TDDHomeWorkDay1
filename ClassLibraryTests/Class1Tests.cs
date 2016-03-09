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
        public void GetSample1Test_GroupNum_3_and_Column_Cost_Result_must_be_6_15_24_21()
        {
            //arrange
            var target = new Class1();
            var expected = new Result() { Column = (int)ClassLibrary.Class1.Column.Cost, Data = new List<int>() {6,15,24,21 } };
            //act
            var actual = target.GetSample1(3, Class1.Column.Cost);
            //assert
            expected.ToExpectedObject().ShouldMatch(actual);
            
        }
        [TestMethod()]
        public void GetSample1Test_GroupNum_4_and_Column_Revenue_Result_must_be_50_66_60()
        {
            //arrange
            var target = new Class1();
            var expected = new Result() { Column = (int)ClassLibrary.Class1.Column.Revenue, Data = new List<int>() { 50,66,60 } };
            //act
            var actual = target.GetSample1(4, Class1.Column.Revenue);
            //assert

            expected.ToExpectedObject().ShouldMatch(actual);

        }
        //第一個版本只有回傳int(Cost)
        //但是int可能來自於不同欄位=>GetSample必有第二個參數是欄位
        //加入第二個參數欄位名稱
        //只有在欄位名稱相同且群組數量一致時才會通過

    }
}
