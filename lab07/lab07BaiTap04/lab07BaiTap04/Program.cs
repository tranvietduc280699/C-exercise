using System;

namespace lab07BaiTap04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try { 

                Console.Write("Nhập tên giảng viên: ");
                string name = Console.ReadLine();

                Console.Write("Nhập lương ($): ");
                double salaryInput = double.Parse(Console.ReadLine());

                Console.Write("Nhập thưởng ($): ");
                double bonusInput = double.Parse(Console.ReadLine());

                Lecture lecture = new Lecture();
                lecture.Name = name;
                lecture.Salary = salaryInput;
                lecture.Bonus = bonusInput;

                Console.WriteLine(lecture.GetLectureInfo());
            }
            catch (AmountException ex)
            {
                Console.WriteLine("\n[LỖI BẮT ĐƯỢC]");
                Console.WriteLine($"Message : {ex.Message}");
                Console.WriteLine($"IsValid : {ex.IsValid}");
                Console.WriteLine($"Status  : {ex.Status}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nLỗi: Lương và thưởng phải nhập theo định dạng số!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nLỗi khác: {ex.Message}");
            }
        }
    }
}