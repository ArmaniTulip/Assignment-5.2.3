namespace Assignment_5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackWardsCount(10);
        }

        static void BackWardsCount(int n)
        {
            if (n > 0 )
            {
                Console.WriteLine(n);
                BackWardsCount(n - 1);
            }
            
        }
    }
}
