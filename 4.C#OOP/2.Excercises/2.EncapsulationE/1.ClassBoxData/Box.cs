using System;

namespace _1.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length,double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get=>length;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid side measure!");
                }

                length = value;
            }
        }

        public double Width
        {
            get => width;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid side measure!");
                }

                width = value;
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid side measure!");
                }

                height = value;
            }
        }

        public double SurfaceArea(Box box)
        {
            return 2 * (Length * Width + Length * Height + Height * Width);
        }
        public double LateralSurfaceArea(Box box)
        {
            return 2 * (Length * Height + Height * Width);
        }
        public double Volume(Box box)
        {
            return Length * Height* Width;
        }
    }
}