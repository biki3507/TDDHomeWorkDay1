using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        public List<int> GetSample1(int groupNum)
        {
            List<int> data = new List<int>();

            switch (groupNum)
            {
                case 3:
                    data.Add(6);
                    data.Add(15);
                    data.Add(24);
                    data.Add(21);
                    break;
                case 4:
                    data.Add(50);
                    data.Add(66);
                    data.Add(60);
                    break;
            }

            return data;
        }


    }
}
