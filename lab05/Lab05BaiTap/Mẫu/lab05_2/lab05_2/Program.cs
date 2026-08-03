namespace lab05_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            // khai báo mảng 2 chiều 4x3 với int ngẫu nhiên
            int[,] arr={
                {3,2,1 }, {4,1,6}, {5,6,7}, {6,4,1}, {7,2,9},
            };
            // duyệt mảng in theo hàng và cột
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"{arr[i, j]}");
                }
                
            }
            Console.WriteLine("============");
            // tìm phần tử có chỉ số hàng bằng chỉ số cột
            for(int i = 0;i<arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.WriteLine($"{arr[i,j]}");
                    }
                }
            }
            // tìm phần tử lớn nhất
            Console.WriteLine("============");
            int max = 0;
            for(int i = 0;i< arr.GetLength(0); i++)
            {
                for (int j = 0; j< arr.GetLength(1); j++)
                {
                    if(max < arr[i, j])
                    {
                        max = arr[i,j];
                    }
                }
                Console.WriteLine($"Phần tử lớn nhất là:{max}");
            }

        }
    }
}
