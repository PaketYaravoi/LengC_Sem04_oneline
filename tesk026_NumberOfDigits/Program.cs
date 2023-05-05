/// Напишите программу которая принимает на входе число n и показывает сколько цифр в этом числе 
// 579 → 3;
// 7831597 → 7;
// 97 → 2;


int number = Convert.ToInt32(Console.ReadLine());

int NumberOfDigits(int n)
{
    int count = 0;
    for(int i = number; i != 0; count++ )
    {
        i = i / 10;
    }
    return count;
}
Console.WriteLine(NumberOfDigits(number));