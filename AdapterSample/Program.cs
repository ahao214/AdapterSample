﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace AdapterSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IScoreOperation operation;  //针对抽象目标接口编程

            // 读取配置文件
            string adapterType = ConfigurationManager.AppSettings["adapter"];
            //反射生成对象
            operation = (IScoreOperation)Assembly.Load("AdapterSample").CreateInstance(adapterType);

            int[] scores = { 98, 67, 45, 87, 78, 34 };  //定义成绩数组
            int[] result;
            int score;
            Console.WriteLine("程序排序结果:");
            result = operation.Sort(scores);

            //遍历输出成绩
            foreach (int i in result )
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.WriteLine("查找成绩90：");
            score = operation.Search(result, 90);
            if(score != -1)
            {
                Console.WriteLine("找到成绩90");
            }
            else
            {
                Console.WriteLine("没有找到成绩90");
            }

            Console.WriteLine("查找成绩87：");
            score = operation.Search(result, 87);
            if(score!=-1)
            {
                Console.WriteLine("找到成绩87");
            }
            else
            {
                Console.WriteLine("没有找到成绩87");
            }
            Console.ReadLine();

        }
    }
}
