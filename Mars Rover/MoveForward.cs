using System;
namespace Mars_Rover
{
    public class MoveForward : IMovement
    {

        public void Move(Rover rover)
        {
            switch (rover.direction)
            {
                case Direction.N:
                    rover.y++;
                    break;
                case Direction.E:
                    rover.x++;
                    break;
                case Direction.S:
                    rover.y--;
                    break;
                case Direction.W:
                    rover.x--;
                    break;
            }
        }

    }
}

