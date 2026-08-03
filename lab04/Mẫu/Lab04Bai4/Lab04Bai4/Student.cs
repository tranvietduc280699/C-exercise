using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Bai4
{
    internal class Student: Iperson
    {
        public string id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public void Insert(object obj)
        {
            Console.WriteLine("đã lưu" + obj);
        }
        public void Update( object obj) { Console.WriteLine("đã cập nhật" + obj); }
        public void Delete(object obj) { Console.WriteLine("Delete" + obj); }
        public void Display(object obj)
        {
         
            Student st = (Student) obj;
            Console.WriteLine($"Id: {st.id}");
            Console.WriteLine($"name: {st.name}");
            Console.WriteLine($"age: {st.age}");

        }
    }
}
