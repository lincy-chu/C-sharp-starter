/**
 * 信息抽象类
 */
using static System.Console;

namespace CSharpStarter
{
    public abstract class Information // 定义抽象类
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public abstract void ShowInfo(); // 抽象方法，用来输出信息
    }

    public class JhInfos : Information
    {
        public override void ShowInfo()
        {
            WriteLine("进货信息：{0} {1}", Code, Name);
        }
    }

    public class XsInfo : Information
    {
        public override void ShowInfo()
        {
            WriteLine("销售信息: {0} {1}", Code, Name);
        }
    }
}