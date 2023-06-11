using System;
namespace Mars_Rover
{
    public class MoveRight : IMovement
    {

        public void Move(Rover rover)
        {
            rover.direction = (Direction)(((int)rover.direction + 1) % 4);
        }
    }
}

