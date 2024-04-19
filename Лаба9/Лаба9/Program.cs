using System;
try
{
    Console.WriteLine("Введите сумму в долларах: ");
    double sumdollars = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите курс обмена доллара: ");
    double kdollars = Convert.ToDouble(Console.ReadLine());
    Dollar dollar = new Dollar(sumdollars, kdollars);

    Console.WriteLine("Введите сумму в евро: ");
    double sumeuros = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите курс обмена евро: ");
    double keuros = Convert.ToDouble(Console.ReadLine());
    Euro euro = new Euro(sumeuros, keuros);

    Console.WriteLine("Введите сумму в фунтах: ");
    double sumpounds = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите курс обмена фунтов: ");
    double kpounds = Convert.ToDouble(Console.ReadLine());
    Pound pound = new Pound(sumpounds, kpounds);
    if (sumdollars < 0 | kdollars < 0 | sumeuros < 0 | keuros < 0 | kpounds < 0 | sumpounds < 0)
    {
        Console.WriteLine("Ошибка ввода.");
    }
    else
    {
        Purse purse = new Purse(3);
        purse.AddCurrency(dollar, 0);
        purse.AddCurrency(euro, 1);
        purse.AddCurrency(pound, 2);

        Console.WriteLine("Введите индекс валюты для конвертации(0 - Доллар, 1 - Евро, 2 - Фунт): ");
        int index = Convert.ToInt32(Console.ReadLine());
        purse.ConvertToRub(index);

        double totalSumInRubles = purse.GetTotalSumInRubles();
        Console.WriteLine($"Общая сумма в рублях: {totalSumInRubles}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Ошибка!");
}
abstract class Currency
{
    public double Sum { get; set; }

    public Currency(double sum)
    {
        Sum = sum;
    }

    public abstract double ConvertToRub();
    public abstract void DisplaySum();
}

class Dollar : Currency
{
    public double ExchangeK { get; }

    public Dollar(double sum, double exchangeK) : base(sum)
    {
        ExchangeK = exchangeK;
    }

    public override double ConvertToRub()
    {
        return Sum * ExchangeK;
    }

    public override void DisplaySum()
    {
        Console.WriteLine($"Сумма в долларах: {Sum}");
    }
}

class Euro : Currency
{
    public double ExchangeK { get; }

    public Euro(double sum, double exchangeK) : base(sum)
    {
        ExchangeK = exchangeK;
    }

    public override double ConvertToRub()
    {
        return Sum * ExchangeK;
    }

    public override void DisplaySum()
    {
        Console.WriteLine($"Сумма в евро: {Sum}");
    }
}

class Pound : Currency
{
    public double ExchangeK { get; }

    public Pound(double amount, double exchangeRate) : base(amount)
    {
        ExchangeK = exchangeRate;
    }

    public override double ConvertToRub()
    {
        return Sum * ExchangeK;
    }

    public override void DisplaySum()
    {
        Console.WriteLine($"Сумма в фунтах: {Sum}");
    }
}

class Purse
{
    private Currency[] currencies;

    public Purse(int size)
    {
        currencies = new Currency[size];
    }

    public void AddCurrency(Currency currency, int index)
    {
        currencies[index] = currency;
    }

    public void ConvertToRub(int index)
    {
        double rubles = currencies[index].ConvertToRub();
        Console.WriteLine($"Конвертированая сумма в рублях: {rubles}");
    }
    public double GetTotalSumInRubles()
    {
        double totalSum = 0;
        foreach (var currency in currencies)
        {
            if (currency != null)
            {
                totalSum += currency.ConvertToRub();
            }
        }
        return totalSum;
    }
}