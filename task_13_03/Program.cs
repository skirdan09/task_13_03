using System;

public class Car
{
    // Свойства
    public string LicensePlate { get; private set; }
    public string Brand { get; private set; }
    public string Color { get; private set; }
    public double CurrentSpeed { get; private set; }

    private const double MaxSpeed = 200.0; // Максимальная скорость

    // Конструкторы
    public Car(string licensePlate, string brand, string color)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Color = color;
        CurrentSpeed = 0.0; // Изначальная скорость 0
    }

    public Car(string licensePlate) : this(licensePlate, "Unknown", "Unknown") { }

    public Car() : this("Unknown") { }

    // Метод для симуляции езды
    public void Drive(double acceleration)
    {
        CurrentSpeed += acceleration;

        if (CurrentSpeed > MaxSpeed)
        {
            Console.WriteLine($"Скорость превышает допустимую! Максимальная скорость: {MaxSpeed} км/ч. Остановка автомобиля.");
            Stop();
        }
        else
        {
            Console.WriteLine($"Автомобиль {Brand} {Color} с номером {LicensePlate} разгоняется. Текущая скорость: {CurrentSpeed} км/ч.");
        }
    }

    // Метод для торможения
    public void Stop()
    {
        CurrentSpeed = 0;
        Console.WriteLine($"Автомобиль {Brand} {Color} с номером {LicensePlate} остановлен.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект автомобиля
        Car car1 = new Car("1562AB", "Toyota", "White");
        car1.Drive(50); // Разгоняем
        car1.Drive(200); // Превышаем скорость

        Car car2 = new Car("5999CD", "BMW", "Black");
        car2.Drive(100); // Разгоняем
        car2.Stop(); // Останавливаем
    }
}
