/**
 * 工厂类
 */
using static System.Console;

namespace CSharpStarter
{
    public abstract class Factory
    {
        private string _name;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public abstract string Produce(); // 定义产品抽象类

        public abstract void ShowInfo(); // 定义信息输出抽象类
    }

    public class AutoPlant : Factory
    {
        private readonly string _productsName;

        public AutoPlant(string productsName)
        {
            this._productsName = productsName;
        }

        public override string Produce()
        {
            return this._productsName;
        }

        public override void ShowInfo()
        {
            WriteLine($"{this.GetName()}生产的是{this._productsName}");
        }
    }

    public class ShoeFactory : Factory
    {
        private readonly string _productsName;

        public ShoeFactory(string productsName)
        {
            this._productsName = productsName;
        }

        public override string Produce()
        {
            return this._productsName;
        }

        public override void ShowInfo()
        {
            WriteLine($"{this.GetName()}生产的是{this._productsName}");
        }
    }
}