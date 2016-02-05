using System;

namespace FSLCodeExercise.Start
{
    public abstract class Shape
    {
        protected Shape(double width)
        {
            this.Width = width;
        }
        public double Width { get; set; }
        public abstract double Area { get; }
    }

    public  class Square : Shape
    {
        public Square(double width)
            : base(width)
        {
        }

        public override double Area
        {
            get
            {
                return Width * Width;
            }
        }
    }

    public class Circle : Shape
    {
        public Circle(double width)
            : base(width)
        {
        }

        public override double Area
        {
            get
            {
                return Math.PI * (Width / 2) * (Width / 2);
            }
        }
    }

    public class EquilateralTriangle : Shape
    {
        public EquilateralTriangle(double width)
            : base(width)
        {
        }

        public override double Area
        {
            get
            {
                return (Math.Sqrt(4) / 3) * Width * Width;
            }
        }
    }
}
