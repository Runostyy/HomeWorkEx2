using System;

// Абстрактний клас Рослина
abstract class Roslyna
{
    // Поля базового класу
    public string Name { get; set; } // Назва рослини
    public string Color { get; set; } // Колір рослини

    // Конструктор з параметрами для базового класу
    public Roslyna(string name, string color)
    {
        Name = name;
        Color = color;
    }

    // Абстрактний метод 1
    public abstract void Grow();

    // Абстрактний метод 2
    public abstract void Bloom();
}

class Derevo : Roslyna
{
    // Додаткові властивості для класу Дерево
    public string Breed { get; set; } // Порода дерева
    public int Age { get; set; } // Вік дерева

    // Конструктор з параметрами для класу Дерево
    public Derevo(string name, string color, string breed, int age) : base(name, color)
    {
        Breed = breed;
        Age = age;
    }

    // Реалізація абстрактного методу 1
    public override void Grow()
    {
        Console.WriteLine($"{Breed} дерево росте. Його вік: {Age} років.");
    }

    // Реалізація абстрактного методу 2
    public override void Bloom()
    {
        Console.WriteLine($"{Breed} дерево цвіте красивими {Color} квітами.");
    }

    // Метод 1. Приймає 2 параметри: Порода і Вік
    public void CheckTree(string breed, int age)
    {
        if (breed == Breed && age == Age)
        {
            Console.WriteLine($"Дерево: {Name}, Колір: {Color}, Порода: {Breed}, Вік: {Age} років.");
        }
        else
        {
            Console.WriteLine($"Такого дерева у нас немає: {breed}, {age} років.");
        }
    }

    // Метод 2. Без параметрів. Виводить назву, породу і вік дерева.
    public void PrintTreeSummary()
    {
        Console.WriteLine($"Назва: {Name}, Порода: {Breed}, Вік: {Age} років.");
    }
}

class Kvity : Roslyna
{
    // Додаткова властивість для класу Квіти
    public string FlowerColor { get; set; } // Колір квітки

    // Конструктор з параметрами для класу Квіти
    public Kvity(string name, string color, string flowerColor) : base(name, color)
    {
        FlowerColor = flowerColor;
    }

    // Реалізація абстрактного методу 1
    public override void Grow()
    {
        Console.WriteLine($"Квітка {Name} росте. Її колір: {FlowerColor}.");
    }

    // Реалізація абстрактного методу 2
    public override void Bloom()
    {
        Console.WriteLine($"Квітка {Name} цвіте гарними {FlowerColor} квітами.");
    }

    // Метод, який виводить інформацію про троянду
    public void RoseInfo()
    {
        Console.WriteLine("Яка це троянда?");
        Console.WriteLine("Це троянда Блек Меджік. Вона майже чорного кольору.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкту дерева
        Derevo derevo = new Derevo("Дерево", "Зелене", "Груша", 10);
        derevo.Grow();             // Викликаємо метод росту дерева
        derevo.Bloom();            // Викликаємо метод цвітіння дерева
        derevo.CheckTree("Груша", 10);  // Перевірка дерева за породою і віком
        derevo.CheckTree("Яблуня", 5);  // Перевірка дерева з помилковими даними
        derevo.PrintTreeSummary();  // Викликаємо метод без параметрів, що виводить назву, породу і вік дерева

        // Створення об'єкту квітки
        Kvity kvitka = new Kvity("Троянда", "Зелена", "Чорний");
        kvitka.Grow();             // Викликаємо метод росту квітки
        kvitka.Bloom();            // Викликаємо метод цвітіння квітки
        kvitka.RoseInfo();         // Викликаємо метод, що виводить інформацію про троянду
    }
}
