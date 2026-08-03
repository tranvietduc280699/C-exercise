using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lab03B01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            EmployeeModel emp = new EmployeeModel(1, "Đạt", 20020721,2, 6500000);

            emp.Display();

        }
      
    }
}
