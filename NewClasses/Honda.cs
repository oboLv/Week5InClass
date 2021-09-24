namespace NewClasses
{
    public class Honda : Vehicle
    {
        public override void TurnRight()
        {
            System.Console.WriteLine("The Honda turns right");
        }

        public override void TurnLeft()
        {
            System.Console.WriteLine("The Honda turns left");
        }
    }
}