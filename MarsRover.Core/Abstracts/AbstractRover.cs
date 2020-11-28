using MarsRover.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Abstracts
{
    public abstract class AbstractRover
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public DirectionEnum Direction { get; set; }
        public abstract void Drive(string command);
        public abstract void GetPosition();
    }
}
