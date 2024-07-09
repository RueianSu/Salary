using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Program
    {
        /// <summary>
        /// 選擇性敘述的練習-Salary
        /// 輸入便利商店工讀生的工作時數，並計算其薪資。
        /// 60小時以內，時薪150元。
        /// 61~80小時，以時薪1.25倍計算。
        /// 81小時以上，以時薪1.5倍計算。
        /// 說明：薪資以累計方式計算。若工時為90小時，則薪資為60*150 + 20*150*1.25 + 10*150*1.5元。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            float allSalary = 0; // 全部金錢

            float hourlyRate = 150; // 基本時薪
            float rateL2 = 1.25f; // 61~80小時，以時薪1.25倍計算
            float rateL3 = 1.5f;  // 81小時以上，以時薪1.5倍計算

            Console.WriteLine("輸入便利商店工讀生的工作時數：");
            
            var isSalaryInt = Console.ReadLine();

            if (IsInteger(isSalaryInt, out int hours))
            {
                if (hours <= 60)
                {
                    allSalary = hours * hourlyRate;
                }
                else if (hours <= 80)
                {
                    allSalary = 60 * hourlyRate + (hours - 60) * hourlyRate * rateL2;
                }
                else
                {
                    allSalary = 60 * hourlyRate + (80 - 60) * hourlyRate * rateL2 + (hours - 80) * hourlyRate * rateL3;
                }
                Console.WriteLine($"薪資： {allSalary}");
            }
            else
            {
                Console.WriteLine("輸入錯誤：");
            }
            Console.Read();
        }

        static bool IsInteger(string input, out int number)
        {
            return int.TryParse(input, out number);
        }
    }
}
