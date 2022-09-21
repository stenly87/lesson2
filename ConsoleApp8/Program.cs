// Тема: Циклы в C#
/*1) цикл с предусловием
while (условие) условное выражение (true/false)
{ 
    тело цикла
    если тело состоит из 1 строки, фигурные скобки
    можно опустить
}
1 шаг: вычисление условия
2 шаг: если условие -> true, то выполняется тело цикла
3 шаг: вычисление условия ...
4 шаг: то же самое
если условие возврает false, то цикл не выполняется


// подсчитать сумму введенных 10 чисел
int sum = 0, count = 0;
int number;
while (count < 3)
{
    number = int.Parse(Console.ReadLine());
    sum += number;
    count++;
}
Console.Write("Сумма введенных чисел: " + sum);
*/
// 2 цикл с постусловием
/*
do 
{
  тело цикла
}
while (условие);
цикл с постусловием выполнится как минимум 1 раз

int sum = 0, count = 0;
int number;
do
{
    number = int.Parse(Console.ReadLine());
    sum += number;
    count++;
}
while (count < 10);
Console.Write("Сумма введенных чисел: " + sum);
*/
//3 цикл со счетчиком
/*
for(счетчик; условие; шаг)
{
    тело цикла
} 
счетчик - одна или несколько переменных,
участвующих в условии
шаг - изменение значения счетчиков
порядок:
1 - создание счетчика
2 - проверка условия
3 - если условие -> true, то выполняется тело цикла
4 - после тела цикла выполняется шаг
5 - переход на пункт 2
 */
// break - прерывание, выход из цикла
// continue - прерывание текущей итерации
// после continue следует шаг, потом условие
/*
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}
*/

// о-нотация
// за время O выполняется обычный код без циклов
// и условий
// цикл с вложенным циклом будет выполняться O*O

// 4
// цикл с перебором
/*
Перебирает все объекты в коллекции и позволяет 
выполнить какие-то операции над этими объектами 
в теле цикла. Объекты нельзя удалять
foreach(ссылка на объект in коллекция)
{
    тело цикла
}
*/

int group = 0;
double s = 0;
do
{
    Console.WriteLine("Номер группы?");
    group = int.Parse(Console.ReadLine());
    double a, b, c;
    switch (group)
    {
        case 1:
            Console.WriteLine("Основание и высота?");
            b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            s = 1 / 2f * b * h;
            break; 
        case 2:
            Console.WriteLine("Стороны а и б и угол между ними?");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            s = 1 / 2f * a * b * Math.Sin(angle);
            break;
        case 3:
            Console.WriteLine("Три стороны?");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double p = (a + b + c)/2;
            s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            break;
            default:
                continue;
    }
    Console.WriteLine("Площадь треугольника: " + s);
}
while (group != 0);
