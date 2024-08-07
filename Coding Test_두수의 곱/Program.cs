namespace Coding_Test_두수의_곱
{
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                if (num1 == num2)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int num1 = 2;
            int num2 = 2;
            
            Console.WriteLine(solution.solution(num1, num2));
        }
    }
}
