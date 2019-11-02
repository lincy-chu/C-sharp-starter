/**
 * 汽车类
 */
using static System.Console;

namespace CSharpStarter
{
    public class Vehicle
    {
        public string Name { get; set; }

        public virtual void Move() // 在C#中方法在默认情况下不是虚拟的，但（除构造函数外）可以显式声明为virtual，在方法前面加上关键字virtual，则称该方法为虚方法
        {
            WriteLine("{0}都可以移动", Name);
        }
    }

    public class Train : Vehicle
    {
        public override void Move() // 重写方法输出交通工具形态
        {
            WriteLine("{0}在铁轨上行驶", Name);
        }
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            WriteLine("{0}在公路上行驶", Name);
        }
    }
}