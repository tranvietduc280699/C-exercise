using System.Collections;

namespace lab06BaiTap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khởi tạo danh danh dữ liệu gồm 10 car
            List<Car> cars = new List<Car>()
            {
                new Car("Toyota", "Red"),
                new Car("Honda", "Blue"),
                new Car("Ford", "Black"),
                new Car("Chevrolet", "White"),
                new Car("Nissan", "Silver"),
                new Car("BMW", "Gray"),
                new Car("Mercedes", "Green"),
                new Car("Audi", "Yellow"),
                new Car("Volkswagen", "red"),
                new Car("Hyundai", "Purple")
            };

            // xóa các car có màu red
            // cách 1
            for (int i = cars.Count - 1; i >= 0; i--)
            {
                if (cars[i].color.ToLower().Contains("red"))
                {
                    cars.RemoveAt(i); 
                }
                Console.WriteLine($"Tên: {cars[i].name} - Màu: {cars[i].color}");
            }
            // cách 2
            Console.WriteLine("Cách 2");
            cars.RemoveAll(a => a.color.ToLower().Contains("Red"));
            foreach (var item in cars)
            {
                Console.WriteLine($"Tên: {item.name} - Màu: {item.color}");
            }

            // danh sách các car là
            //Console.WriteLine("Danh sách các car là: ");
            //foreach (var item in cars)
            //{
            //    Console.WriteLine($"Tên: {item.name} - Màu: {item.color}");
            //}
        }
    }
}
