using System;
namespace Mars_Rover
{
	public class Rover
	{
        public int x;
        public int y;
        public Direction direction;

        public Rover(int x, int y, Direction direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

        public void ExecuteMovement(IMovement movement)
        {
            movement.Move(this);
        }

        public void PrintPosition()
        {
            Console.WriteLine($"Current position: ({x}, {y}), Direction: {direction}");
        }
    }
}