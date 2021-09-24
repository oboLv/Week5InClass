namespace NewClasses
{
    public abstract class Vehicle
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public abstract void TurnRight();

        public virtual void TurnLeft()
        {
            System.Console.WriteLine("The vehicle turns left");
        }

        public void Start()
        {
            System.Console.WriteLine("The vehicle is running");
        }

        public void Stop()
        {
            System.Console.WriteLine("The vehicle is stopped");
        }

        public void Drive()
        {
            System.Console.WriteLine("The care is moving");
        }
    }
}