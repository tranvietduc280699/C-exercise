using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04bai04
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        // ghi đè phương thức
        public override string ToString()
        {

            return $"[{this.GetType().Name}]\n" +
                   $"Name: {name}\n" +
                   $"Email: {email}";
        }

    }
}
