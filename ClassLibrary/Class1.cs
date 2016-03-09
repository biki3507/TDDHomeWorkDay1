using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        public Result GetSample1(int groupNum, Column colunb)
        {
            Result data = new Result();

            switch (groupNum)
            {
                case 3:
                    data.Column = (int)colunb;
                    data.Data = new List<int>();
                    data.Data.Add(6);
                    data.Data.Add(15);
                    data.Data.Add(24);
                    data.Data.Add(21);
                    break;
                case 4:
                    data.Column = (int)colunb;
                    data.Data = new List<int>();
                    data.Data.Add(50);
                    data.Data.Add(66);
                    data.Data.Add(60);
                    break;
            }

            return data;
        }
       
        public enum Column
        {
            Id=1,
            Cost=2,
            Revenue=3,
            SellPrice=4

        } ;
    }
    public class Result
    {
        public int Column { get; set; }
        public List<int> Data { get; set;  }
    }
    
}
