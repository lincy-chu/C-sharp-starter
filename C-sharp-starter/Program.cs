using System.Linq;

namespace CSharpStarter
{
    public class Program
    {
        public static int Add(int x, int y) // 值参数
        {
            x += y; // 对x进行加y操作
            return x; // 返回x
        }

        public static int Add(ref int x, int y) // ref参数
        {
            x += y;
            return x;
        }

        public static int Add(int x, int y, out int z) // out参数
        {
            z = x + y;
            return z;
        }

        public static int Add(params int[] x) // params参数
        {
            return x.Sum();
        }
    }
}