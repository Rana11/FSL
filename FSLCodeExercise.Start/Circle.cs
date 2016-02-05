namespace FSLCodeExercise.Start
{
    using System;

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
                return Math.PI * (this.Width / 2) * (this.Width / 2);
            }
        }
    }
}