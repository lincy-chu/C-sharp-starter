/**
 * 存款类
 */

using static System.Console;
namespace CSharpStarter
{
    public class Deposit
    {
        private static double _rate = 0.0265; // 利率
        private static double _sum = 0; // 总金额

        public static void CalculateInterest(int principal, int year) // 计算利息
        {
            double inter = 1;
            for (var i = 0; i < year; i++)
            {
                inter *= (1 + _rate);
            }
            
            var sum = (_sum + principal) * inter;
            var interests = sum - principal - _sum;
            SetSum(sum);
            WriteLine($"存入{principal}元，{year}年后所获利息为： {interests:0.00}元RMB, 本息为：{_sum:0.00}");
        }

        public static void ChangeRate(double newRate) // 改变利息
        {
            _rate = newRate / 100;
            WriteLine($"调整利率为: {newRate}%");
        }

        private static void SetSum(double sum)
        {
            _sum = sum;
        }
    }
}