public class Program
    {
        public static void Main(string[] args)
        {
            Question<int> Q1 = CreateQuestion();
            Q1.ShowQuestion();
            Q1.ShowAnswers();
        }
        public static Question<int> CreateQuestion()
        {
            // Random object
            Random rand = new Random();
            
            // Form the factors and products
            int num1 = rand.Next(0,11);
            int num2 = rand.Next(0,11);
            int product = num1 * num2;
           
            // Fill response array and randomly assign the correct answer.
            int[] responses = {num1,
                               num1 + num2,
                               num1 * num1,
                               num2 * rand.Next(0,6)};
            
            responses[rand.Next(0,4)] = product;
            
            // Form and return the finished question.
            Question<int> Q = new Question<int>("What is " + num1 + " times " + num2 + "?",
                                                responses[0],
                                                responses[1],
                                                responses[2],
                                                responses[3]);
            return Q;
        }
    }
