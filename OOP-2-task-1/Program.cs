using System;
using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

string pattern = @"^[a-zA-Z][a-zA-Z0-9]{1,9}$";

while (true)
{
    Console.Write("Введіть логін: ");
    string login = Console.ReadLine();

    if (Regex.IsMatch(login, pattern, RegexOptions.IgnoreCase))
    {
        Console.WriteLine("Логін підтверджено!");
        break;
    }
    else
    {
        Console.WriteLine("Некоректний логін (має бути 2-10 символів, тільки літери/цифри, перша - літера). \nСпробуйте ще раз.\n");
    }
}