using System;

namespace RandomStatsGenerator {
    class RandomStatsGenerator {

        
        public void GenerateRandomNumbers(int N) {
            double[] result = new double[N];  
            Random rand = new Random();
            double resultSum = 0;

            for (int i = 0; i < N; i++) {
                result[i] = rand.Next(100);
                Console.WriteLine("Random #{0} : {1}", i, result[i]);
                resultSum += result[i];    
            };   
            
            Console.WriteLine("Sum : {0}", resultSum);
            Console.WriteLine("Mean : {0}", resultSum / N);

            double stdDev = 0;
            foreach (double n in result) {
                stdDev += (((resultSum / N) - n)/N);
            };

            Console.WriteLine("StdDev : {0}", stdDev);
            Console.WriteLine("Variance : {0}", stdDev*stdDev);
        }

        static void Main (string[] args) {
            RandomStatsGenerator x = new RandomStatsGenerator();
            x.GenerateRandomNumbers(25); 
        
            Console.ReadKey();
        }
    }

}