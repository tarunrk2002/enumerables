using System.Diagnostics;

namespace enumerables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> a = abc();

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
        public static IEnumerable<int> abc() 
        {
            for (int i = 0; i < 10; i++)
            {
               yield return i;
            }
            
        }
    }
}
