namespace AdvancedC__Demo_session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Swap Example [Video 1]
            //int A = 3;    
            //int B = 4;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.Swap/*<int>*/(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");


            //object Point p01 = new Point(10, 20);  // Boxing
            //object Point p02 = new Point(50, 60);
            // Helper.Swap(ref p01, ref p02);
            #endregion

            #region Video 2

            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };

            //int reseult = Helper.LinearSearch(Numbers, 8);

            //Console.WriteLine($"index = {reseult}"); 
            #endregion

            #region Equality And GetHashCode [Video 3]

            //Employee employee1 = new Employee(10, "Ahmed", 6_000);
            //Employee employee2 = new Employee(10, "Ahmed", 6_000);
            //Console.WriteLine($"employee1.GetHashCode(): {employee1.GetHashCode()}");
            //Console.WriteLine($"employee2.GetHashCode(): {employee2.GetHashCode()}");

            //if(employee1 == employee2 )
            //    Console.WriteLine("Equals");
            //else
            //    Console.WriteLine("!Equals");

            //HashSet<Employee> employees = new HashSet<Employee>();
            //employees.Add(employee1);
            //employees.Add(employee2);

            //foreach(Employee emp in employees)
            //    Console.WriteLine(emp);

            //***************** HashTable Carry only Unique items *******************

            #endregion 


        }
    }
}
