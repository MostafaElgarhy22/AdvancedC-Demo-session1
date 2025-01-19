namespace AdvancedC__Demo_session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 3;
            int B = 4;
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            Helper.Swap( ref A, ref B );
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
        }
    }
}
