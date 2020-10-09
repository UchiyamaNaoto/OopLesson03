using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            Exercise1_1(numbers);
            Console.WriteLine("-----");
            Exercise1_2(numbers);
            Console.WriteLine("-----");
            Exercise1_3(numbers);
            Console.WriteLine("-----");
            Exercise1_4(numbers);
            Console.WriteLine("-----");
            Exercise1_5(numbers);
        }
        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }
        private static void Exercise1_2(int[] numbers) {
            int pos = numbers.Length - 2;
            foreach (var number in numbers.Skip(pos)){
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        private static void Exercise1_3(int[] numbers) {
            var strNums = numbers.Select(n => n.ToString());
            foreach (var str in strNums) {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }

        private static void Exercise1_4(int[] numbers) {
            foreach (var number in numbers.OrderBy(n=>n).Take(3)) {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        private static void Exercise1_5(int[] numbers) {
            Console.WriteLine(numbers.Distinct().Count(n => n > 10));
        }
    }
}
