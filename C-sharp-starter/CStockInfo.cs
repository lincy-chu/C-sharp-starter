/**
 * 库存商品类
 */
using static System.Console;
namespace CSharpStarter
{
    public class CStockInfo
    {
        public string FullName // 自动实现属性
        {
            get;
            set;
        }

        public void ShowGoods()
        {
            WriteLine($"库存商品名称: {FullName}");
        }
    }
}