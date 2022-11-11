using System;
using System.Collections.Generic;
using System.Text;

namespace HW001
{
    class Numbers
    {
        Random r = new Random();

        /// <summary>
        /// Заполнить List
        /// </summary>
        /// <returns></returns>
        public void Get100NumbersList(List<int> nums)
        {
            nums.Clear();
            for (int i = 0; i < 100; i++)
            {
                nums.Add(r.Next(101));
            }
        }

        /// <summary>
        /// Печатать List в консоль
        /// </summary>
        /// <param name="nums"></param>
        public void PrintList(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine($"{i} >> {nums[i]}");
            }
        }

        /// <summary>
        /// Возвращает целое число
        /// </summary>
        /// <returns></returns>
        public int GetNumber()
        {
            Console.WriteLine("Введите число: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Удаляет из List Все вхождения чисел из заданного промежутка
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void DeleteFromList(List<int> nums, int from, int to)
        {
            List<int> temp = new List<int>();
            foreach (var item in nums)
            {
                if (item <= from || item >= to)
                {
                    temp.Add(item);
                }
            }

            nums.Clear();

            foreach (var item in temp)
            {
                nums.Add(item);
            }
        }
    }
}
