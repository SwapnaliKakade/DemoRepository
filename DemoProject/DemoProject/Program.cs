class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("code added in branch1");
        sample sample = new sample();
        sample.display();
    }
}
class sample
{
    public void display()
    {
        Console.WriteLine("code added in main branch");
    }
}