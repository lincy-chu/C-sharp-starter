using System;
using static System.Console;

namespace CSharpStarter // 命名空间，在C#中起到组织程序的作用。命名空间即用作程序的"内部"组织系统，也用作向"外部"公开的组织系统（即一种向其他程序公开自己拥有元素的方法）。如果要调用某个命名空间中的类或者方法，需要先使用using指令引入命名空间，这样，就可以直接使用该命名空间中所包含的成员（包括类及类中的方法、属性等）
{
    internal static class MainClass
    {
        public static void Main(string[] args) // 自动生成的Main方法，用来作为程序的入门方法，每个C#程序都必须有一个Main方法。Main的返回类型有两种：void或int。Main方法可以包含命令行参数string[] args，也可以不包括
        {
            Demo();
            Demo1();
        }

        private static void Demo()
        {
            WriteLine("人因梦想而伟大"); // Console.WriteLine()方法用来向控制台中输出内容
            WriteLine("             -- 雷军");
//            ReadLine(); // Console.ReadLine()方法主要用来获取控制台中的输出，这里将控制台固定控制台界面
            
            var operation = new Operation("朱朱", "18819318565");
            WriteLine(operation.ToString());
            
            // 如果不想使用using指令引用命名空间，可以在代码中使用命名空间调用其中的类
            var operations = new CSharpStarter.Operation("robin", "18818521985");
            WriteLine(operations.ToString());
            
            /**
             * C#语言标识符命名规则如下：
             *     1.由任意顺序的字母、下划线和数字组成
             *     2.第一个字符不能是数字
             *     3.不能是C#中的保留关键字
             *     4.标识符中字母严格区分大小写
             */
            WriteLine("-------------------------------------------");
            WriteLine("|                                          |");
            WriteLine("|                                          |");
            WriteLine("|                                          |");
            WriteLine("|                                          |");
            WriteLine("|     编程字典（珍藏版）                      |");
            WriteLine("|                                          |");
            WriteLine("|                                          |");
            WriteLine("|          开发团队：明日科技                 |");
            WriteLine("|                                          |");
            WriteLine("|                                          |");
            WriteLine("|          copyright 2000-1019 明日科技     |");
            WriteLine("|                                          |");
            WriteLine("|                                          |");
            WriteLine("|                                          |");
            WriteLine("-------------------------------------------");
            
            var user = new User();
            user.AddUser("朱朱", "1234567890", new byte[]{1, 2});
            WriteLine(user.ToString());
            User.CountExponent(1.78, 75);
            
            // Char类的使用
            const char a = 'a';
            const char b = '8';
            const char c = 'L';
            const char d = '.';
            const char e = '|';
            const char f = ' ';
            // 使用IsLetter方法判断是否为字母
            WriteLine("IsLetter方法判断a是否为字母：{0}", char.IsLetter(a));
            WriteLine("IsDigit方法判断b是否为数字：{0}", char.IsDigit(b));
            WriteLine("IsLetterOrDigit方法判断c是否为字母或数字：{0}", char.IsLetterOrDigit(c));
            WriteLine("IsLower方法判断a是否为小写字母：{0}", char.IsLower(a));
            WriteLine("IsUpper方法判断c是否为大写字母：{0}", char.IsUpper(c));
            WriteLine("IsPunctuation方法判断是否为标点符号：{0}", char.IsPunctuation(d));
            WriteLine("IsSeparator方法判断e是否分隔符：{0}", char.IsSeparator(e));
            WriteLine("IsWhiteSpace方法判断f是否为空白：{0}", char.IsWhiteSpace(f));
        }

        private static void Demo1()
        {
            // 声明时初始化变量
            // 一次声明初始化多个变量
            const string mr1 = "零基础", mr2 = "项目入门", mr3 = "实例精粹";
            WriteLine($"mr_1 = {mr1}, mr2 = {mr2}, mr3 = {mr3}");
            
//            WriteLine("   欢迎进入明日科技官网\n\n  请首先输入用户名：   ");
//            var name = ReadLine();
//            WriteLine("  用户登录：  " + name);

            const int c = 89, csharp = 90, sql = 60; // 定义3个变量，分别存储C语言、C#和SQL的分数
            const int sub = csharp - sql; // 计算C#和SQL的分数差
            const double avg = (c + csharp + sql) / 3; // 计算平均成绩
            WriteLine("C#课和SQL课的分数之差：{0}", sub);
            WriteLine("3门课的平均分：{0}", avg);

            const int x = 5, y = 6;
            var max = Util.Max(x, y);
            WriteLine($"max = {max}");

            var isOdd = Util.IsOdd(5);
            var text = isOdd ? "是奇数" : "是偶数";
            WriteLine($"{x}{text}");

            var rad = new Random();
            var year = Convert.ToInt32(rad.Next(1000, 9999));
            var isLeapYear = Util.LeapYear(year);
            var txt = isLeapYear ? "闰年" : "平年";
            WriteLine($"{year}是{txt}");
            
            var isLeapYear1 = Util.LeapYear1(year);
            var txt1 = isLeapYear1 ? "闰年" : "平年";
            WriteLine($"{year}是{txt1}");
        }
    }
}
