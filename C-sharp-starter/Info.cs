/**
 * 接口中的成员默认是公共的，因此，不允许加访问修饰符
 *
 * 接口的实现通过类继承来实现，一个类虽然只能继承一个基类，但可以继承任何多个接口。声明实现接口的类时，需要在继承列表中包含所实现的接口的名称，多个接口之间用逗号分隔
 */

namespace CSharpStarter
{
    public interface INfo // 定义接口
    {
        string Code { get; set; } // 编号属性及实现
        string Name { get; set; } // 名称属性及实现
        void ShowInfo(); // 用来输出信息
    }
}