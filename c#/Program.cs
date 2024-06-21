
class SubsystemA
{
    public void A1()
    { }
}
class SubsystemB
{
    public void B1()
    { }
}
class SubsystemC
{
    public void C1()
    { }
}

public class Facade
{
    SubsystemA subsystemA;
    SubsystemB subsystemB;
    SubsystemC subsystemC;

    public Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
    {
        subsystemA = sa;
        subsystemB = sb;
        subsystemC = sc;
    }
    public void Operation1()
    {
        subsystemA.A1();
        subsystemB.B1();
        subsystemC.C1();
    }
    public void Operation2()
    {
        subsystemB.B1();
        subsystemC.C1();
    }
}

class Client
{
    public void Main()
    {
        Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
        facade.Operation1();
        facade.Operation2();
    }
}
class Client
{
    public void Request(Target target)
    {
        target.Request();
    }
}
// класс, к которому надо адаптировать другой класс   
class Target
{
    public virtual void Request()
    { }
}

// Адаптер
class Adapter : Target
{
    private Adaptee adaptee = new Adaptee();

    public override void Request()
    {
        adaptee.SpecificRequest();
    }
}

// Адаптируемый класс
class Adaptee
{
    public void SpecificRequest()
    { }
}
class Client
{
    public void Request(Target target)
    {
        target.Request();
    }
}
// класс, к которому надо адаптировать другой класс   
class Target
{
    public virtual void Request()
    { }
}

// Адаптер
class Adapter : Target
{
    private Adaptee adaptee = new Adaptee();

    public override void Request()
    {
        adaptee.SpecificRequest();
    }
}

// Адаптируемый класс
class Adaptee
{
    public void SpecificRequest()
    { }
}
