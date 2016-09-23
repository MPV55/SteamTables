using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteatTablesDemo
{
    class MyMath
    {
        public static string MyFormat(double MyValue)
        {
            int power;

            if (MyValue == -1 || MyValue == 0)
            {
                return Convert.ToString(MyValue);
            }
            else if (Math.Abs(MyValue) < 0.001)
            {
                power = 0;
                while (Math.Abs(MyValue) < 0.9999999)
                {
                    power++;
                    MyValue = MyValue * 10;
                }
                return Convert.ToString(Math.Round(MyValue, 5) + "E" + (-power));
            }
            else if (Math.Abs(MyValue) >= 0.001 && Math.Abs(MyValue) < 0.1)
            {
                return Convert.ToString(Math.Round(MyValue, 6));
            }
            else if (Math.Abs(MyValue) >= 0.1 && Math.Abs(MyValue) < 1)
            {
                return Convert.ToString(Math.Round(MyValue, 6));
            }
            else if (Math.Abs(MyValue) >= 1 && Math.Abs(MyValue) < 10)
            {
                return Convert.ToString(Math.Round(MyValue, 6));
            }
            else if (Math.Abs(MyValue) >= 10 && Math.Abs(MyValue) < 1000)
            {
                return Convert.ToString(Math.Round(MyValue, 6));
            }
            else if (Math.Abs(MyValue) >= 1000 && Math.Abs(MyValue) < 10000)
            {
                return Convert.ToString(Math.Round(MyValue, 6));
            }
            else
            {
                power = 0;
                while (Math.Abs(MyValue) > 9.999999999)
                {
                    power++;
                    MyValue = MyValue / 10;
                }
                return Convert.ToString(Math.Round(MyValue, 5) + "E" + (power));
            }
        }
    }
}
