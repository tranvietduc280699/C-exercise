namespace Lap05Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // khởi tạo mạng số nguyên 10 phần tử
            int[] arr = new int[] {18,3,2,7,4,5,9,12,32,10};
            // tìm phần tử nhỏ nhất của mảng
            int min = arr[1];
           for(int i = 0; i< arr.Length; i++)
            {
                if(min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Phần tử nhỏ nhất là: {min}");

            // đảo ngược mảng 
            Console.WriteLine("Giá trị đảo ngược mảng là:");
            for (int i = arr.Length - 1 ;i >= 0; i --)
            {
                Console.WriteLine($"{arr[i]}");
            }

            // sắp xếp phần tử của mảng
            
            for(int i = 0; i< arr.Length; i++)
            {
               for(int j = 0; j< arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }

            for(int i = 0; i< arr.Length; i++)
            {
                Console.WriteLine($"Giá trị tăng dần là:{arr[i]}");
            }

            // số nguyên tố : chỉ chia hết cho 1 và chính nó
            for(int i = 0; i< arr.Length; i++)
            {
                if (arr[i] < 2) continue;
                int dem = 0;


                for(int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j== 0)
                    {
                        dem++;

                    }
                }
                if(dem == 0)
                {
                    Console.WriteLine($"Số nguyên tố là: {arr[i]}");
                };
               

                // tính trung bình cộng trnog mảng
                int sum = 0;
                for(int g = 0; g< arr.Length; g++)
                {
                    sum += arr[g];
                }
                Console.WriteLine($"Trung bình cộng là: {sum / arr.Length}");

                // kiểm tra mảng xem có phải là âm dương đan xen nhau ko
                int flag = 0;
                for(int h = 0; h < arr.Length - 1; h++)
                {
                    
                    
                    
                    
                    if (arr[h] * arr[h + 1] >= 0)
                    {
                        flag = 1; break;
                    }   
                }
                if(flag == 0)
                {
                    Console.WriteLine("Xen kẽ nhau");
                }
                else
                {
                    Console.WriteLine("Không xen kỹ");
                }
  
            }

        }
    }
}
