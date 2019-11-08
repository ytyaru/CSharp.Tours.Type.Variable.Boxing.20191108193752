class Program
{
    static void Main()
    {
        int i = 123;
        object o = i;    // Boxing
        int j = (int)o;  // Unboxing
        System.Console.WriteLine($"{j}");
    }
}
