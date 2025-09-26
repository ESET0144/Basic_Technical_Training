class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    

    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public bool Drive(bool isSelfdrive)
    {
        if (isSelfdrive)
        {
            Consol.WriteLine($"{Model} car is Self Driving");

        }
    }

}

class Program
{
    static void Main()
    {
        Car c = new Car("Toyota", 2022);
        

    }
}