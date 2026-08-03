using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04Bai1
{
    internal class ListBox: Windowns
    {
        private string listBoxContents;

        // phương thức khởi tạo
        public ListBox(int top, int left, string contents): base(top,left)
        {
            listBoxContents = contents;
        }
        //ghi đè phương thức
        public override void DrawWindown()
        {
               base.DrawWindown();// gọi phương thức cơ sở
            Console.WriteLine($"writing string to the listbox: {listBoxContents}");
            
        }

        
    }
}
