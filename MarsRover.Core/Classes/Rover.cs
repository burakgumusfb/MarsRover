using MarsRover.Core.Abstracts;
using MarsRover.Core.Enums;
using System;

namespace MarsRover.Core.Classes
{
    public class Rover : AbstractRover
    {
        public Rover(int positionX, int positionY, DirectionEnum direction)
        {
            PositionX = positionX;
            PositionY = positionY;
            Direction = direction;
        }
        public override void Drive(string command)
        {
            var commandsArr = command.ToCharArray();
            foreach (var cmd in commandsArr)
            {
                var cmdEnum = (MovementEnum)Enum.Parse(typeof(MovementEnum), cmd.ToString());

                switch (cmdEnum)
                {
                    case MovementEnum.L:
                        TurnLeft();
                        break;
                    case MovementEnum.R:
                        TurnRight();
                        break;
                    case MovementEnum.M:
                        Move();
                        break;
                    default:
                        break;
                }
            }
        }
        public override void GetPosition()
        {
            Console.WriteLine(string.Format("{0} {1} {2}", PositionX, PositionY, Direction));
        }

        private void TurnLeft()
        {
            switch (Direction)
            {
                case DirectionEnum.N:
                    this.Direction = DirectionEnum.W;
                    break;
                case DirectionEnum.W:
                    this.Direction = DirectionEnum.S;
                    break;
                case DirectionEnum.S:
                    this.Direction = DirectionEnum.E;
                    break;
                case DirectionEnum.E:
                    this.Direction = DirectionEnum.N;
                    break;
                default:
                    break;
            }
        }
        private void TurnRight()
        {
            switch (Direction)
            {
                case DirectionEnum.N:
                    this.Direction = DirectionEnum.E;
                    break;
                case DirectionEnum.E:
                    this.Direction = DirectionEnum.S;
                    break;
                case DirectionEnum.S:
                    this.Direction = DirectionEnum.W;
                    break;
                case DirectionEnum.W:
                    this.Direction = DirectionEnum.N;
                    break;
                default:
                    break;
            }
        }
        private void Move()
        {
            int roverPositionX = this.PositionX;
            int roverPoisitionY = this.PositionY;

            switch (this.Direction)
            {
                case DirectionEnum.N:
                    this.PositionY++;
                    break;
                case DirectionEnum.S:
                    this.PositionY--;
                    break;
                case DirectionEnum.W:
                    this.PositionX--;
                    break;
                case DirectionEnum.E:
                    this.PositionX++;
                    break;

                default:
                    throw new InvalidOperationException();
            }

            if (!IsMove())
            {
                this.PositionX = roverPositionX;
                this.PositionY = roverPoisitionY;

                //return true;
            }

        }
        private bool IsMove()
        {
            if (this.PositionX > Plateau.Width || this.PositionX < 0 || this.PositionY > Plateau.Height || this.PositionY < 0)
            {
                return false;
            }

            return true;
        }

    }
}
