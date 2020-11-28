using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Classes
{

    public static class Plateau
    {
        private static int _width;
        private static int _height;
        public static int Width
        {
            get { return _width; }
            private set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("Width > 0 Olmalı");
                }
            }
        }
        public static int Height
        {
            get { return _height; }
            private set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    throw new Exception("_Height > 0 Olmalı");
                }
            }
        }
        static Plateau()
        {
        }

        public static void SetPlateau(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public static void GetPlateau()
        {
            Console.WriteLine("H:{0} W:{1}", Width, Height);
        }
    }
}
