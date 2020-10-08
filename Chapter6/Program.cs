using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, 8, -1, 6, 4, };
            Console.WriteLine($"平均値：{ numbers.Average() }");
            Console.WriteLine($"合計値：{ numbers.Sum() }");
            Console.WriteLine($"最小値：{ numbers.Where(n => n > 0).Min() }");
            Console.WriteLine($"最大値：{ numbers.Max() }");

            bool exists = numbers.Any(n => n % 7 == 0);

            var results = numbers.Where(n => n > 0).Take(5);
            foreach (var result in results) {
                Console.Write(result + " ");
            }

            Console.WriteLine("\n-----------------");
            var books = Books.GetBooks();
            Console.WriteLine($"本の平均価格：{ books.Average(x => x.Price) }");
            Console.WriteLine($"本の合計価格：{ books.Sum(x => x.Price) }");
            Console.WriteLine($"本のページが最大：{ books.Max(x => x.Pages) }");
            Console.WriteLine($"高価な本：{ books.Max(x => x.Price) }");
            Console.WriteLine($"タイトルに「物語」がある冊数：{ books.Count(x => x.Title.Contains("物語")) }");

            //600ページを超える書籍があるか？（Anyメソッド）
            Console.WriteLine();//改行
            Console.Write("600ページを超える書籍は");
            Console.WriteLine(books.Any(x => x.Pages > 600) ? "ある" : "ない");

            //すべてが200ページ以上の書籍か？（Allメソッド）
            Console.WriteLine();//改行
            Console.Write("200ページ以上の書籍は");
            Console.WriteLine(books.All(x => x.Pages> 200) ? "あります" : "ありません");

            //400ページを超える本は何冊目か？（FirstOrDefaultメソッド）

            //var book = books.FirstOrDefault(x => x.Pages > 400);
            //int count;
            //for ( count = 0; i < books.Count; i++) {
            //    if (books[count].Title.Contains(book.Title)) {
            //        break;
            //    }
            //}

            var count = books.FindIndex(x => x.Pages > 1000);
            Console.WriteLine($"400ページを超える本は{count + 1}冊目です。");

            //本の値段が400円以上のものを3冊表示
            var book = books.Where(x => x.Price >= 400).Take(3);
            foreach (var item in book) {
                Console.WriteLine(item.Title + " ");
            }
        }
    }
}
