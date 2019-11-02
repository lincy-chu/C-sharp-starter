/**
 * People类
 */
using static System.Console;

namespace CSharpStarter
{
    public class People
    {
        public virtual void Say(string name) // 定义一个虚方法，用来表示人的说话行为
        {
            WriteLine(name); // 输出人的名字
        }
    }

    public class Chinese : People // 定义派生类，继承于People类
    {
        public override void Say(string name) // 重写基类中的虚方法
        {
            base.Say($"{name}说汉语!");
        }
    }

    public class American : People // 定义派生类，继承于People
    {
        public override void Say(string name) // 重写基类中的虚方法
        {
            base.Say($"{name}说英语!");
        }
    }
}