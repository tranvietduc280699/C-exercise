using System.Runtime.CompilerServices;

namespace Lab02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ////==================================================================================================
            //// bài 1:
            //Console.WriteLine("Nhập mã định danh theo id: ");
            //String Id = Console.ReadLine();
            //Console.WriteLine("Nhập tên: ");
            //String Name = Console.ReadLine();
            //Console.WriteLine("Nhập địa chỉ: ");
            //String Address = Console.ReadLine();
            //Console.WriteLine("Nhập ngày sinh: ");
            //String Birtday = Console.ReadLine();
            //Console.WriteLine("Nhập tiền lương: ");
            //float Salary = float.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập bonus: ");
            //float Bonus = float.Parse(Console.ReadLine());
            //float TotalSalary = Salary + Bonus;

            //Console.WriteLine($"Tên: {Name}\nĐịa chỉ: {Address}\n" +
            //    $"Sinh ngày: {Birtday}\nTiền lương: {Salary}\nTiền bonus:{Bonus}\nTổng số tiền là: {TotalSalary}");

            ////==================================================================================================
            ////Console.WriteLine("Bài 2:");
            //// nhập năm tháng in ra số ngày
            //Console.WriteLine("Nhập tháng: ");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập năm: ");
            //String year = Console.ReadLine();
            //string date = "";
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //        date = "31";
            //        break;
            //    case 2:
            //        date = "29";
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        date = "30";
            //        break;
            //    default:
            //        Console.WriteLine("Nhập tháng không hợp lệ.");
            //        break;
            //}
            //Console.WriteLine($"Tổng số ngày trong tháng {month} là: {date}");

            ////==================================================================================================
            //// bài 3: nhập vào số nguyên dương giây, in ra định dạng hh:mm:ss (00:05:50)
            ////1 giờ = 60 phút, 1 giờ = 3600 giây
            ////1 phút = 60 giây
            //int hh = 0;
            //int mm = 0;
            //Console.Write("Nhập số giây: ");
            //int ss = int.Parse(Console.ReadLine());
            //if (ss != 0)
            //{
            //    for (int i = 60; i < ss; i++)
            //    {
            //        if (ss > 60)
            //        {
            //            mm = ss / 60;
            //            ss = ss % 60;
            //        }
            //        else
            //        {
            //            mm = 00;
            //            ss = ss;
            //        }
            //    }
            //}
            //if (mm != 0)
            //{
            //    if (mm >= 60)
            //    {
            //        hh = mm / 60;
            //        mm = mm % 60;
            //    }
            //    else
            //    {
            //        hh = 00;
            //        mm = mm;
            //    }
            //}
            //// convert định dạnh 
            //string hhStr = (hh < 10) ? "0" + hh.ToString() : hh.ToString();
            //string mmStr = (mm < 10) ? "0" + mm.ToString() : mm.ToString();
            //string ssStr = (ss < 10) ? "0" + ss.ToString() : ss.ToString();
            //// convert cách 2
            ////string convert = $"{hh:D2}:{mm:D2}:{ss:D2}";
            ////Console.WriteLine(convert);

            //Console.WriteLine($"giờ/phút/giây: {hhStr}:{mmStr}:{ssStr} ");

            //// ==================================================================================================
            //// bài 4: in ra các số tổng 3 chữ số từ 100 - 999
            //int start = 100;
            //int end = 999;
            //for (int i = start; i <= end; i++)
            //{
            //    int HangTram = i / 100; // lấy số đầu tiên hàng trăm
            //    int HangChuc = (i / 10) % 10; // lấy số thứ 2 hàng chục
            //    int HangDonVi = i % 10; // lấy số thứ 3 hàng đơn vị
            //    int Tong = HangTram + HangChuc + HangDonVi;
            //    Console.WriteLine($"Số {i} có tổng 3 chữ số là: {Tong}");
            //}

            ////==================================================================================================
            //// bài 5: in ra các hình
            //// hình 1
            //string output1 = " ";
            //string output2 = " ";
            //string output3 = " ";
            //for (int i = 0; i < 6; i++)
            //{
            //    if (i == 0)
            //    {
            //        output1 = "*";
            //    }
            //    else
            //    {
            //        output1 += "*";
            //    }
            //    Console.WriteLine(output1);
            //}
            //// hình 2
            //for (int i = 6; i >= 0; i--)
            //{
            //    output2 = " ";
            //    for (int j = 0; j < i; j++)
            //    {
            //        output2 += "&";
            //    }
            //    Console.WriteLine(output2);
            //}
            ////hình 3
            //for (int i = 1; i <= 11; i++)
            //{

            //    // lấy giá trị lẻ
            //    if (i % 2 != 0)
            //    {
            //        output3 = "";
            //        int max = (11 - i) / 2;
            //        // lấy giá trị rỗng dự vào output3
            //        for (int k = 0; k < max; k++)
            //        {
            //            output3 += " ";
            //        }
            //        // lấy giá trị từ 1 đến i  và in ra dấu *
            //        for (int j = 0; j < i; j++)
            //        {
            //            output3 += "*";
            //        }
            //        Console.WriteLine(output3);
            //    }

            //}

            ////==============================================================================
            //// bài 6: xét a b c có tạo thành độ dài 3 cạnh tam giác không,
            //// tam giác cân a = b và b = c
            //// tam giác đền a = b = c
            //// ko phải tam giác a + b <= c
            //// tam giác vuông a^2 + b^2 = c^2
            ////tam giác nhọn a^2 + b^2 > c^2
            //// tam giác tù a^2 + b^2 < c^2
            //Console.WriteLine("Nhập số nguyên a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập vào số nguyên b: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập vào số nguyên c: ");
            //int c = int.Parse(Console.ReadLine());
            ////tính bình phương 2 cạnh
            //int TBP = (a ^ 2) + (b ^ 2);

            //// xét tam giác cân
            //if (a == b & b == c)
            //{
            //    Console.WriteLine("Tam giác cân.");
            //}
            //else if (a == b & a == c & b == c)
            //{
            //    Console.WriteLine("Tam giác đều.");
            //}
            //else if (TBP == (c ^ 2))
            //{
            //    Console.WriteLine("Tam giác vuông.");
            //}
            //else if (TBP > (c ^ 2))
            //{
            //    Console.WriteLine("Tam giác nhọn.");
            //}
            //else if (TBP < (c ^ 2))
            //{
            //    Console.WriteLine("Tam giác tù.");
            //}
            //else
            //{
            //    Console.WriteLine("Không phải tam giác.");
            //}

            ////==============================================================================
            //// bài 7 hình 
            //string set = " ";
            //int Cao = 11;
            //int Rong = 19;
            //for (int i = 0; i < Cao; i++)
            //{

            //    // sét độ rỗng của hình
            //    set = " ";
            //    int max = Cao - 1 - i;
            //    for (int j = 0; j < max; j++)
            //    {
            //        set += " ";
            //    }
            //    // lấy từ 1-> 9 theo thứ tự tăng giần
            //    for (int k = 0; k < i; k++)
            //    {
            //        set += (i + k) % 10;
            //    }
            //    // set mặt ngược lại
            //    for (int k = i; k > 1; k--)
            //    {
            //        set += (i + k - 2) % 10;
            //    }
            //    Console.WriteLine(set);

            //}

            // bài 8:


            // tính lãi suất tháng:
            Console.WriteLine("Nhập số tiền gửi: ");
            float TienGui = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lãi suất năm: ");
            float LaiSuatNam =  float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tháng gửi: ");
            int SoThang = int.Parse(Console.ReadLine());

            // tính lãi suất tháng:
            float Lsthang = (LaiSuatNam / 12) / 100;
            // tiền lãi theo tháng
            float TlThang = TienGui * Lsthang;
            // tổng lãi suất và tiền gửi:
            float TongTien = TienGui + TlThang;
            Console.WriteLine("Tổng tiền gửi sau " + SoThang + " tháng là: " + TongTien);

        }
}}
