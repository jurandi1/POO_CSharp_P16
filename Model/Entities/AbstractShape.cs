using POO_CSharp_P16.Model.Enums;

namespace POO_CSharp_P16.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
