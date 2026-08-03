namespace lab05Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // khai báo và khởi tạo mảng 2 chiều (4X4)
            int[,] arr= new int[4,4] 
             {
                { 8, 21, 3, 4  },
                { 42, 2, 30,5 },
                { 1, 10, 9,6 },
                { 11, 27, 3,7 }
            };

            // in mảng theo hàng và cột
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+ " ");
                }
                Console.WriteLine();

            }
            // tính tổng các phần tử mà có chỉ số hàng = chỉ số cột 
            // tổng đường chéo chính
            int tong = 0;
            for (int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        tong += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Tổng phần tử là: {tong}");

            // in ra các phần tử nhỏ nhất trên cột
            for (int j = 0; j< arr.GetLength(0); j++)
            {
                int min = arr[0,j];
                for (int i = 1; i < arr.GetLength(1); i++)
                {
                    if (arr[i,j] < min)
                    {
                        min = arr[i, j];
                    }
                }
                Console.WriteLine($"Phần tử nhỏ nhất của Hàng {j} là: {min}");
            }

            // liệt kê các phần tử chia hêt cho 7
            Console.WriteLine(" ");
            Console.Write("Phần tử chia hết cho 7 là :");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] % 7 == 0)
                    {
                        Console.Write($"{arr[i, j]}" + " ");
                    }
                }
            }
            Console.WriteLine(" ");

            // tìm tổng các phần tử nằm trên đường viền của mảng
            int sumRowFirt = 0;
            int sumRowEnd = 0;
            int sumColumnFirt = 0;
            int sumColumnEnd = 0;
            int lastColIndex = arr.GetLength(1) - 1; // cột cuối
            for (int i = 0; i<arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    // hàng đầu tiên
                    if( i == 0)
                    {
                        sumRowFirt += arr[i,j];
                    };
                    // hàng cuối cùng
                    if(i == 3)
                    {
                        sumRowEnd += arr[i,j];
                    }
                    // cột đầu tiên
                    if(j == 0)
                    {
                        sumColumnFirt += arr[i,j];
                    }
                    if(j == lastColIndex)
                    {
                        sumColumnEnd += arr[i,j];
                    }

                }
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Tổng của hàng đầu tiên là: {sumRowFirt}");
            Console.WriteLine($"Tổng của hàng cuối là: {sumRowEnd}");
            Console.WriteLine($"Tổng của cột đầu tiên là: {sumColumnFirt}");
            Console.WriteLine($"Tổng của cột cuối là: {sumColumnEnd}");

            // chuyển thành mảng 1 chiều rồi sắp xếp tăng dần
            int[] arrOne = new int[arr.Length];
            int index = 0;
            int sumArrOne = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0;j < arr.GetLength(1); j++)
                {
                    arrOne[index] = arr[i, j];
                    index++;
                }
            }
            for(int i = 0; i < arrOne.Length; i++)
            {
                sumArrOne += arrOne[i];
                
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Tổng của mảng 1 chiều là: {sumArrOne}");

        }
    }
}
