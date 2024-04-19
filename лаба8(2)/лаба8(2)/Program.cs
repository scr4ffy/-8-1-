using System;
try
{

    Console.WriteLine("Введите старшую часть числа:");
    long high = long.Parse(Console.ReadLine());
    Console.WriteLine("Введите младшую часть числа:");
    ulong low = ulong.Parse(Console.ReadLine());
    LongLong a = new LongLong(high, low);

    Console.WriteLine("Введите старшую часть второго числа:");
    long high2 = long.Parse(Console.ReadLine());
    Console.WriteLine("Введите младшую часть второго числа:");
    ulong low2 = ulong.Parse(Console.ReadLine());
    LongLong b = new LongLong(high2, low2);

    LongLong sum = a + b;
    Console.WriteLine($"Сумма: {sum}");

    LongLong diff = a - b;
    Console.WriteLine($"Разность: {diff}");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка!");
}
public class LongLong
{
    private long high;
    private ulong low;

    public LongLong(long high, ulong low)
    {
        this.high = high;
        this.low = low;
    }

    public static LongLong operator +(LongLong a, LongLong b)
    {
        ulong lowSum = a.low + b.low;
        long highSum = a.high + b.high;
        if (lowSum < a.low)
        {
            highSum++;
        }
        return new LongLong(highSum, lowSum);
    }

    public static LongLong operator -(LongLong a, LongLong b)
    {
        ulong lowR = a.low - b.low;
        long highR = a.high - b.high;
        if (a.low < b.low)
        {
            highR--;
        }
        return new LongLong(highR, lowR);
    }

    public static bool operator ==(LongLong a, LongLong b)
    {
        return a.high == b.high && a.low == b.low;
    }

    public static bool operator !=(LongLong a, LongLong b)
    {
        return !(a == b);
    }

    public override string ToString()
    {
        return $"{high} {low}";
    }
}
