namespace CodingTest_숫자_비교하기
{
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                if (num1 != num2)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int num1 = 3; 
            int num2 = 4;
            
            Console.WriteLine(solution.solution(num1, num2));
        }
    }
}
