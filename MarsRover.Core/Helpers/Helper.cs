
using MarsRover.Core.Classes;
using MarsRover.Core.Enums;
using MarsRover.Core.Extensions;
using MarsRover.Core.InputCommandClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Helpers
{
    public class Helper
    {
        public static InputCommandPlateauSize InputCommandPlateauSize(string command)
        {
            var commandSize = command.Split(' ');
            if (commandSize.Length > 1)
            {
                return new InputCommandPlateauSize()
                {
                    Width = commandSize[0].ToInt32(),
                    Height = commandSize[1].ToInt32()
                };
            }
            throw new Exception("Undefined size!");
        }

        public static InputCommandRoverPosition InputCommandRoverPosition(string command)
        {
            var commandSize = command.Split(' ');
            if (commandSize.Length > 2)
            {
                var movement = (DirectionEnum)Enum.Parse(typeof(DirectionEnum), commandSize[2]);

                return new InputCommandRoverPosition()
                {
                    PositionX = commandSize[0].ToInt32(),
                    PositionY = commandSize[1].ToInt32(),
                    Direction = movement
                };
            }
            throw new Exception("Undefined position!");
        }
    }
}
