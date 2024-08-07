namespace CodingTest_몫_구하기
{
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = num1 / num2;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int num1 = 4;
            int num2 = 2;

            Console.WriteLine(solution.solution(num1, num2));
        }
    }
}
