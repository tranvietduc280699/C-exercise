using DongVat.AnCo;
using DongVat.AnTap;
using DongVat.AnThit;

namespace lab07BaiTap01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== NHÓM ĐỘNG VẬT ĂN CỎ ===");
            Bo bo = new Bo(1, "Bò Bê", 250.5);
            Trau trau = new Trau(2, "Trâu Rừng", 400.0);
            De de = new De(3, "Dê Núi", 45.2);

            bo.DisplayInfo();
            trau.DisplayInfo();
            de.DisplayInfo();

            Console.WriteLine("\n=== NHÓM ĐỘNG VẬT ĂN THỊT ===");
            CaSau caSau = new CaSau(4, "Cá Sấu Xiêm", 180.0);
            Ho ho = new Ho(5, "Hổ Sằn", 220.8);
            SuTu suTu = new SuTu(6, "Sư Tử Đực", 190.0);

            caSau.DisplayInfo();
            ho.DisplayInfo();
            suTu.DisplayInfo();

            Console.WriteLine("\n=== NHÓM ĐỘNG VẬT ĂN TẠP ===");
            Lợn lon = new Lợn(7, "Lợn Rừng", 85.0);
            lon.DisplayInfo();

            Console.ReadLine();
        }
    }
}
