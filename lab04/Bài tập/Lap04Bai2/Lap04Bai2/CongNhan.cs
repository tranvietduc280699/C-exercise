using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04Bai2
{
    internal class CongNhan: NhanVien
    {
        public int soLuongSanPham { get; set; }
        public CongNhan(int soLuongSanPham) 
        {
            this.soLuongSanPham = soLuongSanPham;
        
        }

        public override void HienThi()
        {
            Console.WriteLine($"Số lượng sản phẩm là: {soLuongSanPham}");
        }

        public override float TinhLuong()
        {
            return soLuongSanPham * 2;
        }
    }
}
