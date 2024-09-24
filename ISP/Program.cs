public class Program
{
    public static void Main(string[] args)
    {
    }
}

// Нарушение ISP
public interface IWorker {
    void Work();
    void Eat();
}

// Исправление (клиенты не должны зависеть от интерфейсов, которые они не используют)
public interface IWorkable {
    void Work();
}

public interface IFeedable {
    void Eat();
}

public class Worker : IWorkable, IFeedable {
    public void Work() {
        // Логика работы
    }

    public void Eat() {
        // Логика питания
    }
}

public class Robot : IWorkable {
    public void Work() {
        // Логика работы робота
    }
}
