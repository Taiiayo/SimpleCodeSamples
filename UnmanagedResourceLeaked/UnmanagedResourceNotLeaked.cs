
using System.Runtime.InteropServices;

public class UnmanagedResourceNotLeaked : IDisposable
{
    private IntPtr _unmanagedResource;
    private bool _disposed = false;

    public UnmanagedResourceNotLeaked()
    {
        // Выделение неуправляемого ресурса
        _unmanagedResource = Marshal.AllocHGlobal(100);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Освобождение управляемых ресурсов
            }

            // Освобождение неуправляемых ресурсов
            Marshal.FreeHGlobal(_unmanagedResource);
            _unmanagedResource = IntPtr.Zero;

            _disposed = true;
        }
    }

    ~UnmanagedResourceNotLeaked()
    {
        Dispose(false);
    }
}

class UnmanagedResourceNotLeaked_Program
{
    public static void Main_2(string[] args)
    {
        using (var wrapper = new UnmanagedResourceNotLeaked())
        {
            // Использование ресурса
    
            // Ресурс будет освобожден автоматически при выходе из блока using
        }
    }
}

