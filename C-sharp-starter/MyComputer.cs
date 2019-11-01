/**
 * 电脑类
 * 继承和使用父类属性、方法
 */
using static System.Console;

namespace CSharpStarter
{
    public class MyComputer
    {
        public string Name = "MyComputer";

        protected string SayHello()
        {
            return "欢迎使用";
        }
    }

    public class MyPad : MyComputer
    {
        private new const string Name = "MyPad";

        public new void SayHello() // 子类重写父类方法
        {
            WriteLine(base.SayHello() + "平板电脑"); // 调用父类方法，在结果后添加字符串
        }

        public void SayName()
        {
            WriteLine($"父类的Name = {base.Name},子类的Name = {Name}.");
        }
    }
}