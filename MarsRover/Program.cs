using System;
using MarsRover.Core.Classes;
using MarsRover.Core.Enums;
using MarsRover.Core.Helpers;
using MarsRover.Core.Extensions;
namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of Plateau :");
            var plateauSizeCommand = Console.ReadLine();
           
            var inputCommandPlateauSize = Helper.InputCommandPlateauSize(plateauSizeCommand);
            Plateau.SetPlateau(inputCommandPlateauSize.Width, inputCommandPlateauSize.Height);

            Console.WriteLine("Rover Position :");
            var roverPositionCommand = Console.ReadLine();

            var inputCommandRoverPosition = Helper.InputCommandRoverPosition(roverPositionCommand);
            var rover = new Rover(inputCommandRoverPosition.PositionX, inputCommandRoverPosition.PositionY, inputCommandRoverPosition.Direction);

            Console.WriteLine("Command :");
            var command = Console.ReadLine();

            rover.Drive(command);
            rover.GetPosition();

            Console.ReadLine();
        }
    }
}
