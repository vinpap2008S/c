using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Car
{
    public string Name { get; set; }
    public int Position { get; set; }
    public int Speed { get; set; }
    public event EventHandler<string> RaceFinished;

    public Car(string name)
    {
        Name = name;
        Position = 0;
        Speed = 0;
    }

    public abstract void Drive();

    protected virtual void OnRaceFinished(string message)
    {
        RaceFinished?.Invoke(this, message);
    }
}

public class SportsCar : Car
{
    public SportsCar(string name) : base(name) { }

    public override void Drive()
    {
        Speed = new Random().Next(1, 20);
        Position += Speed;
        if (Position >= 100)
        {
            OnRaceFinished($"{Name} пришел к финишу!");
        }
    }
}

public class PassengerCar : Car
{
    public PassengerCar(string name) : base(name) { }

    public override void Drive()
    {
        Speed = new Random().Next(1, 15);
        Position += Speed;
        if (Position >= 100)
        {
            OnRaceFinished($"{Name} пришел к финишу!");
        }
    }
}

public class RaceGame
{
    public delegate void RaceHandler(object sender, string message);

    public event RaceHandler RaceFinished;

    public void StartRace(IEnumerable<Car> cars)
    {
        while (cars.Any(car => car.Position < 100))
        {
            foreach (var car in cars)
            {
                car.Drive();
                Console.WriteLine($"{car.Name} на позиции {car.Position}");
            }
        }

        var winner = cars.OrderByDescending(car => car.Position).First();
        RaceFinished?.Invoke(this, $"{winner.Name} победил в гонке!");
    }
}

class Program
{
    static void Main()
    {
        RaceGame race = new RaceGame();

        SportsCar sportsCar = new SportsCar("Спортивный автомобиль");
        PassengerCar passengerCar = new PassengerCar("Легковой автомобиль");

        sportsCar.RaceFinished += (sender, message) => Console.WriteLine(message);
        passengerCar.RaceFinished += (sender, message) => Console.WriteLine(message);
        race.RaceFinished += (sender, message) => Console.WriteLine(message);

        race.StartRace(new List<Car> { sportsCar, passengerCar });
    }
}
