using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04Bai1
{
    internal class Button: Windowns
    {
        public Button(int top, int left): base(top,left) //gọi phương thức lớp cơ sở
        {

        }
        // ghi đè phương thức
        public override void DrawWindown()
        {
            Console.WriteLine($"Drawing a button at {top} {left}");
        }

    }
}
