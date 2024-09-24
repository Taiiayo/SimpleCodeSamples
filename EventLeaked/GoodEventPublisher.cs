namespace EventLeaked;

public class GoodEventPublisher
{
    public event EventHandler MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}

public class EventSubscriber
{
    private readonly GoodEventPublisher _publisher;

    public EventSubscriber(GoodEventPublisher publisher)
    {
        _publisher = publisher;
        _publisher.MyEvent += HandleEvent;
    }

    private void HandleEvent(object sender, EventArgs e)
    {
        // Обработка события
    }

    public void Unsubscribe()
    {
        _publisher.MyEvent -= HandleEvent;
    }
}

// Пример использования

class Program
{
    public static void Main_2(string[] args)
    {
        var publisher = new GoodEventPublisher();
        var subscriber = new EventSubscriber(publisher);

// Когда subscriber больше не нужен, отпускаем ссылку
        subscriber.Unsubscribe();
    }
}