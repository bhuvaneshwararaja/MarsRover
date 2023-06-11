using System;
namespace Mars_Rover
{
    public class MoveLeft : IMovement
    {

        public void Move(Rover rover)
        {
            rover.direction = (Direction)(((int)rover.direction + 3) % 4);
        }

    }
}

