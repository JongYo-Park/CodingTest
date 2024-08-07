namespace CodingTest_두수의_합
{
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = num1 + num2;
                return answer;
            }
        }
            static void Main(string[] args)
        {
            Solution solution = new Solution();
            int num1 = 2;
            int num2 = 5;

            Console.WriteLine(solution.solution(num1, num2));
        }
    }
}
