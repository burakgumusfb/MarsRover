using MarsRover.Core.Classes;
using MarsRover.Core.Enums;
using MarsRover.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Unit.Test
{

    public class MarsRoverUnitTest
    {
        [Theory]
        [InlineData(new object[] { "5 5", "1 2 N", "LMLMLMLMM", 1, 3, DirectionEnum.N })]
        [InlineData(new object[] { "5 5", "1 3 N", "MM", 1, 5, DirectionEnum.N })]
        [InlineData(new object[] { "5 5", "3 3 W", "MM", 1, 3, DirectionEnum.W })]
        [InlineData(new object[] { "5 5", "3 4 E", "MMRM", 5, 3, DirectionEnum.S })]
        public void PlateauAndRoverDriveTestMethod(string plateauSizeCommand, string roverPositionCommand,
            string Command,
            int expectedPositionX,
            int exceptedPositionY,
            DirectionEnum expectedDirection
           )
        {
            var inputCommandPlateauSize = Helper.InputCommandPlateauSize(plateauSizeCommand);
            Plateau.SetPlateau(inputCommandPlateauSize.Width, inputCommandPlateauSize.Height);

            var plateauHeight = Plateau.Height;
            var plateauWidth = Plateau.Width;

            var inputCommandRoverPosition = Helper.InputCommandRoverPosition(roverPositionCommand);
            var rover = new Rover(inputCommandRoverPosition.PositionX,
                                  inputCommandRoverPosition.PositionY,
                                  inputCommandRoverPosition.Direction);

            rover.Drive(Command);

            Assert.True(plateauWidth > 0);
            Assert.True(plateauHeight > 0);
            Assert.Equal(rover.PositionX, expectedPositionX);
            Assert.Equal(rover.PositionY, exceptedPositionY);
            Assert.Equal(rover.Direction, expectedDirection);

        }


    }
}
