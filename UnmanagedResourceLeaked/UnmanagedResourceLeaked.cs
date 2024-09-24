using System.Runtime.InteropServices;

public class UnmanagedResourceLeaked
{
    private IntPtr _unmanagedResource;

    public UnmanagedResourceLeaked()
    {
        // Выделение неуправляемого ресурса
        _unmanagedResource = Marshal.AllocHGlobal(100);
    }

    // Нет реализации IDisposable, ресурс не будет освобожден
}

class Program
{
    public static void Main(string[] args)
    {
        // Если не освободить ресурс вручную, произойдет утечка памяти.
        var wrapper = new UnmanagedResourceLeaked();
    }
}
