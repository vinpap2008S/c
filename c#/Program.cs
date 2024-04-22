using System;
// Задание № 1
class GenericArray<T>
{
    private T[] array;

    public GenericArray(int size)
    {
        array = new T[size];
    }

    public void AddElement(int index, T element)
    {
        if (index >= 0 && index < array.Length)
        {
            array[index] = element;
        }
    }

    public void RemoveElement(int index)
    {
        if (index >= 0 && index < array.Length)
        {
            array[index] = default(T);
        }
    }

    public T GetElement(int index)
    {
        if (index >= 0 && index < array.Length)
        {
            return array[index];
        }
        return default(T);
    }

    public int GetLength()
    {
        return array.Length;
    }
}

// Задание № 2
using System;

abstract class BaseClass
{
    protected int field1;
    protected int field2;

    public BaseClass(int f1, int f2)
    {
        field1 = f1;
        field2 = f2;
    }

    public abstract int this[int index] { get; }

}

interface IMyInterface
{
    int MyMethod(int arg);
}

class DerivedClass : BaseClass, IMyInterface
{
    public DerivedClass(int f1, int f2) : base(f1, f2)
    {
    }

    public override int this[int index]
    {
        get
        {
            if (index % 2 == 0)
            {
                return field1;
            }
            else
            {
                return field2;
            }
        }
    }

    public int MyMethod(int arg)
    {
        return (field1 + field2) * arg;
    }
}

// Задание № 3

using System;
using System.Collections.Generic;

enum Position
{
    Student,
    Teacher,
    DepartmentHead,
    Staff
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Position Position { get; set; }

    public Person(string name, int age, Position position)
    {
        Name = name;
        Age = age;
        Position = position;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Position: {Position}";
    }
}

class Program
{
    static void Main()
    {
        // Задание № 1
        GenericArray<int> intArray = new GenericArray<int>(5);
        intArray.AddElement(0, 10);
        intArray.AddElement(1, 20);
        Console.WriteLine(intArray.GetElement(0));
        Console.WriteLine(intArray.GetLength());

        // Задание № 2
        DerivedClass derivedObj = new DerivedClass(3, 5);
        Console.WriteLine(derivedObj[0]);
        Console.WriteLine(derivedObj[1]);
        Console.WriteLine(derivedObj.MyMethod(2));

        // Задание № 3
        List<Person> peopleList = new List<Person>();
        peopleList.Add(new Person("Alice", 25, Position.Student));
        peopleList.Add(new Person("Bob", 35, Position.Teacher));

        foreach (var person in peopleList)
        {
            Console.WriteLine(person);
        }
    }
}
