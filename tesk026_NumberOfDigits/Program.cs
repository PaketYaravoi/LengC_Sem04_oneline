/// Напишите программу которая принимает на входе число n и показывает сколько цифр в этом числе 
// 579 → 3;
// 7831597 → 7;
// 97 → 2;


int number = Convert.ToInt32(Console.ReadLine());

int NumberOfDigits(int n)
{
    int count;
    if(n == 0 )
    {
        count = 1;   
    }
    else
    {
        for(count = 0; n > 0; count++ )
        {
        n = n / 10;
        }    
    }
    return count;
}
Console.WriteLine(NumberOfDigits(number));