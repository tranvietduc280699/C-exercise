using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace lab07BaiTap03
{
    public class InvalidMarkException :Exception
    {
        public string IsValid { get; set; }
        public string Status { get; set; }
        public InvalidMarkException() : base() { }

        // Gọi base(message) để truyền thông báo lỗi vào lớp cha Exception
        public InvalidMarkException(string message, string isValid, string status) : base(message)
        {
            IsValid = isValid;
            Status = status;
        }
    }
}
