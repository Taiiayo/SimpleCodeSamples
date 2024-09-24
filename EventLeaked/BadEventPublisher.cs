public class BadEventPublisher
{
    public event EventHandler MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}

public class EventSubscriber
{
    public EventSubscriber(BadEventPublisher publisher)
    {
        publisher.MyEvent += HandleEvent;
        // теперь publisher ссылается на экземпляр EventSubscriber
    }

    private void HandleEvent(object sender, EventArgs e)
    {
        // Обработка события
    }
}

// Пример использования
// ReSharper disable once ClassNeverInstantiated.Global
public class Program
{
    public static void Main(string[] args)
    {
        // Если subscriber больше не нужен, но не отписался от события,
        // объект subscriber не будет собран сборщиком мусора.
        var publisher = new BadEventPublisher();
        publisher.RaiseEvent();
        var subscriber = new EventSubscriber(publisher);
    }
}

