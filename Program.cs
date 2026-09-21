int age = 15;
if (age >= 21){
    Console.WriteLine("Доступ разрешен");
}
Console.WriteLine("Программа продолжает работу");

int age = 15;
if (age >= 18){
    Console.WriteLine("Доступ разрешен");
} else {
    Console.WriteLine("Доступ запрещен");
    Console.WriteLine($"Осталось ждать: {18 - age} лет");
}


int age = 14;
if (age < 13) {
    Console.WriteLine("Ребенок");
} else if (age < 18) {
    Console.WriteLine("Подросток");
} else if (age >= 60) {
    Console.WriteLine("Пенсионер");
} else {
    Console.WriteLine("Взрослый");
}

int age = 16;
double height = 1.4;
bool isAdultPresent = True;
if ((age >= 14 && height >= 1.5) || (height < 1.5 && isAdultPresent)) {
    Console.WriteLine("Можно кататься");
} else {
    Console.WriteLine("Пока нельзя");
}

//вариант 4
Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0 && number > 0)
{
    Console.WriteLine("Четное положительное");
}
else if (number % 2 == 0);
{
    Console.WriteLine(Четное не положительное);
}
else if (number > 0);
{
    Console.WriteLine("Нечетное положительное");
}
else
{
    Console.WriteLine("Нечетное не положительное");
}


//вариант 9
Console.Write("Первый игрок (К/Н/Б):");
char player1 = char.ToUpper(Console.ReadLine()[0]);

Console.Write("Второй игрок(К/Н/Б):");
char player2 = char.ToUpper(Console.ReadLine()[0]);

if ((player1 != 'К' && player1 != 'Н' && player1 != 'Б')) 