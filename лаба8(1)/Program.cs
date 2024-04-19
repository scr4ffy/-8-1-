
using System;
try
{
   
    Console.WriteLine("Введите угол в градусах:");
    double degrees = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите угол в минутах:");
    double minutes = double.Parse(Console.ReadLine());
    if (minutes < 0 | degrees < 0)
    {
        Console.WriteLine("Введено некорректное значение");
    }
    else
    {
        AngleD angle = new AngleD(degrees, minutes);

        Console.WriteLine($"Угол в радианах: {angle.ToRadians()}");
        Console.WriteLine($"Синус угла: {angle.Sin()}");

        Console.WriteLine("Введите угол для сравнения:");
        double srDegrees = double.Parse(Console.ReadLine());
        double srMinutes = double.Parse(Console.ReadLine());

        AngleD srAngle = new AngleD(srDegrees, srMinutes);
        Console.WriteLine($"Углы равны: {angle.Equals(srAngle)}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Введено некорректное значение");
}
public interface IAngle
{
    double Degrees { get; set; }
    double Minutes { get; set; }
    double ToRadians();
    void Normalize();
    double Sin();
    bool Equals(IAngle other);
}

public abstract class Angle : IAngle
{
    public double Degrees { get; set; }
    public double Minutes { get; set; }

    public Angle(double degrees, double minutes)
    {
        Degrees = degrees;
        Minutes = minutes;
    }

    public double ToRadians()
    {
        return (Degrees + Minutes / 60) * Math.PI / 180;
    }

    public void Normalize()
    {
        Degrees = Degrees % 360;
        if (Degrees < 0) Degrees += 360;
        Minutes = Minutes % 60;
        if (Minutes < 0) Minutes += 60;
    }

    public double Sin()
    {
        return Math.Sin(ToRadians());
    }

    public bool Equals(IAngle other)
    {
        return Degrees == other.Degrees && Minutes == other.Minutes;
    }
}

public class AngleD : Angle
{
    public AngleD(double degrees, double minutes) : base(degrees, minutes)
    {
    }
}
