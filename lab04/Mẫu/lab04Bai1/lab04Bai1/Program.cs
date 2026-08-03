using System.Runtime.CompilerServices;

namespace lab04Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            // khởi tạo
            Windowns wd = new Windowns(1,2);

           

            ListBox lb = new ListBox(3,4,"đây là giá trị truyền vào cho listbox");
            
            Button bt = new Button(5,6);
            // hiển thị
            wd.DrawWindown();
            lb.DrawWindown();
            bt.DrawWindown();

            // khởi tạo mảng
            object a = new object();
            Windowns[] wdArr = new Windowns[3];
            wdArr[0] = new Windowns(1,2);
            wdArr[1] = new ListBox(2,3,"list box in array");
            wdArr[2] = new Button(4, 5);
            for(int i = 0; i< 3; i++)
            {
                wdArr[i].DrawWindown();
            }


            
        }
    }
}
