using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Class_Box_Data
{
   internal class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public string CalculateVolume()
        {
            //Volume = lwh
            double result = this.length * this.width * this.height;
            return $"Volume - {result:F2}";
        }
        public string CalculateLateralSurfaceArea()
        {
            //  Lateral Surface Area = 2lh + 2wh
            double result = (2 * this.length * this.height + 2 * this.width * this.height);
            return $"Lateral Surface Area - {result:F2}";
        }

        public string CalculateSurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            double result = (2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height);
            return $"Surface Area - {result:F2}";
        }
    }
}
