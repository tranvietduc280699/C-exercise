using System.Collections;

namespace lab06BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // tạo đối tuwowjgn hashtable với 8 key từ 1-> 8
            Hashtable htb = new Hashtable();
            htb.Add(1, "monday");
            htb.Add(2, "friday");
            htb.Add(3, "wednesday");
            htb.Add(4, "monday");
            htb.Add(5, "friday");
            htb.Add(6, "saturday");
            htb.Add(7, "sunday");
            // tìm tueday in ra thông báo nếu tìm thấy hoặc không
            if (!htb.ContainsValue("tueday"))
            {
                Console.WriteLine($"Không tồn tại tueday");
            }
            else
            {
                Console.WriteLine($"Có tồn tại tueday");
            }
            // in ra các ngày trong tuần
            foreach (var key in htb)
            {
                Console.WriteLine($"{key}");
            }
            foreach (DictionaryEntry item in htb)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }
        }
    }
}
