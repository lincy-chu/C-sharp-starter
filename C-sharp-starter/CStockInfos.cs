/**
 * 商品类
 */
using static System.Console;

namespace CSharpStarter
{
    public class CStockInfos
    {
        private int num = 0; // 声明一个私有变量，用来表示变量
        public string Name { get; set; } // 名称属性，自动实现属性
        public string TradeType { get; set; } // 星号属性，自动实现属性

        public int Num
        {
            get => num;
            set
            {
                if (value > 0 && value <= 10000) // 控制数量在0-1000之间
                {
                    num = value;
                }
                else
                {
                    WriteLine("商品数量有误，需在0~1000之间！");
                }
            }
        }

        public CStockInfos() // 定义无参构造函数
        {
        }

        public CStockInfos(string name, string tradeType, int num) // 定义有参构造函数，用来初始化属性
        {
            Name = name;
            TradeType = tradeType;
            Num = num;
        }

        public void ShowInfo() // 定义库存显示方法
        {
            WriteLine("仓库中存在{0}型号{1} {2}台", TradeType, Name, Num);
        }
    }
}