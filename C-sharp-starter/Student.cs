/**
 * 学生类
 */
using static System.Console;

namespace CSharpStarter
{
    interface IPerson
    {
        string Name { get; set; } // 姓名属性
        int Age { get; set; } // 年龄属性
        void Speeks(); // 说话行为
        void Work(); // 工作行为
    }
    
    public class Student : IPerson // 定义学生类，继承自IPerson接口
    {
        private int _age; // 定义age字段，用来表示年龄
        public string Name { get; set; } // 实现Name属性

        public int Age // 实现Age属性
        {
            get => _age;
            set
            {
                if (_age > 0 && _age < 120) // 控制输入范围
                {
                    _age = value;
                }
            }
        }

        public void Speeks()
        {
            WriteLine($"{Name}: 老师好");
        }

        public void Work()
        {
            WriteLine($"{Name}同学开始记笔记");
        }
    }

    public class Teacher : IPerson // 定义老师类，继承自IPerson接口
    {
        private int _age;
        
        public string Name { get; set; }

        public int Age
        {
            get => _age;
            set
            {
                if (_age > 0 && _age < 120)
                {
                    _age = value;
                }
            }
        }
        
        public void Speeks()
        {
            WriteLine($"{Name}：同学们好");
        }

        public void Work()
        {
            WriteLine($"{Name}老师开始上课");
        }
    }
}