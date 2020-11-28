using MarsRover.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.InputCommandClasses
{
    public class InputCommandRoverPosition
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public DirectionEnum Direction { get; set; }
    }
}
