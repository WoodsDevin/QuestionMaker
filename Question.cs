public class Question<T>
    {
        // Constructor
        public Question(string _Q , T R1, T R2, T R3, T R4)
        {
            Q = _Q;
            ResponseA = R1;
            ResponseB = R2;
            ResponseC = R3;
            ResponseD = R4;
        }
        
        // Class members
        private string Q {get; set;}
        public T ResponseA {get; private set;}
        public T ResponseB {get; private set;}
        public T ResponseC {get; private set;}
        public T ResponseD {get; private set;}
        
        // Method to show question
        public void ShowQuestion()
        {
            Console.WriteLine(Q);    
        }
        
        // Method to show all possible answers
        public void ShowAnswers()
        {
            Console.WriteLine("A) " + ResponseA.ToString());
            Console.WriteLine("B) " + ResponseB.ToString());
            Console.WriteLine("C) " + ResponseC.ToString());
            Console.WriteLine("D) " + ResponseD.ToString());
        }
        
        // Method to show answer types (Useful when utilizing generic types)
        public void ShowTypes()
        {
            Console.WriteLine("Response A = " + ResponseA.GetType().ToString()); 
            Console.WriteLine("Response B = " + ResponseB.GetType().ToString()); 
            Console.WriteLine("Response C = " + ResponseC.GetType().ToString()); 
            Console.WriteLine("Response D = " + ResponseD.GetType().ToString()); 
        }
    }
