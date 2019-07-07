using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    /// <summary>
    /// 抽象成绩操作类，充当目标接口
    /// </summary>
    interface IScoreOperation
    {
        int[] Sort(int[] array);                        //成绩排序
        int Search(int[] array, int key);           //成绩查询
    }
}
