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
