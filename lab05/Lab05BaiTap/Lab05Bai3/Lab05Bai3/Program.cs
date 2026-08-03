namespace Lab05Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // khai báo 2 mảng
            string[] CAN =
            {
                "Giáp" , "Ất" ,"Bính", "Đinh" ,"Mậu", "Kỷ", "Canh", "Tân", "Nhâm","Quý"
            };
            string[] CHI =
            {
                "Tí" ,"Sửu" ,"Dần", "Mão", "Thìn", "Tị", "Ngọ","Mùi", "Thân" ,"Dậu", "Tuất" ," Hợi"
            };
            // theo lịch âm thì mỗi năm Can + chi (ví dụ : Giáp Tí)
            // Giả sử 2010 là năm Canh dần
            // Nhập năm bất kỳ và in ra năm âm tương ứng

            // nhập số năm
            Console.WriteLine("Nhập năm:");
            int year = int.Parse(Console.ReadLine());
            // tính số năm từ mốc
            int yearSum = year - 2010;
            int indexCAN = yearSum % CAN.Length;
            string format = " ";
            // lấy vị trí của CAN
            for (int i = 0; i < CAN.GetLength(0); i++)
            {
                if (indexCAN == i)
                {
                    format += CAN[i]; break;
                }
            }
            format += " ";
            int indexChi = yearSum % CHI.Length;
            // lấy vị trí của chi
            for(int j = 0;j < CHI.GetLength(0); j++)
            {
                if (indexCAN == j)
                {
                    format += CHI[j]; break;
                }
            }
                
            Console.WriteLine($"Năm âm là : {format}");
        }
    }
}
