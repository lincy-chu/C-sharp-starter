namespace CSharpStarter
{
    public class Water
    {
        public static int water = 0;

        public void OutLet() // 放水，一次放出2个单位
        {
            if (water >= 2)
            {
                water -= 2;
            }
            else
            {
                water = 0;
            }
        }

        public void InLet() // 注水，一次注入3个单位
        {
            water += 3;
        }
    }
}