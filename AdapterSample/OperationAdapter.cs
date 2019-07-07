using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    /// <summary>
    /// 操作适配器，充当适配器
    /// </summary>
    class OperationAdapter : IScoreOperation
    {
        private QuickSortClass sortObj;
        private BinarySearchClass searchObj;

        public OperationAdapter()
        {
            sortObj = new QuickSortClass();
            searchObj = new BinarySearchClass();
        }

        public int Search(int[] array, int key)
        {
            //调用适配者类BinarySearchClass的查找方法
            return searchObj.BinarySearch(array, key);
        }

        public int[] Sort(int[] array)
        {
            //调用适配者类QuickSortClass的排序方法
            return sortObj.QuickSort(array);
        }
    }
}
