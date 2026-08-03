namespace lab05_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khởi tạo đối tượng sinh viên
            Student st = new Student(3,2);
            st[0] = "Nam";
            st[0, 0] = 4;
            st[0, 1] = 6.0;
            st[1] = "Đức";
            st[1, 0] = 10;
            st[1, 1] = 9;
            st[2] = "Hạnh";
            st[2, 0] = 5;
            st[2, 1] = 7;
            // hiển thị thông tin
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Tên Sinh Viên:{st[i]}");
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Điểm : {st[i,j]}");
                }
            }

        }
    }
}
