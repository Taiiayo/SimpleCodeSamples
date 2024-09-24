// Нарушение SRP 
public class BadEmployee {
    public string Name { get; set; }
    public double Salary { get; set; }
    public void CalculateSalary() {
        // Логика расчета зарплаты
    }
    public void GenerateReport() {
        // Логика генерации отчета
    }
}

// Исправление (класс должен иметь только одну причину для изменения)
public class GoodEmployee {
    public string Name { get; set; }
    public double Salary { get; set; }
}

public class SalaryCalculator {
    public double CalculateSalary(GoodEmployee employee)
    {
        // Логика расчета зарплаты
        return 0;
    }
}

public class ReportGenerator {
    public void GenerateReport(GoodEmployee employee) {
        // Логика генерации отчета
    }
}

public class Program
{
    public static void Main(string[] args)
    {
    }
}