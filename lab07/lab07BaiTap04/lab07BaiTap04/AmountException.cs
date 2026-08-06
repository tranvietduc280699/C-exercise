using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07BaiTap04
{
    public class AmountException: Exception
    {
        public string IsValid { get; set; }
        public string Status { get; set; }

        public AmountException() : base() { }

        public AmountException(string message, string isValid, string status) : base(message)
        {
            IsValid = isValid;
            Status = status;
        }
    }
}
