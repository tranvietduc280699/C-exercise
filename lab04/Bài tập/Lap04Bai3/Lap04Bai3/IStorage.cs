using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04Bai3
{
    interface IStorage
    {
        public string data {  get; set; }
        // đọc dlieu
        public void Read(string fileName);
        // lưu nội dung

        public void Write(string fileName);

    }
}
