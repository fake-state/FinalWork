int NumberFromUser(string massage) // Ввод числа от пользователя
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool PositiveNumber(int number) // Проверка, что число больше 0 (результат инвертирован)
{
    if (number >= 1) return false;
    else return true;
}

void FillArr(string[] arr) // Заполнение массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите значение №{i+1} >");
        arr[i] = Console.ReadLine();
    }
}



Console.WriteLine("Задайте длинну массива, значения, а я сделаю массив из значений, где 3 или меньше символов.");
// Задаем длинну массива:
int number = NumberFromUser("Сколько строк будет в массиве? > ");

// Проверяем, что число >= 1:
if(PositiveNumber(number))
Console.WriteLine("В массиве не должно быть меньше одного значения!");

string[] array = new string[number];

// Пользователь заполняет массив:
FillArr(array);