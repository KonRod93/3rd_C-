// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string numberStr = Console.ReadLine();
int stringnumberStr = Convert.ToInt32(numberStr);

void CheckNumber(int stringnumberStr)
{
    if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
    {
        Console.WriteLine($"Ваше число: {numberStr} - Палиндром.");
    }
    else Console.WriteLine($"Ваше число: {numberStr} - Не палиндром.");
}

if (numberStr.Length == 5)
{
    CheckNumber(stringnumberStr);
}
else Console.WriteLine("Ошибка.Введите пятизначное число.");