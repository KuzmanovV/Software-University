using System;

namespace _1.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length;
            private set
            {
                ThroughIfInvalidSide(value, nameof(Length));
                length = value;
            }
        }
        public double Width
        {
            get => width;
            private set
            {
                ThroughIfInvalidSide(value, nameof(Width));
                width = value;
            }
        }

        public double Height
        {
            get => height;
            private set
            {
                ThroughIfInvalidSide(value,nameof(Height));
                height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * (Length * Width + Length * Height + Height * Width);
        }
        public double LateralSurfaceArea()
        {
            return 2 * (Length * Height + Height * Width);
        }
        public double Volume()
        {
            return Length * Height * Width;
        }
        private void ThroughIfInvalidSide(double value, string lengthName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{lengthName} cannot be zero or negative.");
            }
        }
    }
}