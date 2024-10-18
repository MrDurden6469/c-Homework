Console.Write("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 10;
int secondDigit = number % 10;

if (number < 10 && number >99) 
Console.WriteLine("Ошибка ввода");

else 

if (firstDigit > secondDigit)

Console.WriteLine(firstDigit);

else 

Console.WriteLine(secondDigit);