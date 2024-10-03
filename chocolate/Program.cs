using System;

class Program
{
    static void Main()
    {
        // Ввод входных данных
        Console.Write("Введите имеющиеся деньги ($): ");
        int money = int.Parse(Console.ReadLine());

        Console.Write("Введите цену за шоколадку ($): ");
        int price = int.Parse(Console.ReadLine());

        Console.Write("Введите количество оберток, нужное для получения одной шоколадки: ");
        int wrap = int.Parse(Console.ReadLine());

        // Вычисление максимального количества шоколадок
        int totalChocolates = BuyChocolates(money, price, wrap);

        Console.WriteLine($"Максимальное количество шоколадок: {totalChocolates}");
    }

    static int BuyChocolates(int money, int price, int wrap)
    {
        // Покупаем шоколадки с начальной суммой денег
        int chocolates = money / price;
        int wrappers = chocolates;

        // Обмен оберток на шоколадки
        while (wrappers >= wrap)
        {
            int additionalChocolates = wrappers / wrap;
            chocolates += additionalChocolates;
            wrappers = (wrappers % wrap) + additionalChocolates; // остаток оберток + новые обертки
        }

        return chocolates;
    }
}