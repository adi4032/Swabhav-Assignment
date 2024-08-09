using ProxyDesignPattern.Model;

class Program
{
    static void Main(string[] args)
    {
        IExpensiveObject proxy = new ExpensiveObjectProxy();
        proxy.Process();
        proxy.Process();
    }
}
