using System;
using System.Collections.Generic;
using System.Text;

namespace HW003
{
    public static class Set
    {
        /// <summary>
        /// Объединение HashSet'ов
        /// </summary>
        /// <param name="hashSetBase"></param>
        /// <param name="addedSet"></param>
        public static void HashUnion(HashSet<int> hashSetBase, HashSet<int> addedSet)
        {
            hashSetBase.UnionWith(addedSet);
        }

        /// <summary>
        /// Удаление HashSet из HashSet
        /// </summary>
        /// <param name="hashSetBase"></param>
        /// <param name="addedSet"></param>
        public static void HashRemove(HashSet<int> hashSetBase, HashSet<int> addedSet)
        {
            hashSetBase.ExceptWith(addedSet);
        }

        /// <summary>
        /// Печатает HashSet в консоль
        /// </summary>
        /// <param name="hashSet"></param>
        public static void PrintHashSet(HashSet<int> hashSet)
        {
            foreach (var item in hashSet)
            {
                Console.Write($"{item} >> ");
            }
            Console.WriteLine();
        }
    }
}
