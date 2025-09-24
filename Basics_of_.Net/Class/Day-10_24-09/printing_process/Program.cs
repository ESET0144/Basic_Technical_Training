namespace printing_process
{
    internal class Program
    {
        static void Main(string[] args)
        {
            epson_printer hello = new epson_printer();
            printer big = new printer();

            hello.print();
            big.print();
            
        }
    }
}
