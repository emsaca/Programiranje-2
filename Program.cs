namespace HanojskiStolpi
{
    internal class Program
    {
        //naloga 11
        static void Main(string[] args)
        {
            Hanoi(2, "a", "c", "b");
        }
        static void Hanoi(int n, string zač, string končni, string pomoč)
        {
            if (n == 1)
            {
                Console.WriteLine("premakni obroč iz " + zač + " na " + končni);
                return;
            }
            Hanoi(n - 1, zač, pomoč, končni);
            Console.WriteLine("premakni obroč iz " + zač + " na " + končni);
            Hanoi(n - 1, pomoč, končni, zač);
        }
        
    }
}
