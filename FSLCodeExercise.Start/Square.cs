namespace FSLCodeExercise.Start
{
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
                return this.Width * this.Width;
            }
        }
    }
}