/**
 * 电脑类
 */
using static System.Console;

namespace CSharpStarter
{
    public class Computers // 父类:电脑
    {
        public virtual void ShowPicture()
        {
            WriteLine("鼠标点击");
        }
    }

    public class Pads : Computers // 子类：平板电脑
    {
        public override void ShowPicture()
        {
            WriteLine("手指点击触摸屏");
        }
    }
}