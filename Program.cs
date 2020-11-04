using System;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var set1 = new Set<int>()
            {
                4,6,9,8,7
            };

            var set2 = new Set<int>()
            {
                6,1,3,2,5
            };

            var set3 = new Set<int>()
            {
                3,7,9
            };

            
            var union = Set<int>.Union(set1, set2);
            var difference = Set<int>.Difference(set1, set2);
            var intersection = Set<int>.Intersection(set1, set2);
            var subset1 = Set<int>.Subset(set3, set1);
            var subset2 = Set<int>.Subset(set3, set2);

         
            PrintSet(set1, "Первое множество: ");
            PrintSet(set2, "Второе множество: ");
            PrintSet(set3, "Третье множество: ");

            
            PrintSet(union, "Объединение первого и второго множества: ");
            PrintSet(difference, "Разность первого и второго множества: ");
            PrintSet(intersection, "Пересечение первого и второго множества: ");

          
            if (subset1)
            {
                Console.WriteLine("Третье является подмножеством первого.");
            }
            else
            {
                Console.WriteLine("Третье не является подмножеством первого.");
            }

            if (subset2)
            {
                Console.WriteLine("Третье является подмножеством второго.");
            }
            else
            {
                Console.WriteLine("Третье не является подмножеством второго.");
            }

            Console.ReadLine();
        }

        /// <summary>
                /// </summary>
        /// <param name="set"> </param>
        /// <param name="title"> </param>
        private static void PrintSet(Set<int> set, string title)
        {
            Console.Write(title);
            foreach (var item in set)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}