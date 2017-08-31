public class Response<T>
    {
        public T Data {get; private set;}
        public Response(T input)
        {
            Data = input;   
        }
    }
