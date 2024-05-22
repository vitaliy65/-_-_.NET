# Шаблони проектування

## Abstract Factory (Абстрактна фабрика)

**Опис:**
Абстрактна фабрика - це патерн проектування, який надає інтерфейс для створення сімейств пов'язаних або залежних об'єктів без указівки конкретних класів.

**Статична модель:**

```mermaid
classDiagram
    class AbstractFactory {
        + createProductA()
        + createProductB()
    }
    class ConcreteFactory1
    class ConcreteFactory2
    AbstractFactory <|-- ConcreteFactory1
    AbstractFactory <|-- ConcreteFactory2
    interface AbstractProductA
    interface AbstractProductB
    class ProductA1
    class ProductA2
    class ProductB1
    class ProductB2
    AbstractProductA <|-- ProductA1
    AbstractProductA <|-- ProductA2
    AbstractProductB <|-- ProductB1
    AbstractProductB <|-- ProductB2
    ConcreteFactory1 --> ProductA1
    ConcreteFactory1 --> ProductB1
    ConcreteFactory2 --> ProductA2
    ConcreteFactory2 --> ProductB2
```
## Facade (Фасад)
**Опис:**
Фасад - це патерн проектування, який надає простий інтерфейс до складної системи класів, бібліотек або фреймворків.

**Статична модель:**
```mermaid
classDiagram
    class Facade {
        + operation()
    }
    class Subsystem1
    class Subsystem2
    Facade --> Subsystem1
    Facade --> Subsystem2
```

## Publish/Subscribe (Публікувати/Підписуватися)

**Опис:**
Патерн Публікувати/Підписуватися - це патерн проектування, що використовує розподілену систему обробки подій для організації комунікації між компонентами.

**Статична модель:**
```mermaid
classDiagram
    class Publisher {
        + publish(event)
    }
    class Subscriber {
        + subscribe(event)
        + unsubscribe(event)
        + onEvent(event)
    }
    Publisher --> Subscriber
```

## Thread-Specific (Потоко-специфічний)

**Опис:**
Патерн Потоко-специфічний - це патерн проектування, який дозволяє кожному потоку мати свої власні дані, що не конфліктують з даними інших потоків.

**Статична модель:**
(Цей патерн часто не відображається в статичних моделях, оскільки це більше про організацію коду, ніж про структуру об'єктів.)
