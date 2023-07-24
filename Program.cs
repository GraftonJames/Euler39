// See https://projecteuler.net/problem=39
namespace euler_thirtynine {
    class Program {
        static void Main() {
            int[] sqaures = getSqaures(1000);
            int maxSols = 0;
            int maxP = 0;
            for (int i = 3 ; i < 1000; i++){
                int sols = getSolutionCount(i, sqaures);
                Console.WriteLine($"{sols} solutions for perimeter {i}");
                if (sols > maxSols ){
                    maxSols = sols;
                    maxP = i;
                }
                
            } 
            Console.WriteLine(maxP);
        }
        static int[] getSqaures(int max){
            List<int> output = new List<int>();
            for (int i = 1; i < max; i++){
                output.Add((int)Math.Pow(i,2));
            }
            return output.ToArray();
        }
        static int getSolutionCount(int perimeter, int[] squares)
        {
            int solutionsCount = 0;
            for (int i = 2; i < perimeter; i++){
                for (int j = 1; j < i; j++){
                    if ((perimeter - i - j >= 1 )&&(squares[i - 1] + squares[j - 1] == squares[(perimeter - i - j) - 1])){
                        solutionsCount += 1;
                    }
                }
            }
            return solutionsCount;
        }
    }
}