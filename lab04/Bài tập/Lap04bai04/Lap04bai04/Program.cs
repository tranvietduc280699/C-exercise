namespace Lap04bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            // thông tin sinh viên
             Student student = new Student();
            student.name = "Trần Việt Đức";
            student.phone = "01088888888";
            student.email = "Đẹp Trai và chăm chỉ";

            Console.WriteLine(student);
            // factory
            F



        }
    }
}
