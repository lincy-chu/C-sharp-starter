using System;

namespace CSharpStarter
{
    public static class Util
    {
        public static int Max(int x, int y) // 获取两个数之中的最大值
        {
            return (x > y) ? x : y;
        }

        public static bool IsOdd(int x) // 判断是否是奇数
        {
            return x % 2 == 1;
        }

        public static bool LeapYear(int iYear) // 判断是否是闰年
        {
            if (iYear % 4 == 0)
            {
                if (iYear % 100 == 0)
                {
                    return iYear % 400 == 0;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool LeapYear1(int iYear)
        {
            var date = new DateTime(iYear,3, 1, 0, 0, 0);
            var curDate = Convert.ToDateTime(date.ToString());
            var lastDay = curDate.AddDays(1 - curDate.Day).AddDays(-1).Day;  // 返回指定当前月份的最后一天
            return lastDay == 29;
        }
    }
}