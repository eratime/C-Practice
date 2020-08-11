using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的身高：");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入您的体重：");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("您的身高为：{0} 你的体重为：{1}",height,weight);
            double bmi = weight / (height * height);
            Console.WriteLine("您的BMI指数为："+bmi);
            Console.Write("您的体重属于：");
            if (bmi < 18.5)
            {
                Console.WriteLine("体重过轻");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("正常范围");
            }
            else if (bmi >= 24.9 && bmi < 29.9)
            {
                Console.WriteLine("体重过重");
            }
            else if (bmi > 29.9)
            {
                Console.WriteLine("肥胖");
            }
            Console.ReadLine();
        }
    }

}
