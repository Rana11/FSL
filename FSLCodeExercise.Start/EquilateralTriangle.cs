namespace FSLCodeExercise.Start
{
    using System;

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
                return (Math.Sqrt(4) / 3) * this.Width * this.Width;
            }
        }
    }
}