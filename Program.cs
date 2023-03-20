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

void PrintArr(string[] arr, string text) // Вывод массива
{
    Console.WriteLine(text);
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" '{arr[i]}' ");
    }
    Console.WriteLine(" ]");
}

string[] NewArr(string[] oldArr, string[] newArr) // Заполняем новый массив
{
    int i = 0;
    int j = 0;
    while(i < oldArr.Length)
    {
        string checkValue = oldArr[i];
        if(checkValue.Length <= 3)
        {
            newArr[j] = oldArr[i];
            j++;
        }
        i++;
    }
    Array.Resize(ref newArr, j);
    return newArr;
}

Console.WriteLine("Задайте длинну массива, значения, а я сделаю массив из значений, где 3 или меньше символов.");
// Задаем длинну массива:
int number = NumberFromUser("Сколько элементов будет в массиве? > ");

// Проверяем, что число >= 1:
if(PositiveNumber(number))
Console.WriteLine("В массиве не должно быть меньше одного значения!");

// Создаем два массива заданной длинны:
string[] array = new string[number];
string[] newArray = new string[number];

// Пользователь заполняет массив:
FillArr(array);

// Вывод заданного массива на экран:
PrintArr(array, "Заданный массив:");

// Заполняем новый массив и отсекаем пустые значения:
newArray = NewArr(array, newArray);

// Печатаем новый массив:
PrintArr(newArray, "Результат:");