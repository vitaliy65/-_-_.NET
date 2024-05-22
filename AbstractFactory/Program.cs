using System;

// Интерфейс абстрактной фабрики
public interface IAbstractFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}

// Конкретная фабрика 1
public class ConcreteFactory1 : IAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}

// Конкретная фабрика 2
public class ConcreteFactory2 : IAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}

// Интерфейс продукта A
public interface IProductA
{
    string GetName();
}

// Конкретный продукт A1
public class ConcreteProductA1 : IProductA
{
    public string GetName()
    {
        return "ConcreteProductA1";
    }
}

// Конкретный продукт A2
public class ConcreteProductA2 : IProductA
{
    public string GetName()
    {
        return "ConcreteProductA2";
    }
}

// Интерфейс продукта B
public interface IProductB
{
    string GetName();
}

// Конкретный продукт B1
public class ConcreteProductB1 : IProductB
{
    public string GetName()
    {
        return "ConcreteProductB1";
    }
}

// Конкретный продукт B2
public class ConcreteProductB2 : IProductB
{
    public string GetName()
    {
        return "ConcreteProductB2";
    }
}

// Клиентский код
class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляра конкретной фабрики 1
        IAbstractFactory factory1 = new ConcreteFactory1();

        // Получение продуктов от фабрики 1
        var productA1 = factory1.CreateProductA();
        var productB1 = factory1.CreateProductB();

        // Вывод имен продуктов
        Console.WriteLine(productA1.GetName()); // Выводит: ConcreteProductA1
        Console.WriteLine(productB1.GetName()); // Выводит: ConcreteProductB1

        // Создание экземпляра конкретной фабрики 2
        IAbstractFactory factory2 = new ConcreteFactory2();

        // Получение продуктов от фабрики 2
        var productA2 = factory2.CreateProductA();
        var productB2 = factory2.CreateProductB();

        // Вывод имен продуктов
        Console.WriteLine(productA2.GetName()); // Выводит: ConcreteProductA2
        Console.WriteLine(productB2.GetName()); // Выводит: ConcreteProductB2
    }
}
