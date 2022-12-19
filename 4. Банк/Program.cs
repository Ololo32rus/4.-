/*  
Вклад 1000 руб. Каждый месяц 2% от вклада: 
    1) за какой месяц увелечения вклада превысят 30 руб
    2) Через ск месяцев будет 1200 рябчиков 
*/
double Mounth = 15;
double Vklad = 1000;
double Procent = 0.02;
double sum = 0;

for (double i = 1; i <= Mounth; i++)
{
    Console.WriteLine($" Summ {Vklad} Vklad on Month {i} ");
    if (i <= Mounth)
        sum += Vklad;
    Vklad += Vklad * Procent;
    
    if (Vklad > 1030)
        Console.WriteLine(i); // тут не понимаю как задать конкретный день , а так код будет выводить на каждый строке где вклад превысит значение 1030

}





