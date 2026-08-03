namespace lab04Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // khởi tạo hình chữ nhật
            Rectangle rec = new Rectangle();
            rec.InputData();

            // hiển thị thông tin
            Console.WriteLine($"Diện tích hình chữ nhật là: {rec.Area()}");
            Console.WriteLine($"Chu vi hình chữ nhật là: {rec.Circomference()}");
        }
    }
}
