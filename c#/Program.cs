abstract class Storage
{
    private string название;
    private string модель;

    public string Название { get => название; set => название = value; }
    public string Модель { get => модель; set => модель = value; }

    public abstract double ПолучитьОбъемПамяти();
    public abstract void КопироватьДанные();
    public abstract double ПолучитьСвободныйОбъемПамяти();
    public abstract void ПолучитьИнформацию();
}
class Flash : Storage
{
    private double скоростьUSB3;
    private double объемПамяти;

    public double СкоростьUSB3 { get => скоростьUSB3; set => скоростьUSB3 = value; }
    public double ОбъемПамяти { get => объемПамяти; set => объемПамяти = value; }

    public override double ПолучитьОбъемПамяти()
    {
        return объемПамяти;
    }

    public override void КопироватьДанные()
    {
        // реализация копирования данных на Flash-память
    }

    public override double ПолучитьСвободныйОбъемПамяти()
    {
        // реализация получения свободного объема памяти
        return 0;
    }

    public override void ПолучитьИнформацию()
    {
        // реализация получения информации о Flash-памяти
    }
}
class DVD : Storage
{
    private double скоростьЧтенияЗаписи;
    private string тип;

    public double СкоростьЧтенияЗаписи { get => скоростьЧтенияЗаписи; set => скоростьЧтенияЗаписи = value; }
    public string Тип { get => тип; set => тип = value; }

    public override double ПолучитьОбъемПамяти()
    {
        if (тип == "односторонний")
            return 4.7;
        else if (тип == "двусторонний")
            return 9;
        else
            return 0;
    }

    public override void КопироватьДанные()
    {
        // реализация копирования данных на DVD-диск
    }

    public override double ПолучитьСвободныйОбъемПамяти()
    {
        // реализация получения свободного объема памяти
        return 0;
    }

    public override void ПолучитьИнформацию()
    {
        // реализация получения информации о DVD-диске
    }
}
class HDD : Storage
{
    private double скоростьUSB2;
    private int количествоРазделов;
    private double объемРазделов;

    public double СкоростьUSB2 { get => скоростьUSB2; set => скоростьUSB2 = value; }
    public int КоличествоРазделов { get => количествоРазделов; set => количествоРазделов = value; }
    public double ОбъемРазделов { get => объемРазделов; set => объемРазделов = value; }

    public override double ПолучитьОбъемПамяти()
    {
        return количествоРазделов * объемРазделов;
    }

    public override void КопироватьДанные()
    {
        // реализация копирования данных на съемный HDD
    }

    public override double ПолучитьСвободныйОбъемПамяти()
    {
        // реализация получения свободного объема памяти
        return 0;
    }

    public override void ПолучитьИнформацию()
    {
        // реализация получения информации о съемном HDD
    }
}
