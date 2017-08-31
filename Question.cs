public class Question
    {
        Response<int>[] responsesArray = new Response<int>[4];
        
        // Constructor
        public Question(string _Q , Response<int> R1, Response<int> R2, Response<int> R3, Response<int> R4)
        {
            Q = _Q;
            
            responsesArray[0] = R1;
            responsesArray[1] = R2;
            responsesArray[2] = R3;
            responsesArray[3] = R4;
        }
        
        // Class members
        private string Q {get; set;}
        
        // Method to show question
        public void ShowQuestion()
        {
            Console.WriteLine(Q);    
        }
        
        // Method to show all possible answers
        public void ShowAnswers()
        {
            for(int i = 0; i < responsesArray.Length; i++)
            {                
                Console.WriteLine((i + 1) + ") " + responsesArray[i].Data.ToString());   
            }
        }
        
        // Method to show answer types (Useful when utilizing generic types)
        public void ShowTypes()
        {
            for(int i = 0; i < responsesArray.Length; i++)
            {
                Console.WriteLine(responsesArray[i].GetType().ToString());   
            }
        }
    }
