using StateDesignPatternDemo.Model;

class Program
{
    static void Main(string[] args)
    {
        var machine = new VendingMachine();

        machine.InsertCoin();
        machine.SelectProduct(); 
        machine.Dispensing(); 
    }
}
