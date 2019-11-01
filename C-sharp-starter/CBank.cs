using System;
using static System.Console;

namespace CSharpStarter
{
    public class CBank
    {
        private readonly DateTime[] _date = new DateTime[100]; // 操作日期
        readonly double[] _money = new double[100]; // 存取金额
        private readonly double[] _rest = new double[100]; // 余额
        private double _balance; // 每一次交易后的余额
        private int _top; // 访问数组变量

        internal void BankIn(DateTime date, double money) // 向银行中存钱
        {
            _date[_top] = date; // 将日期保存到日期数组中
            _balance += money; // 当前余额
            _money[_top] = money; // 取款余额
            _rest[_top] = _balance; // 余额
            _top++;
        }

        internal void BankOut(DateTime date, double money) // 从银行中取钱
        {
            _date[_top] = date; // 将日期保存到日期数组中
            _balance -= money; // 当前余额
            _money[_top] = -money; // 取款金额
            _rest[_top] = _balance; // 余额
            _top++;
        }

        internal void Display()
        {
            var i = 0;
            WriteLine("***日期*************存入****************支出*****************余额\n");
            for (i = 0; i < _top; i++)
            {
                Write(_date[i].ToString("yyyy-MM-dd"));
                if (_money[i] > 0)
                {
                    Write(" ---------- " + _money[i] + " -----------");
                }
                else
                {
                    Write($" ---------- {_money[i]} -----------");
                }
                Write($" {_rest[i]}");
                WriteLine();
            }
        }
    }
}