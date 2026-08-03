namespace Lab01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // bài 1.1
            Console.WriteLine("Bài 1.1:");
            string kqua = @"
       ++++++++++                 ++++        ++++
     ++++++++++++++            ++++++++++++++++++++
    ++++        ++++          ++++++++++++++++++++
    ++++                        ++++      ++++
    ++++                       ++++     ++++
    ++++        ++++      ++++++++++++++++++++
     ++++++++++++++      ++++++++++++++++++++
       ++++++++++        ++++        ++++";

            Console.WriteLine(kqua);

            // bài 1.2
            Console.WriteLine("Bài 1.2:");
            String MaNv = "C012";
            String HovaTen ="Trần Việt Đức";
            String NgaySinh ="20061999";
            String DiaChi="Đông ngạc - Hà Nội";
            int Sdt = 1231321;
            String Email ="tranvietduc@gmail.com";
            Console.WriteLine($" {MaNv}\n {HovaTen}\n {NgaySinh}\n {DiaChi}\n {Sdt}\n {Email}\n");
        }
    }
}
