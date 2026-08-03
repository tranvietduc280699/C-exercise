using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4.Model
{
    internal class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // cho phép truy cập và tính toán trực tiếp
        protected decimal Balance { get; set; }

        // constructor
        public Account() { }
        public Account(int Id, string Name, decimal Balane)
        {
            this.Id = Id;
            this.Name = Name;   
            this.Balance = Balane;
        }
        // hàm khởi tạo nhận giá trị
        public Account(decimal initialize)
        {
            this.Balance = initialize;
        }
        // hàm tính tổng tiền gửi + gốc
        public virtual void Deposit(decimal money) {
            if (money > 0)
            {
                Balance += money;
                Console.WriteLine($"Gửi tiền thành công: {money},Số dư hiện tại là: {Balance}");
            }
            else
            {
                Balance = 0;
                Console.WriteLine("Vui lòng nhập số tiền.");
            }

        }
        // hàm rút tiền
        public virtual void WithDraw(decimal money) {
            if (money > 0)
            {
                Balance -= money;
                Console.WriteLine($"Rút tiền thành công: {money},Số dư còn lại là: {Balance}");
            }
            else
            {
                Balance = 0;
                Console.WriteLine("Vui lòng nhập số tiền.");
            }
        }
        // trả về số tiền trong tài khoản
        public virtual decimal GetBalance() { 
            return Balance;
        }
    }
}
