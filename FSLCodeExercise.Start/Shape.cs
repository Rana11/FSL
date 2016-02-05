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
}
