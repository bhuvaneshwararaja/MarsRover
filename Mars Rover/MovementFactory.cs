using System;
namespace Mars_Rover
{
    public class MovementFactory
    {
        public static IMovement CreateMovement(char action)
        {
            switch (action)
            {
                case 'M':
                    return new MoveForward();
                case 'R':
                    return new MoveRight();
                case 'L':
                    return new MoveLeft();
                default:
                    return null;
            }
        }
    }
}

