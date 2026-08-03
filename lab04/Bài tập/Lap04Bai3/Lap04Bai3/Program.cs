namespace Lap04Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Document dc = new Document("data");
            dc.Write("document.txt");
            dc.Read("document.txt");
            dc.Encrypt();
            dc.Decrypt();
        }
    }
}
