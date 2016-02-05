using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace FSLCodeExercise.Start
{
    public static class ShapeFactory
    {
        private static readonly Dictionary<ShapeType, Type> ShapeByType;

        static ShapeFactory()
        {
            ShapeByType = new Dictionary<ShapeType, Type>();
            var shapeTypes = Enum.GetValues(typeof(ShapeType)).Cast<ShapeType>();
           
            var ishapeImplementations = Assembly.GetExecutingAssembly().GetTypes().Where(t => typeof(Shape).IsAssignableFrom(t) && t.Name != typeof(Shape).Name && !t.IsInterface);
            foreach (var type in ishapeImplementations)
            {
                var shapeType = shapeTypes.Single(x => x.ToString() == type.Name);
                ShapeByType.Add(shapeType, type);
            }
        }

        public static Shape CreateInstance(ShapeType type, double width)
        {
            var typeToCreate = ShapeByType.FirstOrDefault(x => x.Key == type).Value;
            return Activator.CreateInstance(typeToCreate, width) as Shape;
        }
    }
}