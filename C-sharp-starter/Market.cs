/**
 * 商场抽象类
 */
using static System.Console;

namespace CSharpStarter
{
    public abstract class Market
    {
        public string Name { get; set; } // 商场名称
        public string Goods { get; set; } // 商品名称
        public abstract void Shop(); // 抽象方法，用来输出信息
    }

    public class WallMarket : Market // 继承抽象类
    {
        public override void Shop()
        {
            WriteLine("{0}购买{1}", Name, Goods);
        }
    }

    public class TaoBaoMarket : Market
    {
        public override void Shop()
        {
            WriteLine("{0}购买{1}", Name, Goods);
        }
    }
}