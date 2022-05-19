//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1//

Console.WriteLine();

int EnterNumberTest()
{
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt)
    {
        Console.Write("Введите 3х значное число : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) && (numberSTR.Length == 3))
        {
            number = numberInt;
            readlineFromStrToInt = false;
        }
        else if (int.TryParse(numberSTR, out numberInt) &&(numberSTR.Length != 3))
             Console.WriteLine("Нужно ввести 3х значное число , к примеру 145 ");
        else Console.WriteLine("Ввели не число, повторите попытку");
    }
    return number;   
}
int number = EnterNumberTest();
int secondCharNumber = (number%100)/10;
Console.WriteLine($"{number} -> {secondCharNumber}");

Console.ReadLine();

