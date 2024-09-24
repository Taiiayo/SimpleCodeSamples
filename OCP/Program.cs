public class Program
{
    public static void Main(string[] args)
    {
    }
}

// Нарушение OCP
public class BadRectangle {
    public double Width { get; set; }
    public double Height { get; set; }
}

public class AreaCalculator {
    public double CalculateArea(BadRectangle rectangle) {
        return rectangle.Width * rectangle.Height;
    }
}

// Исправление (классы должны быть открыты для расширения, но закрыты для изменения)
public abstract class Shape {
    public abstract double CalculateArea();
}

public class GoodRectangle : Shape {
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea() {
        return Width * Height;
    }
}

public class Circle : Shape {
    public double Radius { get; set; }

    public override double CalculateArea() {
        return Math.PI * Radius * Radius;
    }
}