using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CSharpStarter // 命名空间，在C#中起到组织程序的作用。命名空间即用作程序的"内部"组织系统，也用作向"外部"公开的组织系统（即一种向其他程序公开自己拥有元素的方法）。如果要调用某个命名空间中的类或者方法，需要先使用using指令引入命名空间，这样，就可以直接使用该命名空间中所包含的成员（包括类及类中的方法、属性等）
{
    internal static class MainClass
    {
        public static int Age
        {
            get; 
            set;
        }

        public static void Main(string[] args) // 自动生成的Main方法，用来作为程序的入门方法，每个C#程序都必须有一个Main方法。Main的返回类型有两种：void或int。Main方法可以包含命令行参数string[] args，也可以不包括
        {
//            Demo();
//            Demo1();
//            Demo2();
//            Demo3();
//            Tran12306();
//            Demo4();
            Demo5();
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

        private static void Demo2()
        {
            // switch语句
            var arr = new string[] { "体育类本科", "艺术类本科", "民办本科", "二本", "一本" };
            foreach (var str in arr)
            {
                TestSwitch(str);
            }

            WriteLine(TestSwitch1(166));
            WriteLine(TestSwitch1(266));
            WriteLine(TestSwitch1(666));
            WriteLine(TestSwitch1(866));
            WriteLine(TestSwitch1(1066));
            WriteLine();
            
            WriteLine(TestSwitch2(100, "90", "user"));
            WriteLine(TestSwitch2(100, "90", "worker"));
            WriteLine(TestSwitch2(100, "93", "user"));
            WriteLine(TestSwitch2(100, "93", "worker"));
            WriteLine(TestSwitch2(100, "97", "user"));
            WriteLine(TestSwitch2(100, "97", "worker"));
            WriteLine(TestSwitch2(100, "0", "user"));
            WriteLine(TestSwitch2(100, "0", "worker"));
            Gauss();
            MinValue();
            WriteLine(Factorial(1));
            WriteLine(Factorial(4));
            WriteLine(Factorial(5));
            WriteLine(Factorial(6));

            MultiplicationTable(); // 9 * 9乘法口诀
            Pyramid(); // 金字塔
            WriteLine(Total(100));
        }

        private static void Demo3()
        {
            var arr0 = new int[5]; // 使用new关键字为数组分配内存时，整个数组中各个元素的初始值都为0
            WriteLine(arr0[0]);
            var arr1 = new int[] { 1, 2, 3, 4, 5 }; // 同时为整数数组赋值
            foreach (var item in arr1)
            {
                Write($"{item} ");
            }
            WriteLine();

            string[] week = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }; // 同时为字符串数组赋值
            foreach (var item in week)
            {
                Write($"{item} ");
            }
            WriteLine();
            
            // 二维数组
            int[,] arr2 = {{1101, 1102, 1103}, {2101, 2102, 2103}, {3101, 3102, 3103}};
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Write($"arr2[{i}][{j}] = {arr2[i, j]}  ");
                }
                WriteLine(" ");
            }
        }

        private static void Demo4()
        {
            // 不规则数组的定义
            var a = new int[3][];
            a[0] = new int[5]; // 第一行分配5个元素
            a[1] = new int[3]; // 第二行分配3个元素
            a[2] = new int[2]; // 第三行分配2个元素
            
            // 数组与Array类
            /*
             * C#中的数组是由System.Array类派生而来的引用对象，可以使用Array类中的各种属性或方法对数组进行各种操作。
             * Copy             将数组中的指定元素复制到另一个Array中
             * CopyTo           从指定的目标组索引处开始，将当前一维数组中的所有元素复制到另一个一维数组中
             * Exists           判断数组中是否包含指定的元素
             * GetLength        获取Array的指定维中元素数
             * GetLowerBound    获取Array中指定维度的下线
             * GetUpperBound    获取Array中指定维度的上限
             * GetValue         获取Array中指定位置的值
             * Reverse          反转一维Array中元素的顺序
             * SetValue         设置Array中指定位置的元素
             * Sort             对一维Array数组元素进行排序
             */
            var arr = new int[] { 1, 2, 3, 5, 4, 6 };
            var arr1 = new int[6];
            var arr2 = new int[20];
           Array.Copy(arr, arr1, 2); // 将元素组中的元素按照指定长度复制到目标数组中
           foreach (var item in arr1)
           {
               WriteLine(item);
           }
           WriteLine();
           arr.CopyTo(arr2, 1);
           foreach (var item in arr2)
           {
               Write($"{item} ");
           }
           WriteLine();
           
           WriteLine($"2是否存在于数组中{Array.Exists(arr, item => item == 2)}"); // 第一个参数是待查找的数组，第二个参数是回调函数
           WriteLine($"10是否存在于数组中{Array.Exists(arr, item => item == 10)}");
           var arr3 = new int[2, 3] {{1, 2, 3}, {4, 5, 6}};
           WriteLine($"arr3的第一维数：{arr3.GetLength(0)}");
           WriteLine($"arr3的第二维数：{arr3.GetLength(1)}");
           WriteLine($"arr3的指定第一维度的下限：{arr3.GetLowerBound(0)}");
           WriteLine($"arr3的指定第一维度的上限：{arr3.GetUpperBound(0)}");
           WriteLine($"arr3的指定第二维度的下限：{arr3.GetLowerBound(1)}");
           WriteLine($"arr3的指定第二维度的上限：{arr3.GetUpperBound(1)}");
           WriteLine($"获取指定位置的值: {arr3.GetValue(0, 1)}");
           var arr4 = new int[] { 1, 2, 4, 3, 6, 5 };
           var arr5 = arr4.Reverse(); // 反转数组
           foreach (var item in arr5)
           {
               Write($"{item} ");
           }
           Array.Sort(arr4);
           WriteLine();
           foreach (var item in arr4)
           {
               Write($"{item} ");
           }
           WriteLine();

           var arr6 = new int[2];
           arr6.SetValue(1, 0);
           arr6.SetValue(100, 1);
           foreach (var item in arr6)
           {
               Write($"{item} ");
           }
           
           var list = new List<string>(); // 定义一个list集合
           list.Add("零基础学C#"); // 向数组集合中添加元素
           list.Add("2本");
           list.Add("69.8");
           foreach (var item in list)
           {
               WriteLine($"{item}");
           }
           
           // 排序
           var list1 = new int[] {1, 2, 3, 5, 4};
           Array.Sort(list1);
           foreach (var item in list1)
           {
               Write($"{item} ");
           }
           WriteLine();
           // Sort(Array array, int index, int length)
           var list2 = new int[] {3, 2, 1, 6, 4, 5};
           Array.Sort(list2, 2, 4);
           foreach (var item in list2)
           {
               Write($"{item} ");
           }
           WriteLine();

           char[] charArray = { '时', '间', '就', '是', '金', '钱' };
           var str = new string(charArray, 4, 2);
           WriteLine($"str = {str}");

           const string str1 = "We are the world!";
           WriteLine(str1.IndexOf('e'));

           const string str2 = "梦想还是要有的，万一实现了呢！";
           WriteLine(str2.StartsWith("梦想")); // 判断str2是否以"梦想"开始
           WriteLine(str2.EndsWith("！")); // 判断str是否以"!"结束
           
           // 去除空格
           const string str3 = "   abc   ";
           WriteLine($"去除空格后:{str3.Trim()},测试");
           // 使用Trim()方法还可以从字符串的开头和结尾删除指定的字符
           char[] charsToTrim = { '*' }; // 定义要删除的字符数组
           const string str4 = "*****abc*****";
           var str5 = str4.Trim(charsToTrim); // 去掉字符串的首尾空格
           WriteLine($"去除*后的字符串: {str5}");
        }

        private static void Demo5()
        {
            var book = new Book();
            book.ShowInfo(new int[]{1950, 1960, 1970, 1980, 1990, 2000, 2010});
            WriteLine();
            book.ShowInfo(new string[]{"麦肯", "拉塞尔", "贾巴尔", "魔鸟", "乔丹", "邓肯", "詹姆斯"});
            WriteLine();
            WriteLine("{0} + {1} = {2}", 32, 23, book.Add(32, 23));
            
            /**
             * 权限修饰符
             * private              所有类或成员           能在本类中访问
             * protected            类和嵌入类的所有成员    在本类和其子类中访问
             * internal             类和嵌入类的所有成员    在同一程序集中访问
             * protected internal   类和内嵌类的所有成员    在同一程序集和子类中访问
             * public               所有类或者成员         任何代码都可以访问
             */
            
            var account = new CBank(); // 创建银行账户
            account.BankIn(new DateTime(2017, 05, 06), 2000); // 存入
            account.BankIn(new DateTime(2017, 05, 08), 3000); // 存入
            account.BankIn(new DateTime(2017, 06, 01), 5000); // 存入
            account.BankIn(new DateTime(2017, 06, 11), 1000); // 存入
            
            account.BankOut(new DateTime(2017, 07, 05), 200); // 取出
            account.BankOut(new DateTime(2017, 08, 02), 400); // 取出
            account.BankOut(new DateTime(2017, 09, 08), 600); // 取出
            account.BankOut(new DateTime(2017, 10, 01), 300); // 取出
            
            account.Display();
            
            /**
             * 方法中的参数
             * 1.值参数 -- 值参数就是在声明时不加修饰的参数，它声明实参与形参之间按值传递。
             * 2.ref参数 -- ref参数使形参按引用传递（即使形参是值类型），其效果是：在方法中对形参所做的任何更改都将反映到实参中。如果要使用ref参数，则方法声明和方法调用都必须显示使用ref关键字
             * 3.out参数 -- out关键字用来定义输出参数，它会导致参数通过引用来传递，这与ref关键字类似，不同之处在于:ref要求变量必须在传递之前进行赋值，而使用out关键字定义的参数，不用进行赋值即可使用。
             * 4.params参数 -- params参数是一个一维数组，主要用来指定在参数数据可变时采用的方法参数
             */
            var pro = new Program();
            var x = 30;
            const int y = 40;
            int z;
            WriteLine($"值参数的使用：{Program.Add(x, y)}");
            WriteLine($"值参数中实参X的值：{x}"); //输出值参数方法中实参x的值
            WriteLine($"ref参数的使用：{Program.Add(ref x, y)}");
            WriteLine($"ref参数中实参X的值：{x}"); //输出ref参数方法中实参x的值,ref会改变实参
            WriteLine($"out参数的使用：{Program.Add(x, y, out z)}");
            WriteLine($"params参数的使用：{Program.Add(20, 30, 40, 50, 60)}");
            WriteLine($"params参数的使用：{Program.Add(new int[] {1, 2, 3, 4, 5, 6})}");

            var theWater = new Water();
            WriteLine($"水池的水量：{Water.water}");
            theWater.InLet();
            theWater.InLet();
            WriteLine($"注入两次水后，水量：{Water.water}");
            theWater.OutLet();
            WriteLine($"水池放水一次后，水量:{Water.water}");
            
            var deposit = new Deposit();
            Deposit.CalculateInterest(10000, 10); // 存入1000元，存期10年
            Deposit.ChangeRate(5.2); // 调整利率为5.2%
            Deposit.CalculateInterest(10000, 10);

            var stockInfo = new CStockInfo(); // 创建CStockInfo对象
            stockInfo.FullName = "macbook pro";
            stockInfo.ShowGoods(); // 使用对象调用类成员方法
            
            var stockInfos = new CStockInfos("iPhone11", "BC9501", 200);
            stockInfos.ShowInfo(); // 显示构造函数中初始化的基本信息
            stockInfos.Name = "小米9S";
            stockInfos.TradeType = "Transport";
            stockInfos.Num = 1000;
            stockInfos.ShowInfo();
            
            // 使用无参构造函数
            var stockInfosOne = new CStockInfos();
            stockInfosOne.Name = "手机";
            stockInfosOne.TradeType = "SM8088";
            stockInfosOne.Num = 2000;
            stockInfosOne.ShowInfo();
            
            // 类的继承
            var jh = new JhInfo(); // 创建JhInfo对象
            jh.TradeCode = "OptiPlex7050";
            jh.FullName = "戴尔台式机电脑";
            jh.JhId = "JH00001";
            jh.ShowInfo();

            var sale = new Sale(); // 创建Sale对象
            sale.Sid = "XS00001";
            sale.TradeCode = "T100001";
            sale.FullName = "笔记本电脑";
            sale.ShowInfo();

            var pad = new Pad(); // 创建Pad对象
            WriteLine($"pad的屏幕是：{pad.Screen}");
            WriteLine($"pad的电池是：{pad.Battery}");
            pad.StartUp(); // 平板电脑类对象使用父类方法
            
            /**
             * 1.C#的继承只支持单继承，不支持多重继承，即在C#中一次只允许继承一个类，不能同时继承多个类
             * 2.在实现类的继承时，子类的可访问性一定要低于或者等于父类的可访问性
             * 3.子类重写父类的方法，如果想在子类中实现父类原有的方法，可以使用base关键字
             * base.property; // 调用父类的属性
             * base.method(); // 调用父类的方法
             */
            var myPad = new MyPad();
            myPad.SayHello();
            myPad.SayName();
        }

        private static void TestSwitch(string strNum)
        {
            switch (strNum)
            {
                case "体育类本科":
                    WriteLine("体育类本科录取分数线：280");
                    break;
                case "艺术类本科":
                    WriteLine("艺术类本科录取分数线：290");
                    break;
                case "民办本科":
                    WriteLine("民办本科录取分数线：350");
                    break;
                case "二本":
                    WriteLine("二本录取分数线：445");
                    break;
                case "一本":
                    WriteLine("一本录取分数线：555");
                    break;
                default:
                    WriteLine("查询信息有误");
                    break;
            }
        }

        private static decimal TestSwitch1(decimal total)
        {
            if (total < 200)
            {
                return total;
            } 
            else if (total >= 200 && total < 600)
            {
                return total * (decimal) 0.85;
            }
            else if (total >= 600 && total < 1000)
            {
                return total * (decimal) 0.7;
            }
            else
            {
                return total * (decimal) 0.6;
            }
        }

        private static decimal TestSwitch2(decimal x, string y, string z)
        {
            switch (y)
            {
                case "90":
                    return z == "user" ? x * (decimal) 6.8 * (decimal) (1 - 0.1) : x * (decimal) 6.8 * (decimal) (1 - 0.05);
                case "93":
                    return z == "user" ? x * (decimal) 6.42 * (decimal) (1 - 0.1) : x * (decimal) 6.42 * (decimal) (1 - 0.05);
                case "97":
                    return z == "user" ? x * (decimal) 7.02 * (decimal) (1 - 0.1) : x * (decimal) 7.02 * (decimal) (1 - 0.05);
                default:
                    return z == "user" ? x * (decimal) 5.75 * (decimal) (1 - 0.1) : x * (decimal) 5.75 * (decimal) (1 - 0.05);
            }
        }

        private static void Gauss()
        {
            var isNum = 1;
            var iSum = 0;
            while (isNum <= 100)
            {
                iSum += isNum;
                isNum++;
            }
            WriteLine("1到100的累加结果是：{0}", iSum);
        }

        private static void MinValue()
        {
            var n = 1;
            var total = 0;
            while (total <= 500)
            {
                total += n;
                n += 2;
            }
            WriteLine($"满足1 + 3 + 5 + ... + n > 500的最小正整数n是{n}");
        }

        private static int Factorial(int n)
        {
            // 计算阶乘
            var start = 1;
            var sum = 1;
            do
            {
                sum *= start;
                start++;
            } while (start <= n);
            return sum;
        }

        private static void MultiplicationTable()
        {
            // 9 * 9乘法口诀
            int iRow;
            for (iRow = 1; iRow < 10; iRow++)
            {
                int iColumn;
                for (iColumn = 1; iColumn < iRow; iColumn++)
                {
                    Write("{0} * {1} = {2}  ", iColumn, iRow, iRow * iColumn);
                }
                WriteLine();
            }
        }

        private static void Pyramid()
        {
            // 金字塔
            for (var i = 1; i <= 5; i++) // 输出5行的金字塔
            {
                for (var j = 1; j <= 5 - i; j++) // 控制每一行的空白位置
                {
                    Write(" ");
                }

                for (var k = 1; k <= 2 * i - 1; k++)
                {
                    Write("*");
                }
                
                WriteLine(); // 换行
            }
        }

        private static int Total(int max)
        {
            var iSum = 0;
            var iNum = 1;
            for (; iNum <= max; iNum++)
            {
                if (iNum % 2 == 1)
                {
                    continue;
                }

                iSum += iNum;
            }
            return iSum;
        }
        
        private static void Tran12306()
        {
            // 模拟客车售票系统
            Title = "简单客车售票系统"; // 设置控制台标题
            var zuo = new string[9, 4];
            var row = zuo.GetLength(0); // 获取二维数组的行数
            var column = zuo.GetLength(1); // 获取二维数组的列数
            WriteLine($"行数 = {row}, 列数 = {column}");
            for (var i = 0; i < zuo.GetLength(0); i++)
            {
                for (var j = 0; j < zuo.GetLength(1); j++)
                {
                    zuo[i, j] = "[有票]";
                    Write($"zuo[{i}, {j}] = {zuo[i, j]} ");
                }
                WriteLine();
            }

            var s = string.Empty; // 定义字符串变量
            while (true)
            {
                Clear(); // Console.Clear()方法清除控制台信息
                WriteLine("\n  简单客车售票系统  \n");
                for (var i = 0; i < row; i++)
                {
                    for (var j = 0; j < column; j++)
                    {
                        Write($"{zuo[i, j]} "); // 输出售票信息
                    }
                    WriteLine();
                }
                Write("请输入座位行号和列号（如：0, 1），输入q键退出：");
                s = ReadLine(); // 售票信息输入
                if (s == "q" || s == "Q") break; // 输入字符串"q"或"Q"退出系统
                var ss = s.Split(','); // 拆分字符串
                var one = int.Parse(ss[0]); // 获取座位行数
                var two = int.Parse(ss[1]); // 获取座位列数
                zuo[one, two] = "[已售]";
            }
        }
    }
}
