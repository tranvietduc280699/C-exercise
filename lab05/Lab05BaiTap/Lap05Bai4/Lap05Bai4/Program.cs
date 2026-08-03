namespace Lap05Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Department department = new Department();
            
            department.nameDepartmet = "Phòng 201";
            department.employees = new Employee[]
            {
                new Employee("B22PCN010", "Manchester", 23),
                new Employee("B22PCN012", "Messi", 37),
                new Employee("B22PCN001", "Cr7", 37)
            };
            // hiển thị
            foreach(Employee obj in department.employees)
            {
                Console.WriteLine(obj.ShowInfo());
            }
            
        }
    }
}
