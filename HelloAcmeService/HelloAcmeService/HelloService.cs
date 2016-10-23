namespace HelloAcmeService {
    public class HelloService : IHelloService
    {
        public string GetData(int value)
        {
            {
                return string.Format("You enteredx: {0}", value);
            }
        }
    }
}
