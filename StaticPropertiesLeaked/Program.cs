public class MemoryLeakExample
{
    // статические переменные считаются корневыми объектами, поэтому не будут собраны GC
    private static List<string> _leakList = new List<string>();

    public void AddItem(string item)
    {
        _leakList.Add(item);
    }
    
    public void ClearItems()
    {
        _leakList.Clear();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var example = new MemoryLeakExample();
        example.AddItem("Item 1");
        example.AddItem("Item 2");
        // Объекты в _leakList не будут собраны сборщиком мусора до завершения работы приложения.
        
        // Когда данные больше не нужны
        example.ClearItems();
    }
}
