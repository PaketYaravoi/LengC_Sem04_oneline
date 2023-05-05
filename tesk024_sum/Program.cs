// Создать прогрмму которая будет принимать на вход число (n) и выводить сумму чисел от 1 до n
// 7→ 28
// 4→ 10
// 8→36


Console.WriteLine("введите число ...");
int number = Convert.ToInt32(Console.ReadLine());
int SumFrom1ToN(int n )
{
    int sum = 0;
    for(int i = 0; i <= n; i++ )
    {
        sum = sum + i;
    }
    return sum;
}
Console.Clear();
Console.Write($"Сумма всех числе от 1 до {number} = ");
Console.WriteLine(SumFrom1ToN(number));

// Console.WriteLine(SumFrom1ToN(1000)); можно и так ввести число, фукция же и так принимает Int значит с расопзнованием числа проблем не будет;)
// Как еще можно представить эту функцию? Во первых есть определение.. sum всех чисел от 0 до n = n * (n + 1) / 2 давай спишем ее себе;)

int FastSumFrom1ToN( int n)
{
    
    return n * (n + 1)/2;              // так тоже все работет .. А вот например  так ↓     
                                      // n = n * (n + 1)/2;
                                     // return   ни хрена.. и даже int n = n * (n +1)/2 тоже нихрена..
                                     // кароче можно ворачивать саму формулу если таковая есть
                                      
}

Console.WriteLine(FastSumFrom1ToN(7));
