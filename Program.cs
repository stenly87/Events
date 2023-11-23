// Интерфейсы
using System.Reflection.Emit;
// синтаксис (модификаторы interface название : наследование интерфейсов)
// интерфейс содержит: методы, свойства, события
// все элементы не содержат тела (логики)
// элементы не содержат модификатора доступа
// классы, реализующие интерфейс, обязаны предоставить
// тело (логику) для всех элементов интерфейса
/*public interface IUserCommand : IDisposable
{
    void Execute();
    int Test(string[] args);
    int TestProperty { get; }
}

public interface ISomeAnotherInterface
{
    bool AnotherMethod();
}

class Test : ISomeAnotherInterface
{
    bool ISomeAnotherInterface.AnotherMethod()
    {
        throw new NotImplementedException();
    }
}

class TestUserCommand : IUserCommand, ISomeAnotherInterface
{
    private bool disposedValue;

    public int TestProperty => throw new NotImplementedException();

    public void Execute()
    {
        throw new NotImplementedException();
    }

    public int Test(string[] args)
    {
        throw new NotImplementedException();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: освободить управляемое состояние (управляемые объекты)
            }

            // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
            // TODO: установить значение NULL для больших полей
            disposedValue = true;
        }
    }

    // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
    // ~TestUserCommand()
    // {
    //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}*/
/*
Помои помои = new Помои();
Pig pig = new Pig();
pig.Feed(помои);
pig.Walk();
pig.Feed(помои);
Parrot Parrot = new Parrot();
Parrot.Feed(помои);
Parrot.Walk();
Parrot.Fly();
// вызов метода с реализацией в интерфейсе
((IFeedable)Parrot).Test();
*/
/* Пример проблем при наследовании классов
public abstract class Animal
{
    public abstract void Feed(Food food);
    public abstract void Walk();
    public abstract void Swim();
}

public abstract class FlyAnimal : Animal
{
    public abstract void Fly();
}


public abstract class Food { } 
public class Помои : Food { }
public class Семечки : Food { }

public class Pig : Animal
{
    public override void Feed(Food food)
    {
        if (food is not Помои)
            Console.WriteLine("Свинья такое не жрет");
        else
            Console.WriteLine("Хрю-хрю");
    }

    public override void Swim()
    {
        Console.WriteLine("Свинья показывает стиль butterfly в местной луже");
    }

    public override void Walk()
    {
        Console.WriteLine("Свинья бегает на четвереньках по загону");
    }
}

public class Parrot : FlyAnimal
{
    public override void Feed(Food food)
    {
        if (food is not Семечки)
            Console.WriteLine("Попугай смотрит на вас как на свинью");
        else
            Console.WriteLine("Хрю-хрю");
    }

    public override void Fly()
    {
        Console.WriteLine("Попугай занимается бомбардировкой свиньи");
    }

    public override void Swim()
    {
        Console.WriteLine("Попугай смешно тонет");
    }

    public override void Walk()
    {
        Console.WriteLine("Попугай смешно прыгает на двух лапках");
    }
}
*/
/*
public interface IWalkable
{
    void Walk();
}

public interface IFlyable
{
    void Fly();
}

public interface ISwimable
{
    void Swim();
}

public interface IFeedable 
{
    void Feed(Food food);
    void Test()
    {
        Console.WriteLine("Реализация по умолчанию");
    }
}

public abstract class Animal
{

}

public abstract class Food { }
public class Помои : Food { }
public class Семечки : Food { }

public class Pig : Animal, IFeedable, IWalkable, ISwimable
{
    public void Feed(Food food)
    {
        if (food is not Помои)
            Console.WriteLine("Свинья такое не жрет");
        else
            Console.WriteLine("Хрю-хрю");
    }

    public void Swim()
    {
        Console.WriteLine("Свинья показывает стиль butterfly в местной луже");
    }

    public void Walk()
    {
        Console.WriteLine("Свинья бегает на четвереньках по загону");
    }
}

public class Parrot : Animal, IFeedable, IFlyable, IWalkable
{
    public void Feed(Food food)
    {
        if (food is not Семечки)
            Console.WriteLine("Попугай смотрит на вас как на свинью");
        else
            Console.WriteLine("Хрю-хрю");
    }

    public void Fly()
    {
        Console.WriteLine("Попугай занимается бомбардировкой свиньи");
    }

    public void Walk()
    {
        Console.WriteLine("Попугай смешно прыгает на двух лапках");
    }

    //void IFeedable.Test()
    //{
    //    Console.WriteLine("sam,asdp;asd;as");
    //}
}

public class RubberDuck : Animal, ISwimable
{
    public void Swim()
    {
        Console.WriteLine("Резиновая уточка плавает в луже со свиньей");
    }
}
public class Duck : Animal, ISwimable, IFlyable, IWalkable, IFeedable
{
    public void Feed(Food food)
    {
        throw new NotImplementedException();
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Swim()
    {
        Console.WriteLine("Резиновая уточка плавает в луже со свиньей");
    }

    public void Walk()
    {
        throw new NotImplementedException();
    }
}
*/
// События        Publisher           Subscriber
// существуют объекты-публикаторы и объекты-подписчики
// с помощью событий публикаторы могут уведомить подписчиков
// о чем-то важном. События позволяют создать механизм 
// подписки на уведомления и механизм отправки уведомлений

// пример уведомления с помощью паттерна Publisher Subscriber
/*DNSManager manager = new DNSManager();
Human human1 = new Human();
Human human2 = new Human();
manager.Subscribe(human1);
manager.Subscribe(human2);

manager.GenerateNewInfo();
manager.Unsubscribe(human1);
//human1.CheckInfo(manager); // может быть не может так делать со всеми подписчиками 
manager.GenerateNewInfo();
//human2.CheckInfo(manager);

interface ISubscriber
{ 
    void OnPublish(object obj);
}
interface IPublisher
{
    void Subscribe(ISubscriber subscriber);
    void Unsubscribe(ISubscriber subscriber);
    void Publish(object obj);
}

class DNSManager : IPublisher
{ 
    public string HotInfo { get; set; }// предложение недели

    public void GenerateNewInfo()
    {
        HotInfo = "2 SSD по цене 3х!";
        Publish(HotInfo);
    }

    public void Publish(object obj)
    {
        foreach (var user in subscribers)
        {
            user.OnPublish(obj);
        }
    }
    List<ISubscriber> subscribers = new List<ISubscriber>();
    public void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }
}

class Human : ISubscriber
{
    public void OnPublish(object obj)
    {
        Console.WriteLine($"{obj} - shit");
    }
}*/
/*
DNSManager manager = new DNSManager();
Human human1 = new Human();
Human human2 = new Human();
manager.HotInfoChanged += human1.HotInfoReceive;
manager.HotInfoChanged += human2.HotInfoReceive;
manager.HotInfoReceived += human2.test;
manager.GenerateNewInfo(100);
manager.HotInfoChanged -= human1.HotInfoReceive;
//human1.CheckInfo(manager); // может быть не может так делать со всеми подписчиками 
manager.GenerateNewInfo(1000);
//human2.CheckInfo(manager);


class DNSManager
{
    public string HotInfo { get; set; }// предложение недели

    public void GenerateNewInfo(int price)
    {
        HotInfo = $"2 SSD по цене 3х! {price}$";
        // запуск события с проверкой, что подписчики
        // существуют (?.)
        HotInfoChanged?.Invoke(this, HotInfo);
    }
    // событие (модификатор event делегат название;
    // событие может вызвать на исполнение только класс
    // внутри которого оно объявлено

    public event EventHandler<string> HotInfoChanged;
    public event Func<object?, int> HotInfoReceived;    
}

class Human
{
    internal void HotInfoReceive(object? sender, string e)
    {
        Console.WriteLine($"Получение инфы: {e}");
    }

    internal int test(object? s)
    {
        throw new NotImplementedException();
    }
}*/

// делегаты - ссылки на методы, которые можно использовать
// для вызова группы методов за одну инструкцию
// делегаты объявляются в пространстве имен и в классах
// делегат сам по себе ничего не делает
// он вызывает на исполнение методы, на которые он ссылается
namespace Test
{
    public delegate int Compute(int x, int y);

    class Program
    {
        static void Main()
        {
            // создание делегата, который указывает (ссылается)
            // на метод Sum класса Program
            Compute compute = Sum;
            // вызов метода Sum через делегат
            int result = compute(10, 10);
            Console.WriteLine(result);
            // подписываем на делегат второй метод
            compute += Mult;
            result = compute(10, 10); // получаем результат
            // последнего вызванного метода
            Console.WriteLine(result);
            // тот же синтаксис, что для вызова события 
            // (потому что события это замаскированные делегаты)
            // (тут проверка на то, что у делегате есть
            // подписчики (делегат ссылается на методы))
            Compute computeNull = null;
            //int? res = computeNull(10, 10);// тут будет ошибка
            int ? res = computeNull?.Invoke(10, 10);// тут ок
        }

        static int Sum(int x, int y)
        {
            Console.WriteLine("Вызов метода Sum");
            return x + y;
        }
        static int Mult (int x, int y)
        {
            Console.WriteLine("Вызов метода Mult");
            return x * y;
        }
    }

    class Test
    {
        private delegate int Compute1(int x, int y);
    }
}