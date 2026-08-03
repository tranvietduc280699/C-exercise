using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04Bai1
{
    internal class Windowns
    {
        // public công cộng
        // privtae chỉ trong lớp
        // protected chỉ kế thừa mới sử dụng được
        //khai báo các trường
        protected int top { get; set; }
        protected int left { get; set; }
        // phương thức
        public Windowns()
        {

        }
        public Windowns(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        // method vẽ cửa sổ
        public virtual void DrawWindown()
        {
            Console.WriteLine($"Window: drawing windown at {top} {left}");
        }
    }
}
