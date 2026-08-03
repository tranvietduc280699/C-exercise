namespace Lab04Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Iperson ip = new Staff();
            object data = "Bách khoa";
            ip.Insert(data);
            ip.Delete(data);
            ip.Update(data);
            ip.Display(data);
            // khởi tạo sv
            Iperson st = new Student()
            {
                id = "S10",
                name = "Đức",
                age = 28

            };
            st.Display(st);
        }
    }
}
