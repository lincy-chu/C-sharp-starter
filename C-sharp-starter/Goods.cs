/**
 * 类的继承
 */
using static System.Console;

namespace CSharpStarter
{
    public class Goods
    {
        public string TradeCode { get; set; } // 定义商品编号
        public string FullName { get; set; } // 定义商品名称
    }

    public partial class JhInfo : Goods
    {
        public string JhId { get; set; } // 定义进货编号

        public void ShowInfo() // 输出进货信息
        {
            WriteLine("进货编号：{0}\n商品编号：{1}\n商品名称：{2}", JhId, TradeCode, FullName);
        }
    }

    public class Sale : Goods
    {
        public string Sid { get; set; } // 定义销售编号

        public void ShowInfo() // 输出销售信息
        {
            WriteLine("销售编号: {0}，商品编号：{1}，商品名称：{2}", Sid, TradeCode, FullName);
        }
    }
}