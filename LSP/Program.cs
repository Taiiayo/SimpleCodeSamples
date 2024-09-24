public class Program
{
    public static void Main(string[] args)
    {
    }
}

public abstract class BadBird {
    public abstract void Fly();
}

public class BadSparrow : BadBird {
    public override void Fly() {
        // Реализация полета воробья
    }
}

public class BadOstrich : BadBird {
    public override void Fly() {
        throw new NotImplementedException(); // Нарушение LSP
    }
}

// Исправление (объекты базового класса должны заменяться объектами производного класса без нарушения корректности программы)
public abstract class GoodBird {
    // Общие свойства и методы для всех птиц
}

public abstract class FlyingBird : GoodBird {
    public abstract void Fly();
}

public class Sparrow : FlyingBird {
    public override void Fly() {
        // Реализация полета воробья
    }
}

public class Ostrich : GoodBird {
    // Страус не летает, поэтому метод Fly отсутствует
}