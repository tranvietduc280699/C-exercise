namespace lab07BaiTap03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Nhập thông tin sinh viên:");
                Console.WriteLine("Nhập ID:");
                string idInput = Console.ReadLine();
                Console.WriteLine("Nhập tên:");
                string name = Console.ReadLine();
                Console.WriteLine("Nhập điểm lý thuyết:");
                double theoryMarkInput = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm thực hành:");
                double theoryMarkOutput = double.Parse(Console.ReadLine());
                Student student = new Student();
                student.Id = int.Parse(idInput);
                student.Name = name;
                student.TheoryMark = theoryMarkInput;
                student.LargeMark = theoryMarkOutput;
                student.GetStudentInfo();

            }
            catch (InvalidMarkException ex)
            {
                Console.WriteLine("\n[LỖI BẮT ĐƯỢC]");
                Console.WriteLine($"Message : {ex.Message}");
                Console.WriteLine($"IsValid : {ex.IsValid}");
                Console.WriteLine($"Status  : {ex.Status}");
            }

        }
    }
}
