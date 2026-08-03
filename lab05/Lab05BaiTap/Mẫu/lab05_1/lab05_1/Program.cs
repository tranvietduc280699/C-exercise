namespace lab05_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // khai báo mảng
            int[] arr = new int[] { 5,8,3,0,4,1,7,9,2 };
            Console.WriteLine("Mảng có các giá trị là:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            // tìm phần tử lớn nhất
            int max = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i]; 
                }
            }
            Console.WriteLine($"Phần tử lớn nhất là:{max}");
            // kiểm tra mảng có đối xứng không
            int giua = arr.Length / 2;
            Boolean check = true;
            for(int i = 0; i <= giua; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    check = false;
                }
            }
            if (check)
            {
                Console.WriteLine("Mảng đối xứng");
            }
            else
            {
                Console.WriteLine("Không phải mảng đối xứng");
            }
        }
    }
}
