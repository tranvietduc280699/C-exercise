namespace lab07BaiTap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //
            try
            {
                Console.WriteLine("Nhập Mã:");
                string ma = Console.ReadLine();
                if (string.IsNullOrEmpty(ma))
                {
                    throw new Exception("Mã không được để trống.");
                }
                // lỗi
                object obj = ma;
                DateTime date = (DateTime)obj;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Lỗi nhập liệu: {ex.Message}");
            }

            //
            try
            {
                Console.WriteLine("Nhập tên:");
                string ten = Console.ReadLine();
                if (string.IsNullOrEmpty(ten))
                {
                    throw new Exception("Tên không được để trống.");
                }
                //lỗi
                string[] arrTen = new string[2];
                arrTen[0] = ten;
                string value = arrTen[5];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Lỗi nhập liệu: {ex.Message}");

            }

            //
            try
            {
                Console.WriteLine("Nhập tuổi:");
                string tuoi = Console.ReadLine();
                if (string.IsNullOrEmpty(tuoi))
                {
                    throw new Exception("Tên không được để trống.");
                }
                // lỗi
                string[] stringArray = new string[5];
                object[] objectArray = stringArray;
                objectArray[0] = int.Parse(tuoi);
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine($"[Đã bắt thành công]: {ex.GetType().Name} - {ex.Message}\n");
            }
        }
        
    }
}
