// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно плиндромом

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();

void Check (string number)
{
    if (number[0]==number[4] && number[1]==number[3])
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else Console.WriteLine($"Число {number} не вляется палиндромом.");
}

if (number.Length == 5)
{
    Check (number);
}
else Console.WriteLine("Error! Введите пятизначное число!");
