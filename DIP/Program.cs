public class Program
{
    public static void Main(string[] args)
    {
    }
}

// Нарушение DIP
public class BadLightBulb {
    public void TurnOn() {
        // Включение лампочки
    }

    public void TurnOff() {
        // Выключение лампочки
    }
}

public class BadSwitch {
    private BadLightBulb _lightBulb;

    public BadSwitch(BadLightBulb lightBulb) {
        _lightBulb = lightBulb;
    }

    public void Operate() {
        _lightBulb.TurnOn();
    }
}

// Исправление (высокоуровневые модули не должны зависеть от низкоуровневых модулей. Оба должны зависеть от абстракций)
public interface IDevice {
    void TurnOn();
    void TurnOff();
}

public class GoodLightBulb : IDevice {
    public void TurnOn() {
        // Включение лампочки
    }

    public void TurnOff() {
        // Выключение лампочки
    }
}

public class Switch {
    private IDevice _device;

    public Switch(IDevice device) {
        _device = device;
    }

    public void Operate() {
        _device.TurnOn();
    }
}