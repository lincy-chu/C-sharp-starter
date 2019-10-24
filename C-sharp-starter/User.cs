using System;
using static System.Console;

namespace CSharpStarter
{
    public class User
    {
        private string _strUserName;
        private string _strUserId;
        private byte[] _byPassword; 

        public void AddUser(string strUserName, string strUserId, byte[] byPassword)
        {
            this._strUserName = strUserName;
            this._strUserId = strUserId;
            this._byPassword = byPassword;
        }

        public static void CountExponent(double h, int w)
        {
            var height = h;
            var weight = w;
            var exponent = weight / (height * height);
            WriteLine($"身高：{height}");
            WriteLine($"体重：{weight}");
            WriteLine($"exponent = {exponent}");

            if (exponent < 18.5)
            {
                WriteLine("您的体重属于：体重过轻");
            }
            else if (exponent >= 18.5 && exponent < 24.9)
            {
                WriteLine("您的体重属于：正常范围");
            }
            else if (exponent >= 24.9 && exponent < 29.9)
            {
                WriteLine("您的体重属于：体重过重");
            }
            else if (exponent >= 29.9)
            {
                WriteLine("您的体重属于：肥胖");
            }
        }

        public override string ToString()
        {
            return $"StrUserName = {this._strUserName}, StrUserId = {this._strUserId}, ByPassword = {this._byPassword}";
        }
    }
}