using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4.Model
{
    internal class CheckAccount: Account
    {
        public decimal Feetransfer { get; set; } // phí giao dịch

        public CheckAccount() { }
        public CheckAccount(decimal feetransfer, decimal balane):base(balane)
        {
            this.Feetransfer = feetransfer;
        }

        // hàm kế thừa 
        public override void Deposit(decimal money)
        {
            if (money > 0)
            {
                // Thực hiện cộng tiền gửi trước
                Balance += money;
                // Mỗi khi gọi phương thức thành công thì trừ phí giao dịch
                Balance -= Feetransfer;
                Console.WriteLine($"[CheckAccount] Gửi tiền: +{money} thành công. Phí dịch vụ: -{Feetransfer}. Số dư mới: {Balance}");
            }
            else
            {
                Console.WriteLine("[CheckAccount] Thất bại: Số tiền gửi không hợp lệ.");
            }
        }
        // Ghi đè phương thức rút tiền WithDraw
        public override void WithDraw(decimal money)
        {
            // Điều kiện thành công: tiền rút > 0 VÀ tổng số tiền rút + phí dịch vụ không vượt quá số dư hiện tại
            if (money > 0 && (money + Feetransfer) < Balance)
            {
                Balance -= money;
                Balance -= Feetransfer;
                Console.WriteLine($"[CheckAccount] Rút tiền: -{money} thành công. Phí dịch vụ: -{Feetransfer}. Số dư mới: {Balance}");
            }
            else
            {
                Console.WriteLine("[CheckAccount] Thất bại: Số dư không đủ để thực hiện giao dịch và thanh toán phí.");
            }
        }

        // Ghi đè phương thức kiểm tra số dư GetBalance (vấn tin)
        public override decimal GetBalance()
        {
            // Theo đề bài: "mỗi khi gọi phương thức thành công thì số tiền trong tài khoản sẽ bị trừ [phí]"
            Balance -= Feetransfer;
            Console.WriteLine($"[CheckAccount] Thực hiện vấn tin tài khoản. Phí dịch vụ: -{Feetransfer}. Số dư còn lại: {Balance}");
            return Balance;
        }

    }
}
