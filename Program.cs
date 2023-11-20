using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumHashMetohdApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = { 2, 7, 11, 15 };
            int target = 9;
                        
            Dictionary<int, int> numIndexMap = new Dictionary<int, int>();
            
            for(int i=0; i < myarray.Length; i++) 
            {
                int complement = target - myarray[i];

                if (numIndexMap.ContainsKey(complement))
                {
                    Console.WriteLine("Get Target two numbers: " + myarray[numIndexMap[complement]] + ", " + myarray[i]);
                    Console.ReadLine();
                    return; // 找到目標就結束程式
                }

                // 將當前數字及其索引添加到Dictionary中
                if (!numIndexMap.ContainsKey(myarray[i]))
                {
                    numIndexMap.Add(myarray[i], i);
                }
            }

            Console.WriteLine("Did not get Target two!");
            Console.ReadLine();
        }
    }
}
