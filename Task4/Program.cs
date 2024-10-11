using System;
public class Answer {
static void PrintOddNumbers(int number)
{
// Введите свое решение ниже
int i = 1;

while (i < number)
{
i = i + 2;

Console.Write (i + " ");
}
} 
static public void Main(string[] args) {
int number;
if (args.Length >= 1) {
number = int.Parse(args[0]);
} else {
number = 7;
}
PrintOddNumbers(number);
}
}
