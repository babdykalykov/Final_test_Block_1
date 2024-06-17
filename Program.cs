// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив 
//из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
// решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
// массивами.

// Примеры:

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine();
Console.WriteLine("Массивы:");
Console.WriteLine("1 – массив: [“Hello”, “2”, “world”, “:-)”]");
Console.WriteLine("2 – массив: [“1234”, “1567”, “-2”, “computer science”]");
Console.WriteLine("3 – массив: [“Russia”, “Denmark”, “Kazan”]");
Console.WriteLine();

string[] array = new string[] { };

string input = ReadInput("Введите номер массива: ");

if (input == "1")
{
    array = new string[] { "Hello", "2", "world", ":-)" };
}
else if (input == "2")
{
    array = new string[] { "1234", "1567", "-2", "computer science" };
}
else if (input == "3")
{
    array = new string[] { "Russia", "Denmark", "Kazan" };
}
else
{
    Console.WriteLine($"{input} - Такой команды нет");
    array = new string[0]; // Или null, если не нужен массив
}

int Count = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) Count++;
}

string[] newArray = new string[Count];
int Count1 = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[Count1] = array[i];
        Count1++;
    }
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);

// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

//  Функция вывода массива в терминал
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}