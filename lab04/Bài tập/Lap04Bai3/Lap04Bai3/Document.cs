using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lap04Bai3
{
    internal class Document : IStorage, IEncryptable
    {
        public string data { get; set; } = "Dữ liệu data";
        public Document(string data)
        {
            this.data = data;
        }

        public void Encrypt()
        {
            Console.WriteLine($"Dữ liệu đang được mã hóa:{data}");
        }
        public void Decrypt()
        {
            Console.WriteLine($"Dữ liệu đang được giải mã: {data}");
        }
        public void Read(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File không tồn tại");
                return;
            }
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    string fileData = sr.ReadToEnd();
                    Console.WriteLine($"Đọc dữ liệu từ file :{data}");
                }
            }
        }

        public void Write(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(data);
                    Console.WriteLine("Đã ghi nội dung đối tượng vào file thành công.");
                }
            }
        }
    }
}
