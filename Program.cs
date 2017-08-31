public class Program
    {
        public static void Main(string[] args)
        {
            Question Q1 = CreateQuestion();
            Q1.ShowQuestion();
            Q1.ShowAnswers();
        }
        public static Question CreateQuestion()
        {
            // Random object
            Random rand = new Random();
            
            // Form the factors and products
            int num1 = rand.Next(0,11);
            int num2 = rand.Next(0,11);
            Response<int> product =  new Response<int>(num1 * num2);
           
            // Fill response array and randomly assign the correct answer.
            Response<int>[] responses = {new Response<int>(num1 + rand.Next(1,11)),
                                         new Response<int>(num1 + num2),
                                         new Response<int>(num1 * num1),
                                         new Response<int>(num2 * rand.Next(0,6))};
            
            responses[rand.Next(0,4)] = product;
            
            // Form and return the finished question.
            Question Q = new Question("What is " + num1 + " times " + num2 + "?",
                                                responses[0],
                                                responses[1],
                                                responses[2],
                                                responses[3]);
            return Q;
        }
    }
