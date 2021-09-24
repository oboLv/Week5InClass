namespace NewClasses
{
    public class Ford : Vehicle
    {
        public string Color { get; set; }

        public override void TurnRight()
        {
            System.Console.WriteLine("The Ford turns right");
        }

        public override void TurnLeft()
        {
            System.Console.WriteLine("The Ford turns left");
        }

    }
}