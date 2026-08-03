using System.Collections;
using System.Diagnostics;

namespace lap06Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            List<Book> books = new List<Book>
            {
            new Book { Id = 1, Title = "Trì hoãn hôm nay", Author = "Author 1", Publisher = "Nhi đồng", Year = 2014, Price = 40000 },
            new Book { Id = 2, Title = "Tuổi trẻ", Author = "Author 2", Publisher = "Publisher 2", Year = 2021, Price = 77000 },
            new Book { Id = 3, Title = "Ngày hôm ấy", Author = "Author 3", Publisher = "Publisher 3", Year = 1980, Price = 13000 },
            new Book { Id = 4, Title = "Cô ấy", Author = "Author 4", Publisher = "Nhi đồng", Year = 1987, Price = 44000 },
            new Book { Id = 5, Title = "Tháng 4", Author = "Author 5", Publisher = "Publisher 5", Year = 1999, Price = 13300 },
            new Book { Id = 6, Title = "Conan", Author = "Author 6", Publisher = "Publisher 6", Year = 2014, Price = 55555 },
            new Book { Id = 7, Title = "Harry Potter", Author = "Author 7", Publisher = "Nhi đồng", Year = 2000, Price = 44000 },
            new Book { Id = 8, Title = "Đắc nhân tâm", Author = "Author 8", Publisher = "Publisher 8", Year = 1990, Price = 34000 },
            new Book { Id = 9, Title = "Tôi tài giỏi, bạn cũng thế", Author = "Author 9", Publisher = "Publisher 9", Year = 2010, Price = 22120 },
            new Book { Id = 10, Title = "Đời thay đổi khi chúng ta thay đổi", Author = "Author 10", Publisher = "Publisher 10", Year = 2015, Price = 12000 }
            };
            // in ra quyển sách tăng dần theo giá;
            Console.WriteLine("=============================");
            books.Sort((a,b) => a.Price.CompareTo(b.Price));
            foreach(var obj in books)
            {
                Console.WriteLine($"Tăng dần theo giá là: {obj.Title} có giá {obj.Price}");
            }

            // tìm giá trị title trùng với quyển sách nhập từ bàn phím
            Console.WriteLine("=============================");
            Console.WriteLine("Nhập tên sách cần tìm: ");
            string titleBook = Console.ReadLine();
            foreach(var obj in books)
            {
                if (obj.Title.ToLower().Contains(titleBook.ToLower()))
                {
                    Console.WriteLine($"Thông tin quyển sách đang tìm là:\n {obj.Title}\n Năm sản xuất:{obj.Year}\n Giá: {obj.Price}");
                }
            }

            // đưa ra quyển sách xuất bản 2014
            Console.WriteLine("=============================");
            Console.WriteLine($"Những quyển sách xuất bản năm 2014 là:\n");
            int count = 1;
            foreach (var obj in books)
            {
             
                if (obj.Year == 2014) {
                   
                    Console.Write(
                        $"STT: {count}\n"+
                        $"Tên sách: {obj.Title}\n" +
                        $"Năm xuất bản: {obj.Year}\n" +
                        $"Giá : {obj.Price}\n");
                    count++;
                }
            }

            // xóa những quyển sách thuộc nhà xuất bản nhi đồng
            books.RemoveAll(b => b.Publisher.ToLower().Contains("nhi đồng"));
            foreach (var obj in books)
            {
                Console.WriteLine($"- {obj.Title} (NXB: {obj.Publisher})");
            }

        } 
    }
}
