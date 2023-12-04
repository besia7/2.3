using System;

class Employee
{
    private string lastName;
    private string firstName;

    // Конструктор класу Employee
    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    // Метод для розрахунку окладу та податкового збору
    public void CalculateSalaryAndTax(string position, int experience)
    {
        double baseSalary = 0;

        // Визначаємо базовий оклад в залежності від посади
        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 50000;
                break;
            case "developer":
                baseSalary = 60000;
                break;
            // Додаткові варіанти для інших посад можна додати за необхідності
            default:
                Console.WriteLine("Невідома посада");
                return;
        }

        // Збільшуємо оклад залежно від стажу
        double experienceBonus = experience * 1000;
        double totalSalary = baseSalary + experienceBonus;

        // Розрахунок податкового збору
        double taxRate = 0.15; // 15% податкового збору
        double tax = totalSalary * taxRate;

        // Виводимо інформацію на екран
        Console.WriteLine("Інформація про співробітника:");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {totalSalary:C}");
        Console.WriteLine($"Податковий збір: {tax:C}");
    }
}

class Program
{
    static void Main()
    {
        // Створюємо екземпляр класу Employee
        Employee employee = new Employee("Петров", "Іван");

        // Викликаємо метод для розрахунку окладу та податкового збору
        employee.CalculateSalaryAndTax("developer", 3);

        Console.ReadLine(); // Затримка, щоб консольне вікно не закрилося відразу
    }
}

