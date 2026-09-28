int age = 15;
if (age >= 21) {
    Console.WriteLine("Доступ разрешён");
}
Console.WriteLine("Доступ запрещен");
Console.WriteLine($"Осталось ждать: {18 - age} лет");

int age1 = 14;
if (age1 < 13) {
    Console.WriteLine("Ребенок");
} else if (age < 18) {
    Console.WriteLine("Подросток");
} else if (age >= 60) {
    Console.WriteLine("Пенсионер");
} else {
    Console.WriteLine("Взрослый");
}

int age2 = 16;
double height = 1.4;
bool isAdultPresent = true;
if ((age2 >= 14 && height >= 1.5) || (height < 1.5 && isAdultPresent)) {
    Console.WriteLine("Можно кататься");
} else {
    Console.WriteLine("Пока нельзя");
}

//самостоятельные задания. Вариант А, В.
//вариант А
Console.Write("Введите целое число: ");
int num1 =
int.Parse(Console.ReadLine()!);

if (num1 % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

//Вариант В
Console.Write("Введите первое число: ");
int n1 =
int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int n2 =
int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число:");
int n3 =
int.Parse(Console.ReadLine()!);

int max = n1;

if (n2 > max)
{
    max = n2;
}
if (n3 > max)
{
    max = n3;
}
Console.WriteLine($"Наибольшее число: {max}");



Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//Индивидуальный вариант №5 и №10
//вариант №5
Console.Write("Введите сумму покупки:");
double sum1 = 
double.Parse(Console.ReadLine()!);
double finalSum1 = sum1;

if(sum1 > 1000)
{
    finalSum1 = sum1 * 0.9;
    Console.WriteLine("Приименена скидка 10%");
}
else if (sum1 > 500)
{
    finalSum1 = sum1 * 0.95;
    Console.WriteLine("Скидки нет");
}

Console.WriteLine($"Итоговая сумма к оплате: {finalSum1} руб.");

//вариант 10
Console.Write("Введите возраст пассажира: ");
int age5 =
int.Parse(Console.ReadLine()!);

Console.Write("Введите тип места (плацкарт, купе, СВ): ");
string seatType =
Console.ReadLine()!.Trim().ToLower();

double basePrice = 0;
double discount = 0;

switch (seatType)
{
    case "плацкарт":
    basePrice = 1000;
    break;
    case "купе":
    basePrice = 2000;
    break;
    case "св":
    basePrice = 3000;
    break;
    default:
    Console.WriteLine("Неверный тип места!");
    return;
}
if (age5 < 10)
{
    discount = 0.5;
    Console.WriteLine("Применена скидка 50% (ребенок)");
}
else if (age5 >= 18 && age5 <= 25)
{
    discount = 0.3;
    Console.WriteLine("Применена скидка 30% (студент)");
}
else if (age5 >= 60)
{
    discount = 0.4;
    Console.WriteLine("Применена скидка 40% (пенсионер)");
}
else 
{
    Console.WriteLine("Скидки нет");
}

double finalPrice = basePrice * (1 - discount);
Console.WriteLine($"Базовая цена: {basePrice} руб.");
Console.WriteLine($"Итоговая стоимость билета: {finalPrice} руб.");