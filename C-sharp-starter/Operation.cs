namespace CSharpStarter
{
    public class Operation // 自定义名称为Operation的类
    {
        private readonly string _name;
        private readonly string _phone;

        public Operation(string name, string phone)
        {
            this._name = name;
            this._phone = phone;
        }

        public override string ToString()
        {
            return $"{this._name} - {this._phone}";
        }
    }
}