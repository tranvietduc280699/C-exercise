namespace Lap04Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CongNhan cn = new CongNhan( 23);
            cn.HienThi();
            Console.WriteLine($"Tính lương có giá trị là:{cn.TinhLuong()}");

            NhanVienBanHang nv = new NhanVienBanHang(5);
            nv.HienThi();
            Console.WriteLine($"Số lượng bán được * 2 là: {nv.TinhLuong()}");
            
            
        }
    }
}
