/**
 * Computer类
 */
using static System.Console;

namespace CSharpStarter
{
    public class Computer
    {
        public string Screen = "液晶显示器"; // 属性：屏幕

        public void StartUp()
        {
            WriteLine("电脑正在关机，请稍等...");
        }
    }
    
    public class Pad : Computer
    {
        public string Battery = "5000毫安电池"; // 平板属性：电池
    }
}