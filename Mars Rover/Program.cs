using Mars_Rover;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the initial position of the Mars rover:");
        Console.Write("X coordinate: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Y coordinate: ");
        int y = int.Parse(Console.ReadLine());

        Console.Write("Direction (N, E, S, W): ");
        Direction direction = Enum.Parse<Direction>(Console.ReadLine(), true);

        Rover rover = new Rover(x, y, direction);
        rover.PrintPosition();


        while (true)
        {
            Console.WriteLine("\nEnter the next action (M: Move Forward, R: Rotate Right, L: Rotate Left, Q: Quit):");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (input == 'Q')
                break;

            IMovement movement = MovementFactory.CreateMovement(input);

            if (movement == null)
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            rover.ExecuteMovement(movement);
            rover.PrintPosition();
        }

    }
}