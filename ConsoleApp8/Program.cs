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
/*
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
*/

// Задание 2
/*
double s = 0, day = 10;
Console.WriteLine("Кол-во дней?");
int countDay = int.Parse(Console.ReadLine());
for (int i = 0; i < countDay; i++)
{
    s += day;
    day += day / 10;
}
Console.WriteLine($"Итого км: {s}");
*/

// тема 4.2 задание 1
/*double s = 0;
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    s += Math.Pow(-1, i) * 1 / (Math.Pow(2, i));
}
Console.WriteLine("Сумма элементов последовательности " + s);
*/
// тема 4.2 задание 2
/*double s = 0, summaSin = 0;
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()); 
for (int i = 1; i <= n; i++)
{
    summaSin += Math.Sin(i);
    s += 1 / summaSin;
}
Console.WriteLine("Сумма элементов последовательности " + s);
*/

// тема 4.5 задание 14
// сколько раз встречается минимальный элемент в последовательности
/*Console.WriteLine("Кол-во элементов?");
int count = int.Parse(Console.ReadLine());
int min = int.MaxValue, minCount = 0, value = 0;
for (int i = 0; i < count; i++)
{
    Console.Write($"Введите [{i}] элемент: ");
    value = int.Parse(Console.ReadLine());
    if (value < min)
    {
        min = value;
        minCount = 1;
    }
    else if (value == min)
        minCount++;
}
Console.WriteLine($"Минимальное значение: {min}, кол-во повторов: {minCount}");
*/
Console.WriteLine("Кол-во элементов?");
int count = int.Parse(Console.ReadLine());
int min1 = int.MaxValue, min2 = int.MaxValue, value;
for (int i = 0; i < count; i++)
{
    Console.Write($"Введите [{i}] элемент: ");
    value = int.Parse(Console.ReadLine());
    if (value < min1)
    {
        min2 = min1;// запоминаем прошлое минимальное
        min1 = value;// запоминаем самое минимальное
    }
    else if (value < min2)
        min2 = value;
}
Console.WriteLine($"Второе значение: {min2}");